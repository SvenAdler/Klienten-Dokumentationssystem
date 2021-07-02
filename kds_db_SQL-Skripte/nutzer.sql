-- -----------------------------------------------------
-- Testquerys für kds.nutzer

-- -----------------------------------------------------

SELECT nutzer_ID, nachname, mailadresse, arztnummer, passwort FROM kds.nutzer;

INSERT INTO kds.nutzer (vorname, nachname, mailadresse, arztnummer, passwort) VALUES 
('Jannis', 'Adler', 'Jannis.Adler@praxis.com', 'E234', 'dfasoiuhf'); 
# Wenn automatisches Login genutzt wird im Code, muss das gehashte Passwort verwendet werden!

DELETE FROM kds.nutzer WHERE nutzer_ID = 2;

select nutzer_ID, vorname, nachname, mailadresse, arztnummer from kds.nutzer where mailadresse = 'H.Adler@praxis.de' AND passwort = 'fas3234' LIMIT 1; 