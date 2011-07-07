# Auto-generated by EclipseNSIS Script Wizard
# Jun 6, 2011 4:54:19 PM

Name "ACS Importer"

# General Symbol Definitions
!define REGKEY "SOFTWARE\$(^Name)"
!define VERSION 1.0.0
!define COMPANY Azavea
!define URL http://www.azavea.com

# MUI Symbol Definitions
!define MUI_ICON "${NSISDIR}\Contrib\Graphics\Icons\modern-install-blue.ico"
!define MUI_FINISHPAGE_NOAUTOCLOSE
!define MUI_STARTMENUPAGE_REGISTRY_ROOT HKLM
!define MUI_STARTMENUPAGE_NODISABLE
!define MUI_STARTMENUPAGE_REGISTRY_KEY ${REGKEY}
!define MUI_STARTMENUPAGE_REGISTRY_VALUENAME StartMenuGroup
!define MUI_STARTMENUPAGE_DEFAULTFOLDER "ACS Importer"
!define MUI_FINISHPAGE_SHOWREADME $INSTDIR\README.txt
!define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\modern-uninstall-colorful.ico"
!define MUI_UNFINISHPAGE_NOAUTOCLOSE

# Included files
!include Sections.nsh
!include MUI2.nsh
#!include ShellLink.nsh

# Variables
Var StartMenuGroup

# Installer pages
!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_STARTMENU Application $StartMenuGroup
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_PAGE_FINISH
!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES

# Installer languages
!insertmacro MUI_LANGUAGE English

# Installer attributes
OutFile ACSInstaller.exe
InstallDir "$PROGRAMFILES\ACS Importer"
CRCCheck on
XPStyle on
ShowInstDetails show
VIProductVersion 1.0.0.0
VIAddVersionKey ProductName "ACS Importer"
VIAddVersionKey ProductVersion "${VERSION}"
VIAddVersionKey CompanyName "${COMPANY}"
VIAddVersionKey CompanyWebsite "${URL}"
VIAddVersionKey FileVersion "${VERSION}"
VIAddVersionKey FileDescription ""
VIAddVersionKey LegalCopyright ""
InstallDirRegKey HKLM "${REGKEY}" Path
ShowUninstDetails show

!define SHORTCUTFILE "$SMPROGRAMS\$StartMenuGroup\ACS Importer.lnk"

# Installer sections
Section -Main SEC0000
    SetOutPath $INSTDIR
    SetOverwrite on
    File /r C:\projects\Temple_Univ_NIJ_Predictive_Policing\csharp\Azavea.NijPredictivePolicing.AcsImporter\bin\x86\Debug\*
    ;File /r C:\projects\Temple_Univ_NIJ_Predictive_Policing\csharp\Azavea.NijPredictivePolicing.AcsImporter\bin\Debug\*
    File C:\projects\Temple_Univ_NIJ_Predictive_Policing\doc\README.txt
	
	SetOutPath $INSTDIR\Docs
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\doc\README.txt
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\doc\Install.doc
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\doc\Manual.doc
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\doc\ACS_Importer_Flowchart.jpg
	
	#Licenses#
	SetOutPath $INSTDIR\Licenses
	SetOutPath $INSTDIR\Licenses\Ionic
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\lib\dotnetzip\License.txt
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\lib\dotnetzip\PleaseDonate.txt
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\lib\dotnetzip\Readme.txt	
	SetOutPath $INSTDIR\Licenses\exceldatareader
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\lib\excelDataReader\license.txt	
	SetOutPath $INSTDIR\Licenses\geoapi
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\lib\geoapi\lgpl-2.1.txt
	SetOutPath $INSTDIR\Licenses\json
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\lib\json\readme.txt
	SetOutPath $INSTDIR\Licenses\log4net
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\lib\log4net\LICENSE.txt
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\lib\log4net\NOTICE.txt
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\lib\log4net\README.txt
	SetOutPath $INSTDIR\Licenses\nettopologysuite
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\lib\nettopologysuite\License.txt
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\lib\nettopologysuite\lgpl-3.0.txt
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\lib\nettopologysuite\lgpl-2.1.txt
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\lib\nettopologysuite\Iesi.Collections.License.txt
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\lib\nettopologysuite\Rtools.Util.License.txt
	SetOutPath $INSTDIR\Licenses\spatialite
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\lib\spatialite\lgpl-v3.txt
	SetOutPath $INSTDIR\Licenses\sqlite
	File C:\projects\Temple_Univ_NIJ_Predictive_Policing\lib\sqlite\license.txt	
	
    SetOutPath $SMPROGRAMS\$StartMenuGroup	
	CreateShortcut "$SMPROGRAMS\$StartMenuGroup\View Files.lnk" "$INSTDIR"	
    CreateShortcut "${SHORTCUTFILE}" "cmd" "/k cd $INSTDIR"
	ShellLink::SetRunAsAdministrator "${SHORTCUTFILE}"
	Pop $0
	ShellLink::SetShortCutWorkingDirectory "${SHORTCUTFILE}" $INSTDIR
	Pop $0
	
    WriteRegStr HKLM "${REGKEY}\Components" Main 1
