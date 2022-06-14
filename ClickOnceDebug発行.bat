call "C:\Program Files\Microsoft Visual Studio\2022\Professional\Common7\Tools\VsDevCmd.bat"
cd %~dp0
msbuild ClickOnceMultipleInstall.sln /t:Publish /t:CopyPublishedApplication /p:Configuration=Debug /p:PublishUrl="publish\Debug\\" /p:InstallUrl="\\Win10Test\publish_Debug\\" /p:ManifestKeyFile="ClickOnceMultipleInstallDebug.pfx" /p:ManifestCertificateThumbprint="Debug" /p:ProductName="CliclOnce テスト Debug システム" /p:PublisherName="Sorceryforce"
