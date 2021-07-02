-- -----------------------------------------------------
-- Testquerys für kds.eintraege
-- -----------------------------------------------------

SELECT * FROM kds.eintraege;

INSERT INTO kds.eintraege (eintrag, fk_nutzer_ID, fk_klient_ID) VALUES ('Hallo Welt', 1, 1); 

UPDATE kds.eintraege SET eintrag = 'Hallo Hallo!' WHERE eintraege_id = 7;

DELETE FROM kds.eintraege WHERE Eintraege_ID = 3;

SELECT  e.Eintraege_ID, e.eintrag, e.datumEintrag, e.fk_nutzer_ID, n.nachname, n.vorname, n.arztnummer
FROM kds.eintraege e 
LEFT OUTER JOIN kds.nutzer n ON n.nutzer_ID = e.fk_nutzer_ID 
WHERE fk_klient_id = 4;
