CREATE DATABASE  IF NOT EXISTS `university` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `university`;
-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: university
-- ------------------------------------------------------
-- Server version	8.0.21

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
-- Table structure for table `hibernate_sequence`
--

DROP TABLE IF EXISTS `hibernate_sequence`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hibernate_sequence` (
  `next_val` bigint DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hibernate_sequence`
--

LOCK TABLES `hibernate_sequence` WRITE;
/*!40000 ALTER TABLE `hibernate_sequence` DISABLE KEYS */;
INSERT INTO `hibernate_sequence` VALUES (6);
/*!40000 ALTER TABLE `hibernate_sequence` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `student` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `mathScore` int DEFAULT NULL,
  `math_score` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` VALUES (3,'Le Thi Phuong Thao',10,10),(25,'Thao',10,0),(26,'Thao',10,0),(27,'Thao',10,0),(28,'Thao',10,0),(29,'Thao',10,0),(30,'Thao',10,0),(31,'Thao',10,0),(32,'Thao',10,0),(33,'Thao',10,0),(34,'Thao',10,0),(35,'Thao',10,0),(36,'Thao',10,0),(37,'Thao',10,0),(38,'Thao',10,0),(39,'Thao',10,0),(40,'Thao',10,0),(41,'Thao',10,0),(42,'Thao',10,0),(43,'Thao',10,0),(44,'Thao',10,0),(45,'Thao',10,0),(46,'Thao',10,0),(47,'Thao',10,0),(48,'Thao',10,0),(49,'Thao',10,0),(50,'Thao',10,0),(51,'Thao',10,0),(52,'Thao',10,0),(53,'Thao',10,0),(54,'Thao',10,0),(55,'Thao',10,0),(56,'Thao',10,0),(57,'Thao',10,0),(58,'Thao',10,0),(59,'Thao',10,0),(60,'Thao',10,0),(61,'Thao',10,0),(62,'Thao',10,0),(63,'Thao',10,0),(64,'Thao',10,0),(65,'Thao',10,0),(66,'Thao',10,0),(67,'Thao',10,0),(68,'Thao',10,0),(69,'Thao',10,0),(70,'Thao',10,0),(71,'Thao',10,0),(72,'Thao',10,0),(73,'Thao',10,0),(74,'Thao',10,0),(75,'Thao',10,0),(76,'Thao',10,0),(77,'Thao',10,0),(78,'Thao',10,0),(79,'Thao',10,0),(80,'Thao',10,0),(81,'Thao',10,0),(82,'Thao',10,0),(83,'Thao',10,0),(84,'Thao',10,0),(85,'Thao',10,0),(86,'Thao',10,0),(87,'Thao',10,0),(88,'Thao',10,0),(89,'Thao',10,0),(90,'Thao',10,0),(91,'Thao',10,0),(92,'Thao',10,0),(93,'Thao',10,0),(94,'Thao',10,0),(95,'Thao',10,0),(96,'Thao',10,0),(97,'Thao',10,0),(98,'Thao',10,0),(99,'Thao',10,0),(100,'Thao',10,0);
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-01-10 21:52:23
