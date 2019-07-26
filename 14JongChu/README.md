# 활자인쇄소 Scenario 종추Ver
> 1. When a printer request comes in,
> 2. The spoolsv.exe process runs automatically.
> 3. DLL Injection works with typepress.dll.
> 4. Type Membership_ Activate the authentication process. <br>
> 5-1. Login **Success** -> **Print O**<br>
> 5-2. Login **Failed** -> **Print X**

# History
- First commit about view.(07.23~)
- Following Deviare2 & windows-printer-activity-hooking-sample (07.25~)<br>
  Ref. 
  - PM tutorial : https://github.com/srw/windows-printer-activity-hooking-sample<br>
  - Deviare2 git : https://github.com/nektra/Deviare2
  - Deviare2 article : https://blog.nektra.com/main/2012/05/18/logging-printer-activity/
  - Deviare2 tutorial : https://blog.nektra.com/main/2012/05/18/logging-printer-activity/
- Maybe DLL Injection? : https://reversecore.com/38?category=216978

# Now
![ex_screenshot](./img/present.png)  
- ## **what the Spoolsv.exe ???? (07.26)**
  - spoolsv.exe : https://github.com/jongwuner/Etc/wiki/Spoolsv.exe-%3F

- ## Doing DLL Injection Tutorial(07.26~)
  - https://reversecore.com/38?category=216978
