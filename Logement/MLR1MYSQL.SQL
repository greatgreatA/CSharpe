DROP DATABASE IF EXISTS MLR1mysql;

CREATE DATABASE IF NOT EXISTS MLR1mysql;
USE MLR1mysql;
# -----------------------------------------------------------------------------
#       TABLE : LOGEMENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS LOGEMENT
 (
   IDLOG INTEGER NOT NULL  ,
   IDLOC INTEGER NULL  ,
   IPPARC SMALLINT NULL  ,
   ADRESSE CHAR(32) NOT NULL  ,
   LOYER REAL(5,2) NOT NULL  
   , PRIMARY KEY (IDLOG) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE LOGEMENT
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_LOGEMENT_LOCATAIRE
     ON LOGEMENT (IDLOC ASC);

CREATE  INDEX I_FK_LOGEMENT_PARC
     ON LOGEMENT (IPPARC ASC);

# -----------------------------------------------------------------------------
#       TABLE : PARC
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PARC
 (
   IPPARC SMALLINT NOT NULL  ,
   NOM CHAR(32) NOT NULL  
   , PRIMARY KEY (IPPARC) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : MAISON
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS MAISON
 (
   IDLOG INTEGER NOT NULL  ,
   SURFACE_TER REAL(5,2) NOT NULL  
   , PRIMARY KEY (IDLOG) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : LOCATAIRE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS LOCATAIRE
 (
   IDLOC INTEGER NOT NULL  ,
   NOM CHAR(32) NOT NULL  ,
   REVENU_MENSUEL REAL(5,2) NOT NULL  
   , PRIMARY KEY (IDLOC) 
 ) 
 comment = "";


# -----------------------------------------------------------------------------
#       CREATION DES REFERENCES DE TABLE
# -----------------------------------------------------------------------------


ALTER TABLE LOGEMENT 
  ADD FOREIGN KEY FK_LOGEMENT_LOCATAIRE (IDLOC)
      REFERENCES LOCATAIRE (IDLOC) ;


ALTER TABLE LOGEMENT 
  ADD FOREIGN KEY FK_LOGEMENT_PARC (IPPARC)
      REFERENCES PARC (IPPARC) ;


ALTER TABLE MAISON 
  ADD FOREIGN KEY FK_MAISON_LOGEMENT (IDLOG)
      REFERENCES LOGEMENT (IDLOG) ;

