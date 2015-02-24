; QuietFile.Installer.nsi
; It will install QuietFile.Installer.nsi into a directory that the user selects,

;--------------------------------

; The name of the installer
Name "Quiet File Installer"

; The file to write
OutFile "QuietFile.Installer.exe"

; The default installation directory
InstallDir "$PROGRAMFILES\Quiet File"

; Registry key to check for directory (so if you install again, it will 
; overwrite the old one automatically)
InstallDirRegKey HKLM "Software\QUIETFILE" "Install_Dir"

; Request application privileges for Windows Vista
RequestExecutionLevel admin

;--------------------------------

; Pages

Page components
Page directory
Page instfiles

UninstPage uninstConfirm
UninstPage instfiles

;--------------------------------

; The stuff to install
Section "Quiet File (required)"

  SectionIn RO
  
  ; Set output path to the installation directory.
  SetOutPath $INSTDIR
  
  ; Put file there
  File "QuietFile.Installer.nsi"
  File "bin/QuietFile.exe"
  
  ; Write the installation path into the registry
  WriteRegStr HKLM SOFTWARE\QUIETFILE "Install_Dir" "$INSTDIR"
  
  ; Write the uninstall keys for Windows
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\QUIETFILE" "DisplayName" "Quiet File"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\QUIETFILE" "UninstallString" '"$INSTDIR\uninstall.exe"'
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\QUIETFILE" "NoModify" 1
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\QUIETFILE" "NoRepair" 1
  WriteUninstaller "uninstall.exe"
  
SectionEnd

; Optional section (can be disabled by the user)
Section "Start Menu Shortcuts"

  CreateDirectory "$SMPROGRAMS\Quiet File"
  CreateShortCut "$SMPROGRAMS\Quiet File\Uninstall.lnk" "$INSTDIR\uninstall.exe" "" "$INSTDIR\uninstall.exe" 0
  CreateShortCut "$SMPROGRAMS\Quiet File\Quiet File (MakeNSISW).lnk" "$INSTDIR\QuietFile.Installer.nsi" "" "$INSTDIR\QuietFile.Installer.nsi" 0
  
SectionEnd

;--------------------------------

; Uninstaller

Section "Uninstall"
  
  ; Remove registry keys
  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\QUIETFILE"
  DeleteRegKey HKLM SOFTWARE\QUIETFILE

  ; Remove files and uninstaller
  Delete $INSTDIR\QuietFile.Installer.nsi
  Delete $INSTDIR\uninstall.exe

  ; Remove shortcuts, if any
  Delete "$SMPROGRAMS\Quiet File\*.*"

  ; Remove directories used
  RMDir "$SMPROGRAMS\Quiet File"
  RMDir "$INSTDIR"

SectionEnd
