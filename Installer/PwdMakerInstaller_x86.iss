; -- PwdMakerInstaller.iss --
[Setup]
AppName=PwdMaker
AppId=Growup_Consultant/Software/PwdMaker
AppPublisher=Growup Consultant
AppCopyright=Growup Consultant
AppVerName=PwdMaker 1.0.0.0
AppVersion=1.0.0.0
ArchitecturesAllowed=x86 x64
DefaultDirName={pf}\PwdMaker
DefaultGroupName=PwdMaker
UninstallDisplayIcon={app}\PwdMaker.exe
ShowLanguageDialog=no
VersionInfoVersion=1.0.0.0
VersionInfoDescription=PwdMaker�Z�b�g�A�b�v�v���O����

OutputBaseFilename=PwdMakerInstaller_x86
OutputDir="."
SetupIconFile="..\PwdMaker\PwdMaker.ico"

[Tasks]
Name: desktopicon; Description: "�f�X�N�g�b�v�ɃV���[�g�J�b�g�A�C�R�����쐬����";

[Files]
Source: "..\PwdMaker\bin\Release\PwdMaker.exe";          DestDir: "{app}"; Flags: ignoreversion
Source: "..\PwdMaker\bin\Release\PwdMaker.config";       DestDir: "{app}"; Flags: ignoreversion
Source: "..\PwdMaker\bin\Release\NexFx.dll";             DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\PwdMaker"; Filename: "{app}\PwdMaker.exe"
Name: "{commondesktop}\PwdMaker"; Filename: "{app}\PwdMaker.exe"; WorkingDir: "{app}"; Tasks: desktopicon

[Languages]
Name: japanese; MessagesFile: compiler:Languages\Japanese.isl

[Run]
Filename: "{app}\PwdMaker.exe"; Description: "�A�v���P�[�V�������N������"; Flags: postinstall shellexec skipifsilent
