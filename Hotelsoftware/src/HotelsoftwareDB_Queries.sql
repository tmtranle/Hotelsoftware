USE hotelsoftwaredb;

SELECT f_id, f_bezeichnung, f_strasse, f_hausnummer, f_postleitzahl, f_stadt, f_land FROM firma ORDER BY f_bezeichnung;

SELECT g_id, g_vorname, g_nachname, g_geburtsdatum, g_strasse, g_hausnummer,g_postleitzahl, g_stadt, g_land, f_id FROM gast ORDER BY g_nachname;

SELECT z_id, z_kategorie, z_status FROM zimmer;

SELECT r_id, checkIn, checkOut, g_id, z_id FROM reservierung;

SELECT l_id, l_bezeichnung, l_preis FROM leistung;

SELECT re_id, l_id, r_id FROM rechnungskonto;

SELECT a_id, a_bezeichnung FROM abteilung;

SELECT m_id, m_vorname, m_nachname, m_position, a_id FROM mitarbeiter;