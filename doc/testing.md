# Testing

### Testfälle

| Testfall | Beschreibung                           | Erwartetes Resultat                                                     | tatsächliches Resultat    | Status (Passed/Failed) |
|----------|----------------------------------------|-------------------------------------------------------------------------|---------------------------|------------------------|
| 1        | SBBTimetable.exe öffnen                | Applikation öffnet sich ohne Fehlermeldung                              | Applikation offen         | Passed                 |
| 2        | Verbindung suchen ohne Startstation    | Keine Fehlermeldung. Kein Absturz. Macht nichts ohne Startstation       | Keine bemerkbare änderung | Passed                 |
| 3        | Fenstergrösse ändern                   | nicht möglich                                                           | nicht machbar             | Passed                 |
| 4        | Beim öffnen Cursor im Startstationfeld | Beim öffnen der Applikation soll der Cursor im Startstations Feld sein. | wie erwartet              | Passed                 |

### Unit Test

Unit Test sind nur für die Public Funktion "getStationBoard" vorhanden.
