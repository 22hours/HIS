// dllmain.cpp : DLL 응용 프로그램의 진입점을 정의합니다.
#include "stdafx.h"

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
	case DLL_PROCESS_ATTACH: {

		STARTUPINFO		si1 = { 0, };
		PROCESS_INFORMATION		pi1;
		DWORD	return_val1;
		TCHAR	command1[] = TEXT("C:\\Users\\jklh0\\source\\github\\HIS\\Client\\HISClient\\HISClient\\bin\\Debug\\HISClient.exe"); // 경로 수정필요.

		si1.cb = sizeof(si1);
		CreateProcess(NULL, command1, NULL, NULL, TRUE, 0, NULL, NULL, &si1, &pi1);	// CreateProcess 1
		CloseHandle(pi1.hThread);



		WaitForSingleObject(pi1.hProcess, INFINITE); // 자식 프로세스의 종료를 기다리지 않으면 자식 프로세스가
													 // 종료되기도 전에 아래 코드들이 실행되어 다른 결과를 초례할 수 있다.

		GetExitCodeProcess(pi1.hProcess, &return_val1);		// 자식 프로세스에서 반환한 종료코드(Exit Code)를 return_val1에다가.
															// Return 0, -1 : 프로그램 종료.
															// Return 1 : 인쇄물 '출력'

		if (return_val1 == -1 || return_val1 == 0) {
			return 0;
		}
		else {
			//PrintOut()
		}
		CloseHandle(pi1.hProcess);

		break;
    }
    return TRUE;
}

