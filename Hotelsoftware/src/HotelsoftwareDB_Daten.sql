USE hotelsoftwaredb;

INSERT INTO firma VALUES
(NULL, 'FlixMobility GmbH', 'Friedenheimer Bruecke', '16', '80639', 'Muenchen', 'Deutschland'),
                         (NULL, 'Louisiana Museum of Modern Art', 'Gl. Strandvej', '13', '3050', 'Humlebaek', 'Daenemark'),
                         (NULL, 'Vattenfall GmbH','Sellerstraße', '16', '13353', 'Berlin', 'Deutschland'),
                         (NULL, 'Amazon Europe Core S.a r.l.', 'avenue John F. Kennedy', '38', 'L-1855', 'Luxemburg', 'Luxemburg'),
                         (NULL, 'Zalando SE', 'Valeska-Gert-Strasse', '5', '10243', 'Berlin', 'Deutschland'),
                         (NULL, 'IKEA', 'Handelsvaegen', '4', '343 33', 'Aelmhult', 'Schweden'),
                         (NULL, 'Inditex', 'Av. Diputación s/n', '', '15143', 'Arteixo', 'Spanien');

INSERT INTO gast VALUES
(NULL, 'Hella', 'Schneider', '1965-06-07', 'Silberstrasse', '12', '45879','Gelsenkirchen', 'Deutschland', 1),
                        (NULL, 'Udo', 'Fern', '1985-06-21', 'Neue Heimat', '185A', '12354', 'Berlin', 'Deutschland', 3),
                        (NULL, 'Mirka', 'Theis', '1989-07-04', 'Muehlenstrasse', '147', '4587', 'Buchegg', 'Schweiz', 2),
                        (NULL, 'Jemma', 'Barcelo', '1993-06-24', 'Carrer de Corsega', '204', '08036', 'Barcelona', 'Spanien', 7),
                        (NULL, 'Julia', 'Daux', '1978-10-06', 'Main St', '13', 'N37 DW76', ' Co. Westmeath', 'Irland', 4),
                        (NULL, 'Mikey', 'Chen', '1989-10-23', 'Orchard Road', '100 ', '238840', 'Singapur', 'Singapur', 5),
                        (NULL, 'Jenni', 'Wissma', '1978-06-04', 'Great Ocean Road', '11', 'VIC 3233', 'Victoria', 'Australien', 6),
                        (NULL, 'Niall', 'Bens', '1994-01-07', 'Lombard Street', '12', 'CA 94111', 'San Francisco', 'USA', 7),
                        (NULL, 'Jennifer', 'Graz', '2000-12-31', 'Oderberger Strasse', '5','10435', 'Berlin', 'Deutschland', 1),
                        (NULL, 'Silke', 'Silberstein', '1974-04-04', 'Fasanenstrasse', '23','10719', 'Berlin', 'Deutschland', 2),
                        (NULL, 'Nora', 'Nassen', '1956-08-09', 'Karl-Marx-Strasse', '155', '12043', 'Berlin','Deutschland', 6),
                        (NULL, 'Mario', 'Lopez', '1978-02-03', 'Las Vegas Boulevard South', '185', 'NV 89101','Las Vegas', 'USA', 7),
                        (NULL, 'Jun', 'Hao', '1982-06-14', 'Abbey Road','75', 'NW8 0AE', 'London', 'England', 5),
                        (NULL, 'Marion', 'Willkens', '1976-03-17', 'Trollstigen', '12','6300', 'Andalsnes', 'Norwegen', 6),
                        (NULL, 'Manon', 'Dupont', '1987-05-30', 'Av. des Champs-Élysées', '117', '75008',  'Paris', 'Frankreich', 7),
                        (NULL, 'Hubert', 'Meier', '2001-01-01', 'Paul-Lincke-Ufer', '17', '10999', 'Berlin', 'Deutschland', 1),
                        (NULL, 'Franziska', 'Vogel', '1990-08-16', 'Lottumstrasse', '25', '10117', 'Berlin', 'Deutschland', 1),
                        (NULL, 'Jessica', 'Weiss', '1979-07-20', 'Knorrpromenade', '17', '10245', 'Berlin', 'Deutschland', NULL);

INSERT INTO zimmer VALUES
(100, 'DZ', 'sauber'),
                        (101, 'DZ', 'dreckig'),
                        (102, 'DZ', 'dreckig'),
                        (103, 'DZ', 'sauber'),
                        (104, 'DZ', 'checken'),
                        (105, 'DZ', 'sauber'),
                        (106, 'DZ', 'checken'),
                        (107, 'DZ', 'sauber'),
                        (109, 'DZ', 'sauber'),
                        (110, 'DZ', 'sauber'),
                        (111, 'DZ', 'sauber'),
                        (112, 'DZ', 'dreckig'),
                        (114, 'DZ', 'dreckig');
INSERT INTO zimmer VALUES
(108, 'EZ', 'sauber');
INSERT INTO zimmer VALUES
(200, 'DZ', 'dreckig'),
                        (201, 'EZ', 'dreckig'),
                        (202, 'EZ', 'dreckig'),
                        (203, 'EZ', 'dreckig'),
                        (204, 'EZ', 'dreckig'),
                        (205, 'EZ', 'checken'),
                        (206, 'EZ', 'sauber'),
                        (207, 'EZ', 'checken'),
                        (209, 'EZ', 'sauber'),
                        (210, 'EZ', 'checken'),
                        (211, 'TRI', 'sauber'),
                        (212, 'TRI', 'checken'),
                        (214, 'TRI', 'sauber');
INSERT INTO zimmer VALUES
(208, 'EZ', 'sauber');

INSERT INTO reservierung VALUES
(NULL, '2021-06-22', '2021-06-22', 4, 106),
(NULL, '2021-06-22', '2021-06-22', 3, 206),
(NULL, '2021-06-22', '2021-06-22', 52, 207),
(NULL, '2021-06-22', '2021-06-24', 43, 209),
(NULL, '2021-06-22', '2021-06-22', 50, 101),
(NULL, '2021-06-22', '2021-06-23', 51, 100);

INSERT INTO leistung VALUES
(NULL, 'Logis', 79.00),
                            (NULL, 'Fruehstueck', 9.50),
                            (NULL, 'Spa-Eintritt', 14.50),
                            (NULL, 'Massage', 39.00);

INSERT INTO rechnungskonto VALUES
(NULL, 1, 4),
                                  (NULL, 1,15),
                                  (NULL, 2, 15);

INSERT INTO abteilung VALUES
(NULL, 'Housekeeping'),
                             (NULL, 'Haustechnik'),
                             (NULL, 'Food and Beverage'),
                             (NULL, 'Sales and Marketing'),
                             (NULL, 'Controlling'),
                             (NULL, 'Human Resources'),
                             (NULL, 'Management');

INSERT INTO mitarbeiter VALUES
(NULL, 'Mareike', 'Mueller', 'Hausdame', 1),
                               (NULL, 'Arnim', 'Rabe', 'Haustechniker', 2),
                               (NULL, 'Friedrich', 'Warnke', 'Frühstücksleitung', 3),
                               (NULL, 'Martin', 'Bethke', 'Sales-Manager', 4),
                               (NULL, 'Nina', 'De Witzke', 'Controller', 5),
                               (NULL, 'Leah', 'Runkel', 'Personaler', 6),
                               (NULL, 'Andrea', 'Lupita', 'Hoteldirektor', 7),
                               (NULL, 'Steven', 'Wolf', 'Stellvertretender Hoteldirektor', 7);