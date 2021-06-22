CREATE DATABASE HotelsoftwareDB;
USE HotelsoftwareDB;

CREATE TABLE firma
(
    f_id INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY,
    f_bezeichnung VARCHAR(50),
    f_strasse VARCHAR(50),
    f_hausnummer VARCHAR(10),
    f_postleitzahl VARCHAR(50),
    f_stadt VARCHAR(50),
    f_land VARCHAR(50)
);

CREATE TABLE gast
(
    g_id INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY,
    g_vorname VARCHAR(50),
    g_nachname VARCHAR(50),
    g_geburtsdatum DATE,
    g_strasse VARCHAR(50),
    g_hausnummer VARCHAR(10),
    g_postleitzahl VARCHAR(50),
    g_stadt VARCHAR(50),
    g_land VARCHAR(50),
    f_id INTEGER,
    FOREIGN KEY f_id_fk (f_id) REFERENCES firma (f_id)
);

CREATE TABLE zimmer
(
    z_id INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY,
    z_kategorie VARCHAR(50),
    z_status VARCHAR(50)
);

CREATE TABLE reservierung
(
    r_id INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY,
    checkIn DATE,
    checkOut DATE,
    g_id INTEGER,
    FOREIGN KEY g_id_fk (g_id) REFERENCES gast (g_id),
    z_id INTEGER,
    FOREIGN KEY z_id_fk (z_id) REFERENCES zimmer (z_id)
);

CREATE TABLE leistung
(
    l_id INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
    l_bezeichnung VARCHAR(50),
    l_preis DOUBLE
);

CREATE TABLE rechnungskonto
(
    re_id INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY,
    l_id INTEGER,
    FOREIGN KEY l_id_fk (l_id) REFERENCES leistung (l_id),
    r_id INTEGER,
    FOREIGN KEY r_id_fk (r_id) REFERENCES reservierung (r_id)
);

CREATE TABLE abteilung
(
    a_id INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY,
    a_bezeichnung VARCHAR(50)
);

CREATE TABLE mitarbeiter
(
    m_id INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY,
    m_vorname VARCHAR(50),
    m_nachname VARCHAR(50),
    m_position VARCHAR(50),
    a_id INTEGER,
    FOREIGN KEY a_id_fk (a_id) REFERENCES abteilung (a_id)
);

