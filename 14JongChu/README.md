# Scenario 종추Ver(19.08.23)

**시나리오 :**
> 1. `한글`, `워드` 등의 실행중인 프로세스에서 '인쇄'버튼을 누른다.
> 2. 로컬 디렉토리에 있는 `LoginForm.exe`를 실행시킨다.
> 3. Login성공 -> 인쇄작업 시작.
>   3-1. 인쇄매수 만큼의 마일리지 DB에서 차감.
> 4. Login실패 -> Exit<br>

**원리 :** 
> 1. AppInit_DLLs에 Value값을 재지정 -> `user32.dll`사용하는 프로세스에 `typress.dll`을 컴퓨터부팅과 동시에 injection.
> ※ 대상 프로세스인 `spoolsv.exe`와 `splwow64.exe`는 `user32.dll`을 사용)
> 2. `typress.dll`에서는 지금 현재 자신을 호출한 프로세스가 (`spoosv.exe` || `splwow64.exe`인 경우 실행)
> 3. C# WPF기반의 `typressLogin.exe` 호출

# History
- First commit about view.(19.07.23~)
- Following Deviare2 & windows-printer-activity-hooking-sample (19.07.25~)<br>
  Ref. 
  - PM tutorial : https://github.com/srw/windows-printer-activity-hooking-sample<br>
  - Deviare2 git : https://github.com/nektra/Deviare2
  - Deviare2 article : https://blog.nektra.com/main/2012/05/18/logging-printer-activity/
  - Deviare2 tutorial : https://blog.nektra.com/main/2012/05/18/logging-printer-activity/
  - spoolsv.exe : https://github.com/jongwuner/Etc/wiki/Spoolsv.exe-%3F
- *Solution* is DLL Injection : https://reversecore.com/38?category=216978

# Issues
- **Success Deviare Tutorial.(19.08.04)** 
  - ![ex_screenshot](./img/Success_Deviare_LI1.jpg)  
- **Success View && DB Connect(Join).(19.08.14)**
  - ![view_screenshot](https://user-images.githubusercontent.com/16419202/63029837-373fd400-beec-11e9-97f4-472eb8f0cb23.png)
  - ![DB_screenshot1](https://user-images.githubusercontent.com/16419202/63029529-b1238d80-beeb-11e9-998e-af519b5f1119.png)
  - ![DB_screenshot2](https://user-images.githubusercontent.com/16419202/63029408-7b7ea480-beeb-11e9-93ea-b38e35b6d220.png)
- **Commit Issue : HIS_1.0.2(Ver.Jongchu)**
  - ![commit_issue](https://user-images.githubusercontent.com/16419202/62830365-a4cbd600-bc48-11e9-864e-5917755614e9.PNG)
- ## Doing DLL Injection Tutorial(19.07.26~)
  - https://reversecore.com/38?category=216978
  - *Success* Notepad DLL Injection(19.07.29) 
    - link. https://github.com/jongwuner/Etc/tree/master/Hooking/DLL%20Injection_Notepad
    - ref. https://wendys.tistory.com/23
  - 부팅과 동시에 DLL Memory에 삽입. register.
    - ref1. https://suban.tistory.com/679
    - ref2. https://reversecore.com/41

# To-do
- CodeReview(DLL && DLLInjection)
- SelfAuth && OAuth
- DLLInjection -> LoginView
- *Login-View(UI Develop)*
- *Connect DB(Login)*
