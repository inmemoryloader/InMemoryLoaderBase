
C:\Dev\sonar-scanner\SonarScanner.MSBuild.exe begin /k:"responsive-kaysta_InMemoryLoaderBase" /d:sonar.organization="responsive-kaysta" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.login="16913e3e0de88703b7ad5d736a6855ffb2bd05d2"

C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MsBuild.exe "C:\Dev\InMemoryLoaderBase\InMemoryLoaderBase.sln" /t:Rebuild

C:\Dev\sonar-scanner\SonarScanner.MSBuild.exe end /d:sonar.login="16913e3e0de88703b7ad5d736a6855ffb2bd05d2"