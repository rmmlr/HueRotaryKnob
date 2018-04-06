# Raumklima - Büro MSS3.4

Einfache Webapp zur Visualisierung aktueller und historischer Raumklima-Daten.

## Benutzung

Es stehen zwei Ansichten zur Verfügung, welche beide im Browser aufgerufen werden können. Die Datenaktualisierung erfolgt automatisch im Hintergrund.

### Aktuelle Messwerte

Dargestellt werden die aktuell erfassten Messwerte.

Erreichbar über die URL: [index.http://eh176201/index.html](http://eh176201/index.html)

#### Anzeige
Dargestellt werden folgende Messwerte. 

* Temperatur in °C
* Luftdruck in mBar
* Relative Luftfeuchte in %
* Absolute Luftfeuchte in g/m³
* Taupunkt in °C
* Zeitstempel der Messwerte
* Prüfmittelbezeichung des Messwertaufnehmers

#### Parametrierung
Für diese Anzeige ist keine weitere Parametrierung verfügbar

### Verlauf (aktuell und historisch)

In Abhängigkeit der Parametrierung werden tagesaktuelle oder historische Messdaten in einem Diagramm dargestellt.

Erreichbar über die URL: [http://eh176201/chart.php](http://eh176201/chart.php)  
Der Aufruf ohne weitere Parameter gibt den Tagesverlauf des aktuellen Tag aus, beginnend bei Stunde 0.

#### Anzeige
Im Diagramm werden folgende Messwerte dargestellt. 

* Temperatur in °C
* Relative Luftfeuchte in %
* Zeitstempel der letzten Messwerte
* Datum der historischen Messwerte
* Prüfmittelbezeichung des Messwertaufnehmers

#### Parametrierung
Folgende Get-Parameter können der URL angehangen werden:

| Parameter | Wert/Format | Beschreibung                                 | Hinweis                                      |
|:--------- |:----------- |:-------------------------------------------- |:-------------------------------------------- |
| day       | yyyy-mm-dd  | Aufruf des Tagesverlaufs zum angegebenen Tag | nicht Kombinierbar mit Parameter *startHour* |
| startHour | 0 ... 23    | Messwertanzeige ab angegebener Stunde        | nicht Kombinierbar mit Parameter *day*       |
| yMaxHum   | 0 ... 100   | Max.-Wert der Y-Achse für Feuchtigkeit       |                                              |
| yMaxTemp  | -20 ... 80  | Max.-Wert der Y-Achse für Temperatur         |                                              |
| yMinHum   | 0 ... 100   | Min.-Wert der Y-Achse für Feuchtigkeit       |                                              |
| yMinTemp  | -20 ... 80  | Min.-Wert der Y-Achse für Temperatur         |                                              |

##### Beispielaufruf

* [http://eh176201/chart.php?day=2018-04-04&](http://eh176201/chart.php?day=2018-04-04)
* [http://eh176201/chart.php?day=2018-04-04&yMinTemp=0&yMaxTemp=50&yMinHum=0&yMaxHum=100](http://eh176201/chart.php?day=2018-04-04&yMinTemp=0&yMaxTemp=50&yMinHum=0&yMaxHum=100)
* [http://eh176201/chart.php?startHour=6](http://eh176201/chart.php?startHour=6)

