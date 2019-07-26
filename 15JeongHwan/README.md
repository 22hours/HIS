## 활자 인쇄소 




## GOAL : CONTROL ALL DOC ON PRINTER

 
--- 
### 2019-07-26 Commit

#### Success

Finally we find clue!!

We think only answer is global hooking and we prove it!

To Block Print Doc ....

![](./img/hook1.png)

> hooking window to spooler message and we can inject our dll in that control flow

so we need hooking tech

**To sum up this** 

- First. We need hook spoolvs.exe that is Print Spooler Service

- Second. Change the normal printing control flow to our Scenario

- Third. We get the money!
 
 

 
#### Issue
![](./img/issue1.JPG)


First i success comfile "windows print hooking.cpp"

but i can't get "spoolsv.exe" process.....



---
### 2019-07-14 Commit

### Research

 - Using Global API Hooking we can control all Printing Docs in Window system
 
 - for my hook ability, devleoping [notepad hook program](https://github.com/22hours/HIS/tree/master/15JeongHwan/APIHookinig/NotepadHookV0) now use c++ language 

### Issue

- HOW CAN I GET GDI32.dll function use Global API Hooking?

### ToDo

improve my ability....

### Reference

[1.](http://www.devx.com/cplus/Article/28862#codeitemarea)
[2.](http://forum.madshi.net/viewtopic.php?t=4046)
[3.](https://m.blog.naver.com/PostView.nhn?blogId=bhcastle&logNo=80167013605&proxyReferer=http%3A%2F%2Fm.blog.daum.net%2Fknightofelf%2F16044)
[4.](https://progamercity.net/c-code/352-api-hooking-technique.html)