SectionEnd

Section -post SEC0001
    WriteRegStr HKLM "${REGKEY}" Path $INSTDIR
    SetOutPath $INSTDIR
    WriteUninstaller $INSTDIR\uninstall.exe
    !insertmacro MUI_STARTMENU_WRITE_BEGIN Application
    SetOutPath $SMPROGRAMS\$StartMenuGroup
    CreateShortcut "$SMPROGRAMS\$StartMenuGroup\Uninstall $(^Name).lnk" $INSTDIR\uninstall.exe
    !insertmacro MUI_STARTMENU_WRITE_END
    WriteRegStr HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$(^Name)" DisplayName "$(^Name)"
    WriteRegStr HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$(^Name)" DisplayVersion "${VERSION}"
    WriteRegStr HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$(^Name)" Publisher "${COMPANY}"
    WriteRegStr HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$(^Name)" URLInfoAbout "${URL}"
    WriteRegStr HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$(^Name)" DisplayIcon $INSTDIR\uninstall.exe
    WriteRegStr HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$(^Name)" UninstallString $INSTDIR\uninstall.exe
    WriteRegDWORD HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$(^Name)" NoModify 1
    WriteRegDWORD HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$(^Name)" NoRepair 1
SectionEnd

# Macro for selecting uninstaller sections
!macro SELECT_UNSECTION SECTION_NAME UNSECTION_ID
    Push $R0
    ReadRegStr $R0 HKLM "${REGKEY}\Components" "${SECTION_NAME}"
    StrCmp $R0 1 0 next${UNSECTION_ID}
    !insertmacro SelectSection "${UNSECTION_ID}"
    GoTo done${UNSECTION_ID}
next${UNSECTION_ID}:
    !insertmacro UnselectSection "${UNSECTION_ID}"
done${UNSECTION_ID}:
    Pop $R0
!macroend

# Uninstaller sections
Section /o -un.Main UNSEC0000
    Delete /REBOOTOK $INSTDIR\README.txt
    RmDir /r /REBOOTOK $INSTDIR
    DeleteRegValue HKLM "${REGKEY}\Components" Main
SectionEnd

Section -un.post UNSEC0001
    DeleteRegKey HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\$(^Name)"
    Delete /REBOOTOK "$SMPROGRAMS\$StartMenuGroup\Uninstall $(^Name).lnk"
    Delete /REBOOTOK $INSTDIR\uninstall.exe
    DeleteRegValue HKLM "${REGKEY}" StartMenuGroup
    DeleteRegValue HKLM "${REGKEY}" Path
    DeleteRegKey /IfEmpty HKLM "${REGKEY}\Components"
    DeleteRegKey /IfEmpty HKLM "${REGKEY}"
    RmDir /REBOOTOK $SMPROGRAMS\$StartMenuGroup
    RmDir /REBOOTOK $INSTDIR
SectionEnd

# Installer functions
Function .onInit
    InitPluginsDir
FunctionEnd

# Uninstaller functions
Function un.onInit
    ReadRegStr $INSTDIR HKLM "${REGKEY}" Path
    !insertmacro MUI_STARTMENU_GETFOLDER Application $StartMenuGroup
    !insertmacro SELECT_UNSECTION Main ${UNSEC0000}
FunctionEnd

