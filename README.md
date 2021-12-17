***************************************************
KDS (Klienten Dokumentations System)              *  
***************************************************

Das KDS ist ein datenbankgestütztes Dokumentationssystem mit grafischer Benutzeroberfläche. 
Es soll als ein Tool dienen, welches umfangreiche Funktionen ausweist, um Einträge zu Klienten
sicher und effizient in einer MySQL-Datenbank anzulegen und anschließend bearbeiten und mit anderen 
Anwendern teilen zu können. 
Das KDS ist darauf ausgelegt unter Windows zu laufen, da es vollständig mit C# und dem .NET 
Framework erstellt wurde.

***************************************************
Aktueller Stand und zukünftige Implementierungen  *
***************************************************

Aktuell: 
Es lassen sich sowohl Nutzer-Konten und neue Klienten mit zugehörigen Einträgen erstellen und 
in einer Datenbank speichern. Zudem können Klienten und ihre Einträge wieder entfernt werden.
Nutzer Passwörter werden aktuell mittels eines SHA-512-Algorithmus gespeichert. 
Nach erfolgtem Login werden alle Klienten in das Hauptfenster geladen und ihre Einträge sind 
aufrufbar. Einträge durch andere Nutzer können nicht bearbeitet werden. 

In Zukunft soll folgendes umgesetzt werden: 
- Einträge sollen als JSON und eventuell andere Dateiformate exportiert werden können
- Zudem soll eine E-Mail-Funktion erstellt werden, durch welche Dateien direkt über das KDS versendet
  werden können
- Wenn Einträge bearbeitet werden, sollen diese auch andere Schriftarten, kursiv o.ä. und Farben anzeigen
  können. Einträge sollen auch entfernt werden können
- Der Eingeloggte Nutzer sollen sich abmelden und ein anderer anmelden können
- Wenn ein Klient registriert wird, sollen die MySQL-Commands mittels Transactions ausgeführt werden
- Die E-Mail-Prüfung soll mittels REGEX stattfinden
- Während der Passworteingabe soll das Passwort nicht mehr in Klartext angezeigt und durch * oder Punkte ersetzt werden
- Daten der Nutzer und Klienten sollen veränderbar sein
- Ansicht des Fensters soll veränderbar sein

***************************************************
Wie ist das Projekt zu installieren?              *
***************************************************

- Benötigt wird das .NET Framework 4.8 oder höher
- Zunächst mit kds_db.sql in einer MySQL-Datenbank das notwendige Schema erstellen
- Führen Sie KDS_1.sln in ihrer Visual Studio Anwendung aus 
- Installieren Sie in Visual Studio Oracles MySql.Data NuGet-Paket in ihr Projekt
- Anschließend können Sie den Code kompilieren und die Anwendung nutzen

Für das Projekt verwendete Technologien: 
- MySQL Workbench 8.0: version 8.0.25 build 788958 CE (64-bits) Community
- Microsoft Visual Studio Community 2019: Version 16.9.6
- Microsoft .NET Framework: Version 4.8.04084

***************************************************
Websites					                                *
***************************************************

KDS Projektseite:
https://github.com/SvenAdler/Klienten-Dokumentationssystem

Projektidee_Prototyp.drawio auf https://app.diagrams.net/ öffnen 

***************************************************
Autor					                                    *
***************************************************

Sven Adler <adler_sven@outlook.de>
https://github.com/SvenAdler
https://www.linkedin.com/in/sven-adler/
