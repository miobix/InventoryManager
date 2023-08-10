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

-- Dumping data for table dbims.tbcategory: ~5 rows (approximately)
INSERT INTO `tbcategory` (`catId`, `catName`) VALUES
	('190c783d-e467-45ce-84ef-0508fe890585', 'Cheese'),
	('29b33377-0cb2-481d-9020-6d05f8bb32af', 'Bread'),
	('4c143c7e-c69f-4444-98b9-f0dc170febcd', 'Milk'),
	('81d3dd64-31ef-400e-8cdf-65d8a1cde2de', 'Eggs'),
	('aabb834b-57e3-4f1f-a76a-6e9f4d8d5224', 'Meat');

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

-- Dumping data for table dbims.tbproduct: ~7 rows (approximately)
INSERT INTO `tbproduct` (`prodId`, `prodName`, `prodQuantity`, `prodPrice`, `prodDescription`, `prodCat`) VALUES
	('36bcda71-b9db-45f4-a15d-523a621e7985', 'Pork 100', 198, 2300, 'Pork 100 g', 'Meat'),
	('6456a80a-92c0-4a77-890a-b4465d22fd6f', 'French bread', 37, 2000, 'ou lala wi', 'Bread'),
	('952f21ee-5c63-4ccc-bb05-b15d5f16bae9', 'Pork 500', 295, 6000, 'Pork 500g', 'Meat'),
	('979c4aab-818b-485b-a9f5-3c1a2c1e3fe7', 'Low Fat Milk', 8, 3000, '1% fat content', 'Milk'),
	('a0e96ce5-ea4c-43bd-886b-4ebe68c3bd85', 'white bread', 15, 20000, 'white bread Pan', 'Bread'),
	('d9fe1af7-d4ee-4fc3-9e7c-125c3da28a76', 'Gouda', 200, 2130, 'Gouda cheese', 'Cheese'),
	('f7ccd42a-a137-4e00-8add-6e27eaa82c66', 'Swiss Cheese', 18, 3600, 'Laminated swiss cheese', 'Cheese');

-- Dumping structure for table dbims.tbpurchase
CREATE TABLE IF NOT EXISTS `tbpurchase` (
  `purchId` varchar(50) NOT NULL,
  `purchDate` date NOT NULL,
  `prodId` varchar(50) NOT NULL,
  `userId` varchar(50) NOT NULL,
  `prodQuantity` int(11) NOT NULL,
  `prodPrice` int(11) NOT NULL,
  `purchTotal` int(11) NOT NULL,
  PRIMARY KEY (`purchId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table dbims.tbpurchase: ~10 rows (approximately)
INSERT INTO `tbpurchase` (`purchId`, `purchDate`, `prodId`, `userId`, `prodQuantity`, `prodPrice`, `purchTotal`) VALUES
	('4ded6afb-fba9-4276-89b1-0124eb59f6cc', '2023-08-10', '979c4aab-818b-485b-a9f5-3c1a2c1e3fe7', '379a43b6-ed27-49ac-a1e1-67427816e1e8', 1, 3000, 3000),
	('7b50b6df-bd9b-4073-8438-65e936864fa4', '2023-08-10', '36bcda71-b9db-45f4-a15d-523a621e7985', 'b0a89dc1-49a9-4f26-bd50-8cc64935d815', 2, 2300, 4600),
	('7c6aa121-5373-4cd9-902d-712141634017', '2023-08-09', 'a0e96ce5-ea4c-43bd-886b-4ebe68c3bd85', '379a43b6-ed27-49ac-a1e1-67427816e1e8', 3, 20000, 60000),
	('8f017a6f-bc66-4613-808a-8d599566cc2d', '2023-08-09', '6456a80a-92c0-4a77-890a-b4465d22fd6f', 'e7e5bbfe-26ad-4f64-b468-18c90ad195c2', 2, 2000, 4000),
	('915e8660-27c0-45ef-8f1d-c24a16174fd2', '2023-08-10', 'a0e96ce5-ea4c-43bd-886b-4ebe68c3bd85', 'e7e5bbfe-26ad-4f64-b468-18c90ad195c2', 1, 20000, 20000),
	('9ef179a9-eb4d-42f0-9418-2e2a5ad27594', '2023-08-09', '6456a80a-92c0-4a77-890a-b4465d22fd6f', '379a43b6-ed27-49ac-a1e1-67427816e1e8', 1, 2000, 2000),
	('a172f3f7-36fb-4f53-8f19-ec932d3d7da2', '2023-08-09', '979c4aab-818b-485b-a9f5-3c1a2c1e3fe7', 'e7e5bbfe-26ad-4f64-b468-18c90ad195c2', 1, 3000, 3000),
	('b64a6385-2728-4b39-a9fc-d24298e68781', '2023-08-10', '952f21ee-5c63-4ccc-bb05-b15d5f16bae9', 'b0a89dc1-49a9-4f26-bd50-8cc64935d815', 5, 6000, 30000),
	('eedb5197-9660-42de-b07c-261787ab82ce', '2023-08-10', 'f7ccd42a-a137-4e00-8add-6e27eaa82c66', 'b0a89dc1-49a9-4f26-bd50-8cc64935d815', 2, 3600, 7200),
	('fa973c56-3228-4b28-957f-726ad1a9a451', '2023-08-10', 'a0e96ce5-ea4c-43bd-886b-4ebe68c3bd85', 'e7e5bbfe-26ad-4f64-b468-18c90ad195c2', 1, 20000, 20000);

-- Dumping structure for table dbims.tbuser
CREATE TABLE IF NOT EXISTS `tbuser` (
  `username` varchar(50) NOT NULL,
  `fullname` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `email` varchar(50) NOT NULL,
  `userId` varchar(50) NOT NULL,
  PRIMARY KEY (`userId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table dbims.tbuser: ~3 rows (approximately)
INSERT INTO `tbuser` (`username`, `fullname`, `password`, `email`, `userId`) VALUES
	('admin', 'admin lastname', 'admin', 'admin@admin.test', '379a43b6-ed27-49ac-a1e1-67427816e1e8'),
	('admin12345', 'Cris Adm', 'admin12345', 'admin@swa.cl', 'b0a89dc1-49a9-4f26-bd50-8cc64935d815'),
	('user3', 'best user ever', 'notsafe', '', 'e7e5bbfe-26ad-4f64-b468-18c90ad195c2');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
