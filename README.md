# Projekt Softwareentwicklung
## Digital Cemetery _Coffin Chronicles_

### Kurzbeschreibung
Es wird eine GUI in C# erstellt, die einen Friedhof simuliert und veschiedene Funktionen zur Interaktion (vgl. Funktionalitäten) bereitstellt. Die GUI wird für Friedhofsbesucher und Angehörige der Verstorbenen erstellt und geht den zentralen Fragen nach: Wie können wir als Gesellschaft den Tod (als unvermeidbares Ende eines jeden Lebens) besser in das "lebendige" Leben integrieren? Wie können wir Angehörige bei der Trauerbewältigung unterstützen und wie geraten die Verstorbenen nicht in Vergessenheit?

<img width="700" alt="Bildschirmfoto 2024-06-28 um 16 46 04" src="https://github.com/luisewinzer/SE-Projekt/assets/166633502/fba8f5f8-8d28-48ae-8a01-735003ecd60f">

Die Abbildung zeigt einen ersten Entwurf der GUI. Sie teilt sich in zwei Bereiche. Auf der rechten Seite ist ein Grundriss des Friedhofs abgebildet, der vier beschriftete Grabsteine zeigt. Der zweite Grabstein ist beispielhaft ausgewählt und entsprechend grün markiert. Durch die Auswahl des Grabsteins öffnet sich auf der linken Seite ein zugehöriges Fenster mit Informationen zu der verstorbenen Person. Hier können individuell Bilder, lustige Anekdoten und andere Informationen von den Angehörigen eingefügt werden.

---

### Funktionalitäten
**Login-Registration-Screen**
- Ermöglicht Benutzern, sich anzumelden oder ein neues Konto zu erstellen.
- Schützt sensible Daten durch Authentifizierung.
- Stellt sicher, dass nur autorisierte Benutzer Zugang zu den Daten haben.

**Willkommensseite**
- Zeigt eine personalisierte Begrüßung basierend auf dem Benutzernamen.
- Bietet einfachen Zugang zu allen Hauptfunktionen der Anwendung.
- Ermöglicht eine nahtlose Navigation zu den Seiten "Dateneingabe-Tool" und "Friedhofs-Grundriss".

**Dateneingabe-Tool**
- Dateneingabe-Tool zum Speichern der Daten der Verstorbenen.
- Benutzer können Namen, Geburtsdatum, Sterbedatum und zusätzliche Informationen des Verstorbenen eingeben.
- Die Daten werden in einer Datenbank gespeichert und für einen Grabstein im Friedhofs-Grundriss aufbereitet.

**Friedhofs-Grundriss**
- Visuelle Darstellung der gespeicherten Daten in Form von Grabsteinen.
- Benutzer können auf einen Grabstein klicken, um die Details des Verstorbenen anzuzeigen.
- Einfache Navigation und Bedienung durch eine benutzerfreundliche Oberfläche.
  
---

### Anleitung

...

---

### Klassendiagramm

![image](https://github.com/user-attachments/assets/b9accd86-25e0-4e69-bdd8-c2a75d5339d6)

---

### Erweiterungsmöglichkeiten
- Möglichkeit eigene Daten zu bearbeiten oder zu löschen
- Benachrichtigungen für Gedenktage
- Suchfunktion nach verstorbenen Personen
- Verknüpfung mit anderen verstorbenen Personen
- Grabpflege: digitale Kerze anzünden, Blumen ablegen
