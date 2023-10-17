# TUIMPK
### TCP / UDP / ICMP Multi Port Knocker
Port kopogató alkalmazás Windows rendszerekre.

#### Verzió: 1.0.6.0
### Tartalomjegyzék

- [Az alkalmazásról](#az-alkalmaz%C3%A1sr%C3%B3l)
- [Futtatáshoz szükséges környzet + futtatható állomány](#futtat%C3%A1shoz-sz%C3%BCks%C3%A9ges)
- [A projekt készült](#a-projekt-k%C3%A9sz%C3%BClt)
- [Tesztelve](#tesztelve)
- [Képek](#k%C3%A9pek)


### Az alkalmazásról:

* TCP port kopogtatás
* ICMP port kopogtatás
* UDP port kopogtatás + "jelszó" küldés
* Egy időben 4 darab protokoll / port állítható be
* Kopogtatás egyesével vagy csoportosan (egy időben max. 4 db)
* Korlátlan számú konfigurációs fájl mentése (titkosíítva)
* Saját jelszó a konfigurációs fájlok védelméhez
* Jelszó mentési lehetőség
* 0.5 - 5 másodperc közötti késleltetés a kopogtatások között
* Minden űrlapmező kicsillagozva az adatvédelem érdekében (dupla klikkel megjeleníthetők)
* 8 db választható háttér
* Commodore Amiga háttérzene ;-)


### Futtatáshoz szükséges:

* Microsoft .NET Framework 4.5 vagy újabb
* A futattható (compiled) állomány a bin/release mappában található ([TUIMPK.exe](https://github.com/Alpha-Buchotep/TUIMPK/tree/main/TUIMPK/bin/Release)).

### A projekt készült:

* VB.NET .NET 4.5
* Visual Studio 2019 Enterprise IDE (v16.0.29102.190)
* A projekt megnyitásához minimum Visual Studio v10.0.40219.1 szükséges


### Tesztelve:

#### Eszközök:

* Mikrotik CCR2004 router
* Mikrotik RB4011 router
* Mikrotik hAP ac3 router
* Mikrotik CRS326 switch
* Linux IPTables

#### Router OS

* 6.48.6
* 6.49.7
* 7.6

#### Windows

* Windows 7 Professional
* Windows 8.1
* Windows 10 Professional
* Windows 11 Professional for Workstation

### Képek

![TUIMPK-01](https://github.com/Alpha-Buchotep/TUIMPK/assets/63890454/b12ac1aa-0938-4f8d-a7a6-1885afb84e72)

![TUIMPK-04](https://github.com/Alpha-Buchotep/TUIMPK/assets/63890454/d23cd77b-0629-4c27-93b3-7484f6fe487b)

![TUIMPK-03](https://github.com/Alpha-Buchotep/TUIMPK/assets/63890454/e5561dad-a7fa-4f2a-8ec8-ee1f441f6335)
