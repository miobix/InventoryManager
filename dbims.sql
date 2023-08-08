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
	('29b33377-0cb2-481d-9020-6d05f8bb32af', 'Bread'),
	('4c143c7e-c69f-4444-98b9-f0dc170febcd', 'Milk'),
	('81d3dd64-31ef-400e-8cdf-65d8a1cde2de', 'Eggs');

-- Dumping structure for table dbims.tbproduct
CREATE TABLE IF NOT EXISTS `tbproduct` (
  `prodId` varchar(50) NOT NULL,
  `prodName` varchar(50) NOT NULL,
  `prodQuantity` int(11) NOT NULL,
  `prodPrice` int(11) NOT NULL,
  `prodDescription` varchar(50) DEFAULT NULL,
  `prodCat` varchar(50) NOT NULL,
  PRIMARY KEY (`prodId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table dbims.tbproduct: ~3 rows (approximately)
INSERT INTO `tbproduct` (`prodId`, `prodName`, `prodQuantity`, `prodPrice`, `prodDescription`, `prodCat`) VALUES
	('6456a80a-92c0-4a77-890a-b4465d22fd6f', 'French bread', 40, 2000, 'ou lala wi', 'Bread'),
	('979c4aab-818b-485b-a9f5-3c1a2c1e3fe7', 'Low Fat Milk', 10, 3000, '1% fat content', 'Milk'),
	('a0e96ce5-ea4c-43bd-886b-4ebe68c3bd85', 'white bread', 20, 20000, 'white bread Pan', 'Bread');

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
