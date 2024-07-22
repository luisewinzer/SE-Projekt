# Projekt Softwareentwicklung
## Digital Cemetery _Coffin Chronicles_

### Kurzbeschreibung
Es wird eine GUI in C# erstellt, die einen Friedhof simuliert und veschiedene Funktionen zur Interaktion (vgl. Funktionalitäten) bereitstellt. Die GUI wird für Friedhofsbesucher und Angehörige der Verstorbenen erstellt und geht den zentralen Fragen nach: Wie können wir als Gesellschaft den Tod (als unvermeidbares Ende eines jeden Lebens) besser in das "lebendige" Leben integrieren? Wie können wir Angehörige bei der Trauerbewältigung unterstützen und wie geraten die Verstorbenen nicht in Vergessenheit?

<img width="700" alt="Bildschirmfoto 2024-06-28 um 16 46 04" src="https://github.com/luisewinzer/SE-Projekt/assets/166633502/fba8f5f8-8d28-48ae-8a01-735003ecd60f">

Die Abbildung zeigt einen ersten Entwurf der GUI. Sie teilt sich in zwei Bereiche. Auf der rechten Seite ist ein Grundriss des Friedhofs abgebildet, der vier beschriftete Grabsteine zeigt. Der zweite Grabstein ist beispielhaft ausgewählt und entsprechend grün markiert. Durch die Auswahl des Grabsteins öffnet sich auf der linken Seite ein zugehöriges Fenster mit Informationen zu der verstorbenen Person. Hier können individuell Bilder, lustige Anekdoten und andere Informationen von den Angehörigen eingefügt werden.

---

### Funktionalitäten
- Benutzeranmeldung zum Schutz sensibler Daten
- Verwaltungstool für den Steckbrief der Verstorbenen

---

### Beschreibung der Klassen
#### C User
In der Klasse `User` kann mit `CreateUser` ein eigener Account angelegt werden, der aus `username` und `password` besteht. Mit Hilfe `CheckCredentials` wird die Eingabe der Daten beim `Login` auf ihre Richtigkeit überprüft. Außerdem gibt es eine zugehörige `Logout` Funktion.

#### C DeceasedPerson
Mit Hilfe der Klasse `DeceasedPerson` werden die Daten (`name`, `birthdate`, `deathdate`, `furtherInformation` und `picture`) über die verstorbene Person erfasst. Mit `AddInformation` können Informationen eingefügt und mit `DeleteInformation` gelöscht werden.

#### C GraveStone
Die Klasse `GraveStone` ist für Verwaltung der Grabsteine verantwortlich und zeigt den Namen `name`, den Geburtstag `birthdate` und den Sterbetag `deathdate` an. Es kann ein Grabstein mit `CreateGraveStone` erstellt werden und mit `DeleteGraveStone` entfernt werden.

---

### Klassendiagramm
<img width="1401" alt="Bildschirmfoto 2024-06-29 um 10 37 21" src="https://github.com/luisewinzer/SE-Projekt/assets/166633502/f2f7cc8d-e33e-40f3-8212-511f6ad38b45">

---

### Erweiterungsmöglichkeiten
- Benachrichtigungen für Gedenktage
- Suchfunktion nach verstorbenen Personen
- Verknüpfung mit anderen verstorbenen Personen
- Grabpflege: digitale Kerze anzünden, Blumen ablegen
