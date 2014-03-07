@if "%WindowsSDK_ExecutablePath_x64%"=="" goto error_no_WindowsSDK_ExecutablePath_x64

"%WindowsSDK_ExecutablePath_x64%\xsd" /p:param.camt.052.001.02.xml
"%WindowsSDK_ExecutablePath_x64%\xsd" /p:param.camt.052.001.03.xml
"%WindowsSDK_ExecutablePath_x64%\xsd" /p:param.camt.053.001.02.xml
"%WindowsSDK_ExecutablePath_x64%\xsd" /p:param.camt.054.001.02.xml
"%WindowsSDK_ExecutablePath_x64%\xsd" /p:param.pain.001.003.03.xml 
"%WindowsSDK_ExecutablePath_x64%\xsd" /p:param.pain.002.003.03.xml
"%WindowsSDK_ExecutablePath_x64%\xsd" /p:param.pain.008.003.02.xml

@goto end

:error_no_WindowsSDK_ExecutablePath_x64
@echo ERROR: You must run this command in a Developer Command Prompt for Visual Studio

:end
