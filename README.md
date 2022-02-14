# SharpComHijack

## What it do
* Dumps com objects that can be hijacked for persistence.

## Example
```
C:\SharpComHijack.exe

Name                                                  Guid                                    Path                                                 RegistryKey
----                                                  ----                                    ----                                                 -----------
AD RMS Rights Policy Template Management (Automated)  {CF2CF428-325B-48D3-8CA8-7633E36E5A32}  C:\Windows\system32\msdrm.dll                        SOFTWARE\Classes\CLSID\{CF2CF428-325B-48D3-8CA8-7633E36E5A32}\InProcServer32
AD RMS Rights Policy Template Management (Manual)     {BF5CB148-7C77-4D8A-A53E-D81C70CF743C}  C:\Windows\system32\msdrm.dll                        SOFTWARE\Classes\CLSID\{BF5CB148-7C77-4D8A-A53E-D81C70CF743C}\InProcServer32
UserTask                                              {58FB76B9-AC85-4E55-AC04-427593B1D060}  C:\Windows\system32\dimsjob.dll                      SOFTWARE\Classes\CLSID\{58FB76B9-AC85-4E55-AC04-427593B1D060}\InProcServer32
Synchronize Language Settings                         {10D62541-90D0-42FE-848C-0DBC1AC42EDA}  C:\Windows\System32\CoreGlobConfig.dll               SOFTWARE\Classes\CLSID\{10D62541-90D0-42FE-848C-0DBC1AC42EDA}\InProcServer32
Installation                                          {6F58F65F-EC0E-4ACA-99FE-FC5A1A25E4BE}  C:\Windows\System32\LanguageComponentsInstaller.dll  SOFTWARE\Classes\CLSID\{6F58F65F-EC0E-4ACA-99FE-FC5A1A25E4BE}\InProcServer32
SystemSoundsService                                   {2DEA658F-54C1-4227-AF9B-260AB5FC3543}  C:\Windows\System32\PlaySndSrv.dll                   SOFTWARE\Classes\CLSID\{2DEA658F-54C1-4227-AF9B-260AB5FC3543}\InProcServer32
Logon Synchronization                                 {FA3F3DD9-4C1A-456B-A8FA-C76EF3ED83B8}  C:\Windows\System32\cscui.dll                        SOFTWARE\Classes\CLSID\{FA3F3DD9-4C1A-456B-A8FA-C76EF3ED83B8}\InProcServer32
Device Install Reboot Required                        {48794782-6A1F-47B9-BD52-1D5F95D49C1B}  C:\Windows\System32\pnpui.dll                        SOFTWARE\Classes\CLSID\{48794782-6A1F-47B9-BD52-1D5F95D49C1B}\InProcServer32
SvcRestartTaskLogon                                   {B1AEBB5D-EAD9-4476-B375-9C3ED9F32AFC}  C:\Windows\System32\sppcext.dll                      SOFTWARE\Classes\CLSID\{B1AEBB5D-EAD9-4476-B375-9C3ED9F32AFC}\InProcServer32
MsCtfMonitor                                          {01575CFE-9A55-4003-A5E1-F38D1EBDCBE1}  C:\Windows\system32\MsCtfMonitor.dll                 SOFTWARE\Classes\CLSID\{01575CFE-9A55-4003-A5E1-F38D1EBDCBE1}\InProcServer32
Calibration Loader                                    {B210D694-C8DF-490D-9576-9E20CDBC20BD}  C:\Windows\System32\mscms.dll                        SOFTWARE\Classes\CLSID\{B210D694-C8DF-490D-9576-9E20CDBC20BD}\InProcServer32
CacheTask                                             {0358B920-0AC7-461F-98F4-58E32CD89148}  C:\Windows\system32\wininet.dll                      SOFTWARE\Classes\CLSID\{0358B920-0AC7-461F-98F4-58E32CD89148}\InProcServer32
Work Folders Logon Synchronization                    {97D47D56-3777-49FB-8E8F-90D7E30E1A1E}  C:\Windows\System32\WorkFoldersShell.dll             SOFTWARE\Classes\CLSID\{97D47D56-3777-49FB-8E8F-90D7E30E1A1E}\InProcServer32
Work Folders Maintenance Work                         {63260BCE-A3FB-4A34-AA51-D4D8E877B62B}  C:\Windows\System32\WorkFoldersShell.dll             SOFTWARE\Classes\CLSID\{63260BCE-A3FB-4A34-AA51-D4D8E877B62B}\InProcServer32
```

## Notes
* If any issues are encountered open PR
* Should work with donut and CS execute-assembly.
