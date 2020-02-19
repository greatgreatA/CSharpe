CREATE DATABASE  IF NOT EXISTS `logement` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `logement`;
-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: logement
-- ------------------------------------------------------
-- Server version	8.0.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `locataire`
--

DROP TABLE IF EXISTS `locataire`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `locataire` (
  `IDLOC` int NOT NULL,
  `NOM` char(32) NOT NULL,
  `REVENU_MENSUEL` double NOT NULL,
  PRIMARY KEY (`IDLOC`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `locataire`
--

LOCK TABLES `locataire` WRITE;
/*!40000 ALTER TABLE `locataire` DISABLE KEYS */;
INSERT INTO `locataire` VALUES (1,'Jeanne',16700),(3,'Louis',6900.7),(4,'Marie',180000000000000),(5,'Jean-Pierre',4000),(7,'FRANCOIS',67800),(8,'PATRICK',65400);
/*!40000 ALTER TABLE `locataire` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `logement`
--

DROP TABLE IF EXISTS `logement`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `logement` (
  `IDLOG` int NOT NULL,
  `IDLOC` int DEFAULT NULL,
  `IPPARC` smallint DEFAULT NULL,
  `ADRESSE` char(32) NOT NULL,
  `NB_PIECES` int NOT NULL,
  `LOYER` double NOT NULL,
  PRIMARY KEY (`IDLOG`),
  KEY `I_FK_LOGEMENT_LOCATAIRE` (`IDLOC`),
  KEY `I_FK_LOGEMENT_PARC` (`IPPARC`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `logement`
--

LOCK TABLES `logement` WRITE;
/*!40000 ALTER TABLE `logement` DISABLE KEYS */;
INSERT INTO `logement` VALUES (2,NULL,NULL,'rum du parc',6,468),(4,NULL,NULL,'rum du ciel',7,4690),(5,NULL,NULL,'51 RUE DU QUAI',8,7000),(6,NULL,NULL,'rue dutertre',-7,2300),(7,NULL,NULL,'rue de la paix',-7,7000);
/*!40000 ALTER TABLE `logement` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maison`
--

DROP TABLE IF EXISTS `maison`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `maison` (
  `IDLOG` int NOT NULL,
  `SURFACE_TER` double(5,2) NOT NULL,
  PRIMARY KEY (`IDLOG`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maison`
--

LOCK TABLES `maison` WRITE;
/*!40000 ALTER TABLE `maison` DISABLE KEYS */;
INSERT INTO `maison` VALUES (3,450.00),(6,60.00),(7,100.00);
/*!40000 ALTER TABLE `maison` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `parc`
--

DROP TABLE IF EXISTS `parc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `parc` (
  `IPPARC` smallint NOT NULL,
  `NOM` char(32) NOT NULL,
  PRIMARY KEY (`IPPARC`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parc`
--

LOCK TABLES `parc` WRITE;
/*!40000 ALTER TABLE `parc` DISABLE KEYS */;
INSERT INTO `parc` VALUES (2,'Antony'),(3,'Cachan'),(4,'Paris'),(5,'GRETA'),(6,'HAY'),(7,'CHOISY');
/*!40000 ALTER TABLE `parc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'logement'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-02-19  6:30:14
