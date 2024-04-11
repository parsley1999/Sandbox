@echo off
set logFileName="c:\TEMP\BIOVIA-Workbook-setup.log"

echo net user lamp775 LinuxApacheMysqlPhp /add /y > %logFileName%
net user lamp775 LinuxApacheMysqlPhp /add /y >> %logFileName% 2>&1
echo net localgroup administrators lamp775 /add >> %logFileName% 
net localgroup administrators lamp775 /add >> %logFileName% 2>&1
