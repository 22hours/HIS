# Scenario 종추Ver
> 1. When a printer request comes in.
> 2. `The spoolsv.exe` process runs automatically.
> 3. **DLL Injection** works with `typepress.dll`.
> 4. Activate the **authentication** process. <br>
> 5-1. Login **Success** -> **Print O**<br>
> 5-2. Login **Failed** -> **Print X**

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
  - 회식이 너무 많아 ㅠㅠㅠㅠㅠ(19.08.01)

# To-do
- CodeReview(DLL && DLLInjection)
- SelfAuth && OAuth
- DLLInjection -> LoginView
- *Login-View(UI Develop)*
- *Connect DB(Login)*
