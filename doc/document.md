Modul-318 Dokumentation
============
## Einleitung
Diese Dokumentation dient zur Übersicht über die Projektarbeit die wir für das Modul 318 hatten. In dem Projekt mussten wir einen SBB Fahrplan erstellen.
Die Daten werden über eine API von "http://transport.opendata.ch/".

---
## Zweck des Dokumentes

Das Dokument dient zur Übersicht über das Projekt.
Alle Phasen der Projektarbeit werden detailliert beschrieben und folgen einem sinnvollen Ablauf.

--- 

## Inhaltsverzeichnis
1. Funktionsumfang(Link einfügen)
2. Bugs / nicht vollstänfige FUnktionen
3. Use Case und Aktivitätsdiagramme für alle umgesetzten Anforderungen(ALLE)
4. Tests. WElche man ohne erklärung durchführen kann
5. Installationsanleitung
6. Andere Spannende INformationen die für die Bewertung in Frage kommen.


#### There are 3 admin levels:
- **Helper:** Can delete chat messages
- **Moderator:** The above plus the ability to kick and ban users
- **Administrator:** All the above plus send global alerts and promote/demote users

---

## Setup
Clone this repo to your desktop and run `npm install` to install all the dependencies.

You might want to look into `config.json` to make change the port you want to use and set up a SSL certificate.

---

## Usage
After you clone this repo to your desktop, go to its root directory and run `npm install` to install its dependencies.

Once the dependencies are installed, you can run  `npm start` to start the application. You will then be able to access it at localhost:3000

To give yourself administrator permissions on the chat, you will have to type `/role [your-name]` in the app console.

---

## License
>You can check out the full license [here](https://github.com/IgorAntun/node-chat/blob/master/LICENSE)

This project is licensed under the terms of the **MIT** license.
