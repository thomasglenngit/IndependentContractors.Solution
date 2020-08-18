-- MySQL dump 10.13  Distrib 8.0.15, for macos10.14 (x86_64)
--
-- Host: localhost    Database: independent_contracts
-- ------------------------------------------------------
-- Server version	8.0.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__EFMigrationsHistory`
--

DROP TABLE IF EXISTS `__EFMigrationsHistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Armories`
--

DROP TABLE IF EXISTS `Armories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Armories` (
  `ArmoryId` int(11) NOT NULL AUTO_INCREMENT,
  `WeaponName` longtext,
  PRIMARY KEY (`ArmoryId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `ClientContractor`
--

DROP TABLE IF EXISTS `ClientContractor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ClientContractor` (
  `ClientContractorId` int(11) NOT NULL AUTO_INCREMENT,
  `ClientId` int(11) NOT NULL,
  `ContractorId` int(11) NOT NULL,
  PRIMARY KEY (`ClientContractorId`),
  KEY `IX_ClientContractor_ClientId` (`ClientId`),
  KEY `IX_ClientContractor_ContractorId` (`ContractorId`),
  CONSTRAINT `FK_ClientContractor_Clients_ClientId` FOREIGN KEY (`ClientId`) REFERENCES `clients` (`ClientId`) ON DELETE CASCADE,
  CONSTRAINT `FK_ClientContractor_Contractors_ContractorId` FOREIGN KEY (`ContractorId`) REFERENCES `contractors` (`ContractorId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Clients`
--

DROP TABLE IF EXISTS `Clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Clients` (
  `ClientId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` longtext,
  `accountCreationDate` datetime(6) NOT NULL,
  `OrganizationId` int(11) DEFAULT NULL,
  PRIMARY KEY (`ClientId`),
  KEY `IX_Clients_OrganizationId` (`OrganizationId`),
  CONSTRAINT `FK_Clients_Organizations_OrganizationId` FOREIGN KEY (`OrganizationId`) REFERENCES `organizations` (`OrganizationId`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `ContractorArmory`
--

DROP TABLE IF EXISTS `ContractorArmory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ContractorArmory` (
  `ContractorArmoryId` int(11) NOT NULL AUTO_INCREMENT,
  `ContractorId` int(11) NOT NULL,
  `ArmoryId` int(11) NOT NULL,
  PRIMARY KEY (`ContractorArmoryId`),
  KEY `IX_ContractorArmory_ArmoryId` (`ArmoryId`),
  KEY `IX_ContractorArmory_ContractorId` (`ContractorId`),
  CONSTRAINT `FK_ContractorArmory_Armories_ArmoryId` FOREIGN KEY (`ArmoryId`) REFERENCES `armories` (`ArmoryId`) ON DELETE CASCADE,
  CONSTRAINT `FK_ContractorArmory_Contractors_ContractorId` FOREIGN KEY (`ContractorId`) REFERENCES `contractors` (`ContractorId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Contractors`
--

DROP TABLE IF EXISTS `Contractors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Contractors` (
  `ContractorId` int(11) NOT NULL AUTO_INCREMENT,
  `Alias` longtext,
  `RegionOfOperation` longtext,
  PRIMARY KEY (`ContractorId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Organizations`
--

DROP TABLE IF EXISTS `Organizations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Organizations` (
  `OrganizationId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` longtext,
  PRIMARY KEY (`OrganizationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-08-17 22:45:01
