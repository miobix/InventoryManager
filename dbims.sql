-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.7.43-log - MySQL Community Server (GPL)
-- Server OS:                    Win64
-- HeidiSQL Version:             12.5.0.6677
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for dbims
CREATE DATABASE IF NOT EXISTS `dbims` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `dbims`;

-- Dumping structure for table dbims.tbcategory
CREATE TABLE IF NOT EXISTS `tbcategory` (
  `catId` varchar(50) NOT NULL,
  `catName` varchar(50) NOT NULL,
  PRIMARY KEY (`catId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table dbims.tbcategory: ~3 rows (approximately)
INSERT INTO `tbcategory` (`catId`, `catName`) VALUES
	('12c90f5b-3604-4af0-85ac-94ba33d50268', 'swa'),
	('29b33377-0cb2-481d-9020-6d05f8bb32af', 'Bread'),
	('4c143c7e-c69f-4444-98b9-f0dc170febcd', 'Milk');

-- Dumping structure for table dbims.tbuser
CREATE TABLE IF NOT EXISTS `tbuser` (
  `username` varchar(50) NOT NULL,
  `fullname` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `email` varchar(50) NOT NULL,
  `userId` varchar(50) NOT NULL,
  PRIMARY KEY (`userId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table dbims.tbuser: ~2 rows (approximately)
INSERT INTO `tbuser` (`username`, `fullname`, `password`, `email`, `userId`) VALUES
	('adminswa', 'admin lastname', 'admin', 'admin@admin.test', '379a43b6-ed27-49ac-a1e1-67427816e1e8'),
	('user3', 'best user ever', 'notsafe', '', 'e7e5bbfe-26ad-4f64-b468-18c90ad195c2');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
