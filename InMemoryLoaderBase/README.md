# InMemoryLoaderBase

## Beschreibung
Die Basis jeder InMemoryLoader Komponente

[Link](https://blog.responsive-kaysta.ch/post/inmemoryloader)


## Release 1.0




# ----------------------------------------------------------------------------------------------

chmod -R 777 /home/kaysta/Dev/
chmod -R 777 /home/kaysta/sonar-scanner/



# ----------------------------------------------------------------------------------------------
Analyze "InMemoryLoader" / 6d40f754145dd0f45fc5c1b5cd1636b40032db3e
# ----------------------------------------------------------------------------------------------

mono /home/kaysta/sonar-scanner/SonarScanner.MSBuild.exe begin /k:"responsive-kaysta_InMemoryLoader" /d:sonar.organization="responsive-kaysta" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.login="6d40f754145dd0f45fc5c1b5cd1636b40032db3e"

sh /usr/bin/msbuild /home/kaysta/Dev/InMemoryLoader/InMemoryLoader.sln /t:Rebuild

mono /home/kaysta/sonar-scanner/SonarScanner.MSBuild.exe end /d:sonar.login="6d40f754145dd0f45fc5c1b5cd1636b40032db3e"




# ----------------------------------------------------------------------------------------------
Analyze "InMemoryLoaderBase" / 44cc8f018e5d0013f591c5a4747aabcf651d7323
# ----------------------------------------------------------------------------------------------

mono /home/kaysta/sonar-scanner/SonarScanner.MSBuild.exe begin /k:"responsive-kaysta_InMemoryLoaderBase" /d:sonar.organization="responsive-kaysta" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.login="44cc8f018e5d0013f591c5a4747aabcf651d7323"

sh /usr/bin/msbuild /home/kaysta/Dev/InMemoryLoaderBase/InMemoryLoaderBase.sln /t:Rebuild

mono /home/kaysta/sonar-scanner/SonarScanner.MSBuild.exe end /d:sonar.login="44cc8f018e5d0013f591c5a4747aabcf651d7323"