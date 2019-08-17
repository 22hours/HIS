#include "stdio.h"
#include "pch.h"
#include "windows.h"
#include "shellapi.h"
#include "iostream"

#define DEF_PROCESS_NAME  "notepad.exe"
HINSTANCE g_hInstance = NULL;
HHOOK g_hHook = NULL;
HWND g_hWnd = NULL;

BOOL WINAPI DllMain(HINSTANCE hinstDLL, DWORD dwReason, LPVOID lpvReserved)
{
	switch (dwReason)
	{
	case DLL_PROCESS_ATTACH:
		g_hInstance = hinstDLL;
	break;
	/*
	case DLL_PROCESS_DETACH:
		break;*/
	}

	return TRUE;
}

LRESULT CALLBACK KeyboardProc(int nCode, WPARAM wParam, LPARAM lParam)
{
	char szPath[MAX_PATH] = { 0, };
	char* p = NULL;

	if (nCode >= 0)
	{
	if (!(lParam & 0x80000000))
		{
			GetModuleFileName(NULL,szPath, MAX_PATH);
			p = strrchr(szPath, '\\');
		if (!_stricmp(p + 1, DEF_PROCESS_NAME))
				return 1;
		}
	}
	return CallNextHookEx(g_hHook, nCode, wParam, lParam);
}

#ifdef __cplusplus
extern "C" {
#endif
	__declspec(dllexport) void HookStart()
	{
		g_hHook = SetWindowsHookEx(WH_KEYBOARD, KeyboardProc, g_hInstance, 0);
		
		SHELLEXECUTEINFO ShExecInfo = { 0 };
		ShExecInfo.cbSize = sizeof(SHELLEXECUTEINFO);
		ShExecInfo.fMask = SEE_MASK_NOCLOSEPROCESS;
		ShExecInfo.hwnd = NULL;
		ShExecInfo.lpVerb = NULL;
		ShExecInfo.lpFile = "c:\\TelerikWpfApp3.exe";
		ShExecInfo.lpParameters = "";
		ShExecInfo.lpDirectory = NULL;
		ShExecInfo.nShow = SW_SHOW;
		ShExecInfo.hInstApp = NULL;
		//ShellExecuteA(NULL, "open", "c:\\TelerikWpfApp3.exe", NULL, NULL, SW_SHOWNORMAL);
		do {
			ShellExecuteEx(&ShExecInfo);
		}
		while (WaitForSingleObject(ShExecInfo.hProcess, INFINITE));
		ShellExecuteEx(&ShExecInfo);
	}
	__declspec(dllexport) void HookStop()
	{
		if (g_hHook)
		{
			UnhookWindowsHookEx(g_hHook);
			g_hHook = NULL;
		}
	}
#ifdef __cplusplus
}

#endif