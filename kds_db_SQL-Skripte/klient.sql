-- -----------------------------------------------------
-- Testquerys für kds.klient
-- Testdaten für kds.klient
-- -----------------------------------------------------

SELECT klient_iD,vorname,nachname,geburtsdatum,klientennr FROM kds.klient;

SELECT klient_id,vorname,nachname,geburtsdatum,klientennr,fk_erstgespraech_ID FROM kds.klient ORDER BY klientennr;

/*INSERT INTO kds.klient (vorname, nachname, geburtsdatum, klientennr) VALUES
('Miriam', 'Meyer', '1980-03-01', 'A0001'),
('Hubert', 'Hirsch', '1993-05-30', 'A0002'),
('Jeanette', 'Hansen', '1973-12-24', 'A0003'),
('Miroslav', 'Klose', '1978-06-09', 'A0004'),
('Lydia', 'Fuchs', '1985-10-09', 'A0005');
*/