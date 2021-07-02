USE hotelsoftwaredb;

# Abfragen für Firmenkartei
SELECT f_id, f_bezeichnung, f_strasse, f_hausnummer, f_postleitzahl, f_stadt, f_land FROM firma ORDER BY f_bezeichnung;


# Abfragen für Gästekartei
SELECT g_id, g_vorname, g_nachname, g_geburtsdatum, g_strasse, g_hausnummer,g_postleitzahl, g_stadt, g_land, f_id FROM gast ORDER BY g_nachname;

SELECT g_id, g_vorname, g_nachname, g_geburtsdatum, g_strasse, g_hausnummer,g_postleitzahl, g_stadt, g_land, f.f_id, f.f_bezeichnung FROM gast
LEFT OUTER JOIN firma f on f.f_id = gast.f_id
ORDER BY g_nachname;

UPDATE gast SET f_id = null WHERE g_id = 54;


# Abfragen für Zimmerplan
SELECT z_id, z_kategorie, z_status FROM zimmer;
SELECT z_id, z_kategorie, z_status FROM zimmer WHERE z_status = 'sauber';
UPDATE zimmer SET z_status = 'dreckig' WHERE z_id = 100;


# Abfragen für Reservierung & Belegungsplan
SELECT r_id, checkIn, checkOut, g_id, z_id, r_status FROM reservierung;

SELECT r_id, z_id, g.g_id, g_nachname, g_vorname, checkIn, checkOut, r_status FROM reservierung
LEFT JOIN gast g on g.g_id = reservierung.g_id
WHERE r_status = 'Option'
AND checkIn = '2021-07-01'
ORDER BY z_id;

SELECT r.r_id, z.z_id, g.g_id, g.g_nachname, g.g_vorname, r.checkIn, r.checkOut, r.r_status, z.z_status
FROM reservierung r INNER JOIN gast g
ON r.g_id = g.g_id INNER JOIN zimmer z
ON r.z_id = z.z_id
ORDER BY z_id;


# Abfragen für Leistung
SELECT l_id, l_bezeichnung, l_preis FROM leistung;


# Abfragen für Rechnung
SELECT re_id, l_id, r_id FROM rechnungskonto;


# Abfragen für Abteilung
SELECT a_id, a_bezeichnung FROM abteilung;


# Abfragen für Mitarbeiter
SELECT m_id, m_vorname, m_nachname, m_position, a_id FROM mitarbeiter;

