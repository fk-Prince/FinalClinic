-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: db_clinic
-- ------------------------------------------------------
-- Server version	8.0.41

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
-- Table structure for table `clinichistory_tbl`
--
CREATE DATABASE db_clinic;
USE db_clinic;

DROP TABLE IF EXISTS `clinichistory_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clinichistory_tbl` (
  `DateDischarged` date DEFAULT NULL,
  `DateAdmitted` date NOT NULL,
  `PatientID` bigint NOT NULL,
  `TotalBill` decimal(10,2) DEFAULT NULL,
  KEY `fkpatient_idx` (`PatientID`),
  CONSTRAINT `fkpatient` FOREIGN KEY (`PatientID`) REFERENCES `patient_tbl` (`patientId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clinichistory_tbl`
--

LOCK TABLES `clinichistory_tbl` WRITE;
/*!40000 ALTER TABLE `clinichistory_tbl` DISABLE KEYS */;
/*!40000 ALTER TABLE `clinichistory_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doctor_operation_mm_tbl`
--

DROP TABLE IF EXISTS `doctor_operation_mm_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `doctor_operation_mm_tbl` (
  `doctorOperationID` bigint NOT NULL AUTO_INCREMENT,
  `operationCode` varchar(10) NOT NULL,
  `doctorId` bigint NOT NULL,
  PRIMARY KEY (`doctorOperationID`,`operationCode`,`doctorId`),
  KEY `fk_doctor_operation_mm_tbl_doctor_tbl1_idx` (`doctorId`),
  KEY `fk_doctor_operation_mm_tbl_operation_tbl1` (`operationCode`),
  CONSTRAINT `fk_doctor_operation_mm_tbl_doctor_tbl1` FOREIGN KEY (`doctorId`) REFERENCES `doctor_tbl` (`DoctorId`) ON UPDATE CASCADE,
  CONSTRAINT `fk_doctor_operation_mm_tbl_operation_tbl1` FOREIGN KEY (`operationCode`) REFERENCES `operation_tbl` (`operationCode`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctor_operation_mm_tbl`
--

LOCK TABLES `doctor_operation_mm_tbl` WRITE;
/*!40000 ALTER TABLE `doctor_operation_mm_tbl` DISABLE KEYS */;
INSERT INTO `doctor_operation_mm_tbl` VALUES (6,'BE5',101),(9,'GE4',101),(7,'BE5',102),(8,'EC5',102);
/*!40000 ALTER TABLE `doctor_operation_mm_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doctor_tbl`
--

DROP TABLE IF EXISTS `doctor_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `doctor_tbl` (
  `DoctorId` bigint NOT NULL,
  `doctorFirstname` varchar(45) NOT NULL,
  `doctorMiddleName` varchar(45) NOT NULL,
  `doctorLastname` varchar(45) NOT NULL,
  `doctorAge` int NOT NULL,
  `PIN` varchar(45) NOT NULL,
  `DateHired` date NOT NULL,
  `gender` varchar(45) NOT NULL,
  `address` varchar(45) NOT NULL,
  PRIMARY KEY (`DoctorId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctor_tbl`
--

LOCK TABLES `doctor_tbl` WRITE;
/*!40000 ALTER TABLE `doctor_tbl` DISABLE KEYS */;
INSERT INTO `doctor_tbl` VALUES (101,'Prince','Iba','Sestoso',22,'0977','2024-12-12','Male','Roxas'),(102,'John','Doe','Doe',50,'1111','2015-05-30','Male','US');
/*!40000 ALTER TABLE `doctor_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `operation_tbl`
--

DROP TABLE IF EXISTS `operation_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `operation_tbl` (
  `operationCode` varchar(10) NOT NULL,
  `operationName` varchar(45) DEFAULT NULL,
  `DateAdded` date DEFAULT NULL,
  `Description` varchar(45) DEFAULT NULL,
  `Price` decimal(10,2) DEFAULT NULL,
  `Duration` time DEFAULT NULL,
  PRIMARY KEY (`operationCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `operation_tbl`
--

LOCK TABLES `operation_tbl` WRITE;
/*!40000 ALTER TABLE `operation_tbl` DISABLE KEYS */;
INSERT INTO `operation_tbl` VALUES ('BE5','Surgery','2022-05-05','badb',5000.00,'10:10:10'),('EC5','Eye Checkup','2025-03-14','bsdf',6000.00,'10:00:00'),('GE4','BloodTest','2024-12-11','avsdas',2000.00,'02:20:00');
/*!40000 ALTER TABLE `operation_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patient_tbl`
--

DROP TABLE IF EXISTS `patient_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patient_tbl` (
  `patientId` bigint NOT NULL AUTO_INCREMENT,
  `StaffID` bigint NOT NULL,
  `patientfirstname` varchar(45) NOT NULL,
  `patientmiddlename` varchar(45) NOT NULL,
  `patientlastname` varchar(45) NOT NULL,
  `address` varchar(45) NOT NULL,
  `age` int NOT NULL,
  `gender` varchar(45) NOT NULL,
  `birthdate` date NOT NULL,
  `contactnumber` varchar(15) DEFAULT NULL,
  `roomNo` bigint NOT NULL,
  PRIMARY KEY (`patientId`),
  KEY `staffId_idx` (`StaffID`),
  KEY `roomno_idx` (`roomNo`),
  CONSTRAINT `roomno` FOREIGN KEY (`roomNo`) REFERENCES `rooms_tbl` (`RoomNo`),
  CONSTRAINT `staffId` FOREIGN KEY (`StaffID`) REFERENCES `staff_tbl` (`StaffID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient_tbl`
--

LOCK TABLES `patient_tbl` WRITE;
/*!40000 ALTER TABLE `patient_tbl` DISABLE KEYS */;
/*!40000 ALTER TABLE `patient_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patientappointment_tbl`
--

DROP TABLE IF EXISTS `patientappointment_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patientappointment_tbl` (
  `AppointmentDetailNo` bigint NOT NULL AUTO_INCREMENT,
  `doctorOperationID` bigint NOT NULL,
  `PatientID` bigint NOT NULL,
  `DateSchedule` date DEFAULT NULL,
  `StartTime` time DEFAULT NULL,
  `EndTime` time DEFAULT NULL,
  `diagnosis` varchar(200) DEFAULT NULL,
  `Bill` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`AppointmentDetailNo`,`doctorOperationID`),
  KEY `fk_PatientAppointment_tbl_doctor_operation_mm_tbl1_idx` (`doctorOperationID`),
  KEY `patientid_idx` (`PatientID`),
  CONSTRAINT `fk_PatientAppointment_tbl_doctor_operation_mm_tbl1` FOREIGN KEY (`doctorOperationID`) REFERENCES `doctor_operation_mm_tbl` (`doctorOperationID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `patientid` FOREIGN KEY (`PatientID`) REFERENCES `patient_tbl` (`patientId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patientappointment_tbl`
--

LOCK TABLES `patientappointment_tbl` WRITE;
/*!40000 ALTER TABLE `patientappointment_tbl` DISABLE KEYS */;
/*!40000 ALTER TABLE `patientappointment_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rooms_tbl`
--

DROP TABLE IF EXISTS `rooms_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rooms_tbl` (
  `RoomNo` bigint NOT NULL,
  `RoomType` varchar(20) NOT NULL,
  `Occupation` varchar(45) NOT NULL DEFAULT 'Not Occupied',
  PRIMARY KEY (`RoomNo`),
  KEY `roomtyp_idx` (`RoomType`),
  CONSTRAINT `rrr` FOREIGN KEY (`RoomType`) REFERENCES `roomtype_tbl` (`roomtype`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rooms_tbl`
--

LOCK TABLES `rooms_tbl` WRITE;
/*!40000 ALTER TABLE `rooms_tbl` DISABLE KEYS */;
/*!40000 ALTER TABLE `rooms_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roomtype_tbl`
--

DROP TABLE IF EXISTS `roomtype_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roomtype_tbl` (
  `roomtype` varchar(20) NOT NULL,
  `roomprice` decimal(10,2) NOT NULL,
  PRIMARY KEY (`roomtype`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roomtype_tbl`
--

LOCK TABLES `roomtype_tbl` WRITE;
/*!40000 ALTER TABLE `roomtype_tbl` DISABLE KEYS */;
INSERT INTO `roomtype_tbl` VALUES ('Shared',500.00),('Solo',1500.00),('VIP',3000.00),('VVIP',5000.00);
/*!40000 ALTER TABLE `roomtype_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff_tbl`
--

DROP TABLE IF EXISTS `staff_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `staff_tbl` (
  `StaffID` bigint NOT NULL AUTO_INCREMENT,
  `Username` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `FirstName` varchar(45) DEFAULT NULL,
  `MiddleName` varchar(45) DEFAULT NULL,
  `LastName` varchar(45) DEFAULT NULL,
  `Age` int DEFAULT NULL,
  `Address` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`StaffID`),
  UNIQUE KEY `Username_UNIQUE` (`Username`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff_tbl`
--

LOCK TABLES `staff_tbl` WRITE;
/*!40000 ALTER TABLE `staff_tbl` DISABLE KEYS */;
INSERT INTO `staff_tbl` VALUES (1,'a','a',NULL,NULL,NULL,NULL,NULL),(2,'admin','admin',NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `staff_tbl` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-03-23 22:43:50
