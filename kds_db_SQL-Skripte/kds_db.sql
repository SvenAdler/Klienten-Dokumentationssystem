
SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema kds
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS kds DEFAULT CHARACTER SET utf8 ;
USE kds ;

-- -----------------------------------------------------
-- Table kds.nutzer
-- -----------------------------------------------------
#DROP TABLE IF EXISTS kds.nutzer;
CREATE TABLE IF NOT EXISTS kds.nutzer (
  nutzer_ID INT NOT NULL AUTO_INCREMENT,
  vorname VARCHAR(45) NOT NULL,
  nachname VARCHAR(45) NOT NULL,
  mailadresse VARCHAR(50) NOT NULL,
  arztnummer VARCHAR(9) NULL,
  passwort VARCHAR(200) NULL,
  PRIMARY KEY (nutzer_ID),
  UNIQUE INDEX idNutzer_UNIQUE (nutzer_ID ASC) VISIBLE,
  UNIQUE INDEX arztnummer_UNIQUE (arztnummer ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table kds.klient
-- -----------------------------------------------------
#DROP TABLE IF EXISTS kds.klient;
CREATE TABLE IF NOT EXISTS kds.klient (
  klient_ID INT NOT NULL AUTO_INCREMENT,
  vorname VARCHAR(45) NOT NULL,
  nachname VARCHAR(45) NOT NULL,
  geburtsdatum DATE NOT NULL,
  klientennr VARCHAR(12) NOT NULL,
  #datumErstgespraech DATE NOT NULL,
  fk_erstgespraech_ID INT NULL,
  PRIMARY KEY (klient_ID),
  UNIQUE INDEX idklient_UNIQUE (klient_ID ASC) VISIBLE,
  UNIQUE INDEX klientennr_UNIQUE (klientennr ASC) VISIBLE,
  CONSTRAINT fk_erstgespraech_eintrag
    FOREIGN KEY (fk_erstgespraech_ID) 
    REFERENCES kds.eintraege (eintraege_ID)
    ON DELETE SET NULL)
ENGINE = InnoDB;

/*ALTER TABLE kds.klient DROP
 CONSTRAINT fk_erstgespraech_eintrag;
 ALTER TABLE kds.klient ADD
 CONSTRAINT fk_erstgespraech_eintrag 
    FOREIGN KEY (fk_erstgespraech_ID) 
    REFERENCES kds.eintraege (eintraege_ID)
    ON DELETE SET NULL;
*/
-- -----------------------------------------------------
-- Table kds.eintraege
-- -----------------------------------------------------
#DROP TABLE IF EXISTS kds.eintraege;
CREATE TABLE IF NOT EXISTS kds.eintraege (
  Eintraege_ID INT NOT NULL AUTO_INCREMENT,
  eintrag MEDIUMTEXT NULL,
  datumEintrag DATETIME NOT NULL,
  fk_nutzer_ID INT NOT NULL,
  fk_klient_ID INT NOT NULL,
  PRIMARY KEY (Eintraege_ID),
  INDEX fk_eintraege_nutzer_idx (fk_nutzer_ID ASC) VISIBLE,
  INDEX fk_eintraege_klient1_idx (fk_klient_ID ASC) VISIBLE,
  CONSTRAINT fk_eintraege_nutzer
    FOREIGN KEY (fk_nutzer_ID)
    REFERENCES kds.nutzer (nutzer_ID)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_eintraege_klient
    FOREIGN KEY (fk_klient_ID)
    REFERENCES kds.klient (klient_ID)
    ON DELETE CASCADE
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
