cd /d "C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\Tools"
call VsDevCmd.bat
@ECHO ON
cd /d "%~dp0\..\bin\Debug"
installutil MCAB-PC-Services.exe /u
@ECHO 10ÃëÖÓºó¹Ø±Õ´°¿Ú
@ping 127.0.0.1 -n 10 >nul
