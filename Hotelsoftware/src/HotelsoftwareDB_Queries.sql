USE hotelsoftwaredb;

# Abfragen für Firmenkartei
SELECT f_id, f_bezeichnung, f_strasse, f_hausnummer, f_postleitzahl, f_stadt, f_land FROM firma ORDER BY f_bezeichnung;


# Abfragen für Gästekartei
SELECT g_id, g_vorname, g_nachname, g_geburtsdatum, g_strasse, g_hausnummer,g_postleitzahl, g_stadt, g_land, f_id FROM gast ORDER BY g_nachname;

SELECT g_id, g_vorname, g_nachname, g_geburtsdatum, g_strasse, g_hausnummer,g_postleitzahl, g_stadt, g_land, f.f_id, f_bezeichnung FROM gast
LEFT OUTER JOIN firma f on f.f_id = gast.f_id
ORDER BY g_nachname;

UPDATE gast SET f_id = null WHERE g_id = 52;


# Abfragen für Zimmerplan
SELECT z_id, z_kategorie, z_status FROM zimmer;
SELECT z_id, z_kategorie, z_status FROM zimmer WHERE z_status = 'sauber';
UPDATE zimmer SET z_status = 'dreckig' WHERE z_id = 100;


# Abfragen für Reservierung
SELECT r_id, checkIn, checkOut, g_id, z_id FROM reservierung;


# Abfragen für Leistung
SELECT l_id, l_bezeichnung, l_preis FROM leistung;


# Abfragen für Rechnung
SELECT re_id, l_id, r_id FROM rechnungskonto;


# Abfragen für Abteilung
SELECT a_id, a_bezeichnung FROM abteilung;


# Abfragen für Mitarbeiter
SELECT m_id, m_vorname, m_nachname, m_position, a_id FROM mitarbeiter;