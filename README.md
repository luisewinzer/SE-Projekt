# Projekt Softwareentwicklung
## Der digitale Friedhof _Coffin Chronicles_ in C#

### Kurzbeschreibung
Es wird eine GUI in C# erstellt, die einen Friedhof simuliert und veschiedene Funktionen zur Interaktion (vgl. Funktionalitäten) bereitstellt. Die GUI wird für Friedhofsbesucher und Angehörige der Verstorbenen erstellt und geht den zentralen Fragen nach: Wie können wir als Gesellschaft den Tod (als unvermeidbares Ende eines jeden Lebens) besser in das "lebendige" Leben integrieren? Wie können wir Angehörige bei der Trauerbewältigung unterstützen und wie geraten die Verstorbenen nicht in Vergessenheit?

<img width="700" alt="Bildschirmfoto 2024-06-28 um 16 46 04" src="https://github.com/luisewinzer/SE-Projekt/assets/166633502/fba8f5f8-8d28-48ae-8a01-735003ecd60f">

Die Abbildung zeigt einen ersten Entwurf der GUI. Sie teilt sich in zwei Bereiche. Auf der rechten Seite ist ein Grundriss des Friedhofs abgebildet, der vier beschriftete Grabsteine zeigt. Der zweite Grabstein ist beispielhaft ausgewählt und entsprechend grün markiert. Durch die Auswahl des Grabsteins öffnet sich auf der linken Seite ein zugehöriges Fenster mit Informationen zu der verstorbenen Person. Hier können individuell Bilder, lustige Anekdoten und andere Informationen von den Angehörigen eingefügt werden.

### Funktionalitäten
- Benutzeranmeldung zum Schutz sensibler Daten
- Verwaltungstool für den Steckbrief der Verstorbenen
- Benachrichtigungen für Gedenktage
- Grabpflege: digitale Kerze anzünden, Blumen ablegen
- Suchfunktion nach verstorbenen Personen
- ggf. noch weitere Funktionen, wenn ausreichend Zeit vorhanden ist

### Beschreibung der Klassen
#### C User
In der Klasse `User` kann mit `CreateUser` ein eigener Account angelegt werden, der aus `Username` und `Password` besteht. Mit Hilfe `CheckCredentials` wird die Eingabe der Daten beim `Login` auf ihre Richtigkeit überprüft. Außerdem gibt es eine zugehörige `Logout` Funktion.

#### C ManagementTools
Die Elternklasse `ManagementTools` beinhaltet die Klassen rund um die Verwaltung: `InformationManager`, `NotificationManager` und `SearchManager`.

#### C InformationManager
Mit Hilfe der Klasse `InformationManager` wird die Verwaltung der Steckbriefe der Personen bewerkstelligt. Mit `AddInformation` können Informationen eingefügt und mit `DeleteInformation` gelöscht werden. Fotos von den Verstorbenen können mit `AddPicture` eingefügt und mit `DeletePicture` entfernt werden.

#### C NotificationManager
Die Klasse `NotificationManager` ist für die Benachrichtigung von Gedenktagen verantwortlich. Die Funktion `SetReminderMemorialDay` kann für die Erinnerung an Geburtstage, Sterbetage oder andere wichtige Ereignisse verwendet werden.

#### C SearchManager
Mit der Klasse `SearchManager` behält man auch bei vielen digitalen Grabsteinen den Überblick. Mit `SearchForDeceased` kann nach einer bestimmten verstorbenen Person gesucht werden.

#### C Graveyard
Die Elternklasse `Graveyard` beinhaltet die Klassen rund um die Pflege des Grabsteins: `Gravestone`, `GraveCare`, `DigitalFlowers` und `Digital Candle`.

#### C GraveStone
Die Klasse `GraveStone` ist für Verwaltung der Grabsteine verantwortlich und zeigt den Namen `name`, den Geburtstag `birthdate`und den Sterbetag `deathdate` an. Es kann ein Grabstein mit `CreateGraveStone` erstellt werden und mit `DeleteGraveStone` entfernt werden.

#### C GraveCare
Die Klasse `GraveCare` beinhaltet die beiden Klassen `DigitalCandle` und `DigitalFlowers` und kann ggf. durch weitere Funktionen ergänzt werden.

#### C DigitalCandle
Mit Hilfe der Klasse `DigitalCandle` kann zum Gedenken an die verstorbene Person eine Kerze mit `LightCandle` angezündet werden. Diese kann auch wieder mit `RemoveCandle` entfernt werden.

#### C DigitalFlowers
Mit Hilfe der Klasse `DigitalFlowers` können zum Gedenken an die verstorbene Person Blumen mit `AddFlowers` hinzugefügt werden. Diese können auch mit `RemoveFlowers`entfernt werden.

### Klassendiagramm
Zur besseren Veranschaung wurde das Klassendiagramm zweigeteilt.
#### ManagementTools

#### Graveyard
<img width="893" alt="Bildschirmfoto 2024-06-28 um 20 40 56" src="https://github.com/luisewinzer/SE-Projekt/assets/166633502/aad49fc9-edaf-412d-80f2-5c435f1472ea">



