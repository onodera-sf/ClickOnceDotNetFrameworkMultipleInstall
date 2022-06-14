call "C:\Program Files\Microsoft Visual Studio\2022\Professional\Common7\Tools\VsDevCmd.bat"
cd %~dp0
msbuild ClickOnceMultipleInstall.sln /t:Publish /t:CopyPublishedApplication /p:Configuration=Release /p:PublishUrl="publish\Release\\" /p:InstallUrl="\\Win10Test\publish_Release\\" /p:ManifestKeyFile="ClickOnceMultipleInstallRelease.pfx" /p:ManifestCertificateThumbprint="Release" /p:ProductName="CliclOnce テスト Release システム" /p:PublisherName="Sorceryforce"
