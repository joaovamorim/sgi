; Script gerado pelo Inno Setup Script Wizard.
; VEJA A DOCUMENTAÇÃO PARA DETALHES SOBRE A CRIAÇÃO DE ARQUIVOS DE SCRIPT DO INNO SETUP!

#define MyAppName "SGI"
#define MyAppVersion "1.6.3.0"
#define MyAppPublisher "Amorim Company, Inc."
#define MyAppExeName "AutoUpdate.exe"
#define SGIExeName "SGI.exe"
#define MyAppAssocName MyAppName + ""
#define MyAppAssocExt ".myp"
#define MyAppAssocKey StringChange(MyAppAssocName, " ", "") + MyAppAssocExt

[Setup]
AppId={{52962348-7C0E-4C36-AA87-36E2E7D05FD6}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\{#MyAppName}
UninstallDisplayIcon={app}\{#MyAppExeName}
ArchitecturesAllowed=x64compatible
ArchitecturesInstallIn64BitMode=x64compatible
ChangesAssociations=yes
DisableProgramGroupPage=yes
PrivilegesRequired=admin
OutputDir=D:\git\SGI\sgi\main\ISS
OutputBaseFilename=Setup_SGI
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "D:\git\SGI\sgi\main\src\bin\Release\net8.0-windows\publish\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\git\SGI\sgi\main\src\bin\Release\net8.0-windows\publish\{#SGIExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\git\SGI\sgi\main\src\bin\Release\net8.0-windows\publish\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Registry]
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocExt}\OpenWithProgids"; ValueType: string; ValueName: "{#MyAppAssocKey}"; ValueData: ""; Flags: uninsdeletevalue
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}"; ValueType: string; ValueName: ""; ValueData: "{#MyAppAssocName}"; Flags: uninsdeletekey
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\{#MyAppExeName},0"
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "cmd.exe"; Parameters: "/C if not exist ""C:\Program Files\SGI"" mkdir ""C:\Program Files\SGI"""; StatusMsg: "Criando a pasta SGI..."; Flags: runhidden waituntilterminated
Filename: "cmd.exe"; Parameters: "/C icacls ""C:\Program Files\SGI"" /grant ""Usuários"":(OI)(CI)F /t"; StatusMsg: "Concedendo permissões completas na pasta SGI..."; Flags: runhidden waituntilterminated
Filename: "cmd.exe"; Parameters: "/C icacls ""{app}\{#MyAppExeName}"" /grant ""Usuários"":(RX) /t"; StatusMsg: "Concedendo permissões para o AutoUpdate.exe..."; Flags: runhidden waituntilterminated
Filename: "cmd.exe"; Parameters: "/C icacls ""{app}\{#SGIExeName}"" /grant ""Usuários"":(RX) /t"; StatusMsg: "Concedendo permissões para o SGI.exe..."; Flags: runhidden waituntilterminated
; English Users
Filename: "cmd.exe"; Parameters: "/C icacls ""C:\Program Files\SGI"" /grant ""Users"":(OI)(CI)F /t"; StatusMsg: "Concedendo permissões completas na pasta SGI..."; Flags: runhidden waituntilterminated
Filename: "cmd.exe"; Parameters: "/C icacls ""{app}\{#MyAppExeName}"" /grant ""Users"":(RX) /t"; StatusMsg: "Concedendo permissões para o AutoUpdate.exe..."; Flags: runhidden waituntilterminated
Filename: "cmd.exe"; Parameters: "/C icacls ""{app}\{#SGIExeName}"" /grant ""Users"":(RX) /t"; StatusMsg: "Concedendo permissões para o SGI.exe..."; Flags: runhidden waituntilterminated
