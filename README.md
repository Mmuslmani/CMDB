# CMDB
Einen Windows Programm, das dazu dient, dass ein Unternehmen seine (IT-) Devices dokumentiert und deren Stammdaten (ggf. auch Konfiguration) elektronisch erfasst. Das Programm soll in der OOP-Sprache C# geschrieben werden.

# Grundlagen
*Was ist eine **CMDB**? Was verbirgt sich dahinter? Erklärung des Begriffs und der Nutzung.*

*Configuration Management Database* (EN)

Eine **Konfigurationsdatenbank** ist eine Datenbank, die alle relevanten Informationen über die Komponenten sowie deren Wechselbeziehungen untereinander eines Informationssystems enthält
, das die IT-Services eines Unternehmens nutzen.
Eine **CMDB** stellt eine organisierte Ansicht und die Möglichkeit zur Inspektion dieser Daten zur Verfügung.
In diesem Zusammenhang bezeichnet man die Komponenten eines Informationssystems als **CI (Configuration Item)**.
Ein **CI** kann jede vorstellbare IT-Komponente sein, beispielsweise **Software**, **Hardware** oder **Dokumentationen** aber auch **Personal**.
# Aufgabe
*Genauere Defintion, was mit dem Programm erreicht werden soll. Dabei bitte konkrete Anwendungsfälle definieren. Gern auch als Erzählung aus dem Unternehmensalltag.*


Vor allem ist die Aufgabe dieses Projekt, dass sowohl die Verarbeitung der Daten als auch das Speichern und Dokumentieren von Daten, allerdings sind diese immer erreichbar und zugriffsfähig.
Außerdem ist zu Beachten, dass diese Daten zueinander in Beziehung stehen können.

*Genauere Abgrenzung, welche Funktinonen wir von einer CMDB umsetzen wollen*

- **Beispiel** :
Es ist die Aufgabe einen Rechner zu erfassen, das der neue Mitarbeiter bekommen hat.
-Zur Erfassung ist : 
PC fujetsu mit OS windows 10 v. 1903 und 8GB Speichern und Grafikkarte GeForce GTX 1060.
*Warum soll es erfasst werden*

*Definition, welche Daten für das Device erfasst werden sollen (Liste)*

Für das Device muss erfasst werden

| Name | Model |Serial number |Zugehörigkeit|Beschreibung|
| ------ | ------ | ------ | ------ | ------|
| Pc-1 | fujetsu |   s:123645678  |MMu |Hier wird alles über den PC beschriben|

Es ist ein Progamm zu entwicklen, das die Erfassung von Daten für spätere Zugriff dient.
Programm öffnen und Stamdaten eingeben , speichern .
# Plannung / "Soll Analyse"
- Zur Umsetzung soll ein Programm entwickelt werden, das das Dokumentiren und Erfassen von Elemente seine haupt Aufgabe wird.
- Außerdem sind die Zugriffe auf diese Daten personanhängig, also jeder Benutzer hat einen Profile und kann auf die Daten zugreifen.
- Sei es einen PC oder einen Drucker, will ich deren Stammdaten speichern.


# Umsetzungideen/Gedanken
*Definition, welche Daten für das Device erfasst werden sollen (Liste) - mit den entsprechenden Datentypen (vor allem, ob es weitere Objekte oder komplexe Datentypen sind)*
1. Die Daten müssen irgendwo gespeichert, meine Idee wäre diese in reltionalen Tabellen zu speichern und die Struktur und die Beziehungen dort aufbauen.
2. Die Tabellen werden mihilfe das Datenbankprogramm Access
