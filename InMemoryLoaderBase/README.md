# InMemoryLoader 

## Beschreibung
InMemoryLoader ist eine in C# (Mono) geschriebene Funktions- oder Klassen-Bibliothek die das dynamische Laden von .NET 
Assemblies zur Laufzeit ermöglicht ohne eine Referenz in der Project-Solution vorauszusetzen. 

Im Wesentlichen besteht sie aus zwei nuget-Packages die mit Mono entwickelt wurden und so über Plattformgrenzen hinweg 
verwendet werden können. 

[Link](https://responsive-kaysta.ch/blog/inmemoryloader/) Projektseite/Blog

Hierbei werden die .Dll’s einmalig geladen und geprüft, in eine Collection geschrieben und zur Laufzeit einmalig 
instanziiert und im Memory gespeichert.

So werden sehr effiziente Applikationen ohne fixe Referenzen möglich, das Projekt kann so viel schlanker und effizienter 
gehalten werden. Zudem kann zur Laufzeit sehr einfach Funktionalität hinzugefügt werden und so die Startup-Time von 
Anwendungen massiv verkürzen.

Ein weitere Vorteil besteht darin, dass so verschiedene Funktionscontainer erstellt werden können. 
Bsp.: je nach User-Context können so verschiedene Funktionen angeboten werden. Dies erhöht nicht nur die Performance, 
die Funktionen stehen so auch nur dem jeweiligen Context zur Verfügung was die Sicherheit ebenfalls positiv beeinflusst.

## Release 0.3.2
Dieser Release kann schon fast als Major-Release bezeichnet werden, ich habe diverse Dinge verbessert, erweitert und hinzugefügt. 
Dabei muss ich jedoch erwähnen, das InMemoryLoaderCommon (noch) nicht ganz soweit ist. Die Komponente wurde jedoch so erweitert 
dass die Verbesserungen von InMemoryLoaderBase als auch InMemoryLoader eingeflossen sind.

[Link](https://responsive-kaysta.ch/blog/inmemoryloader-base-common-release-032/) Release notes


# ----------------------------------------------------------------------------------------------

chmod -R 777 /home/kaysta/Dev/
chmod -R 777 /home/kaysta/sonar-scanner/



# ----------------------------------------------------------------------------------------------
Analyze "InMemoryLoader" / 6d40f754145dd0f45fc5c1b5cd1636b40032db3e
# ----------------------------------------------------------------------------------------------

mono /home/kaysta/sonar-scanner/SonarScanner.MSBuild.exe begin /k:"responsive-kaysta_InMemoryLoader" /d:sonar.organization="responsive-kaysta" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.login="6d40f754145dd0f45fc5c1b5cd1636b40032db3e"

sh /usr/bin/msbuild /home/kaysta/Dev/InMemoryLoader/InMemoryLoader.sln /t:Rebuild

mono /home/kaysta/sonar-scanner/SonarScanner.MSBuild.exe end /d:sonar.login="6d40f754145dd0f45fc5c1b5cd1636b40032db3e"