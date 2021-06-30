SELECT klient_id,vorname,nachname,geburtsdatum,klientennr FROM kds.klient;

SELECT klient_id,vorname,nachname,geburtsdatum,klientennr,fk_erstgespraech_ID FROM kds.klient ORDER BY klientennr;

SELECT  e.Eintraege_ID, e.eintrag, e.fk_nutzer_ID, n.nachname, n.vorname, n.arztnummer
FROM kds.eintraege e 
LEFT OUTER JOIN kds.nutzer n ON n.nutzer_ID = e.fk_nutzer_ID 
WHERE fk_klient_id = 4;

UPDATE kds.eintraege SET eintrag = 'Hallo Hallo!' WHERE eintraege_id = 7;