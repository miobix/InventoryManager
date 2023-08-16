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
	('36bcda71-b9db-45f4-a15d-523a621e7985', 'Pork 100', 197, 2300, 'Pork 100 g', 'Meat'),
	('6456a80a-92c0-4a77-890a-b4465d22fd6f', 'French bread', 2, 2000, 'ou lala wi', 'Bread'),
	('952f21ee-5c63-4ccc-bb05-b15d5f16bae9', 'Pork 500', 281, 6000, 'Pork 500g', 'Meat'),
	('979c4aab-818b-485b-a9f5-3c1a2c1e3fe7', 'Low Fat Milk', 0, 3000, '1% fat content', 'Milk'),
	('a0e96ce5-ea4c-43bd-886b-4ebe68c3bd85', 'white bread', 7, 20000, 'white bread Pan', 'Bread'),
	('d9fe1af7-d4ee-4fc3-9e7c-125c3da28a76', 'Gouda', 200, 2130, 'Gouda cheese', 'Cheese'),
	('f7ccd42a-a137-4e00-8add-6e27eaa82c66', 'Swiss Cheese', 8, 3600, 'Laminated swiss cheese', 'Cheese');

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

-- Dumping data for table dbims.tbpurchase: ~17 rows (approximately)
INSERT INTO `tbpurchase` (`purchId`, `purchDate`, `prodId`, `userId`, `prodQuantity`, `prodPrice`, `purchTotal`) VALUES
	('2c2c5324-cb7b-4852-8eef-a0f4d031dd47', '2023-08-13', '979c4aab-818b-485b-a9f5-3c1a2c1e3fe7', '379a43b6-ed27-49ac-a1e1-67427816e1e8', 2, 3000, 6000),
	('31491e71-d0d2-44fe-8566-7a5f3a5a9dc6', '2023-08-09', 'a0e96ce5-ea4c-43bd-886b-4ebe68c3bd85', 'e7e5bbfe-26ad-4f64-b468-18c90ad195c2', 3, 20000, 60000),
	('3f8b04dd-3bdb-4e46-af75-081fd86c3152', '2023-08-09', '36bcda71-b9db-45f4-a15d-523a621e7985', 'b0a89dc1-49a9-4f26-bd50-8cc64935d815', 1, 2300, 2300),
	('4ded6afb-fba9-4276-89b1-0124eb59f6cc', '2023-08-10', '979c4aab-818b-485b-a9f5-3c1a2c1e3fe7', '379a43b6-ed27-49ac-a1e1-67427816e1e8', 1, 3000, 3000),
	('4f26b7bc-39fe-4d8f-9fc2-2d8ac210b9c0', '2023-08-09', '952f21ee-5c63-4ccc-bb05-b15d5f16bae9', '8879024b-b179-426d-849d-1c2428922255', 3, 6000, 18000),
	('51247baf-7516-4c09-8a89-4e0cca77b95b', '2023-08-09', '952f21ee-5c63-4ccc-bb05-b15d5f16bae9', 'e7e5bbfe-26ad-4f64-b468-18c90ad195c2', 3, 6000, 18000),
	('70f1c1c0-34c0-4d2b-98bc-c969a65d66fe', '2023-08-09', '952f21ee-5c63-4ccc-bb05-b15d5f16bae9', 'b0a89dc1-49a9-4f26-bd50-8cc64935d815', 2, 6000, 12000),
	('780d461f-eb55-4a57-b0b8-2ff84c6cb4a8', '2023-08-15', 'f7ccd42a-a137-4e00-8add-6e27eaa82c66', '8879024b-b179-426d-849d-1c2428922255', 9, 3600, 32400),
	('7b50b6df-bd9b-4073-8438-65e936864fa4', '2023-08-10', '36bcda71-b9db-45f4-a15d-523a621e7985', 'b0a89dc1-49a9-4f26-bd50-8cc64935d815', 2, 2300, 4600),
	('7c6aa121-5373-4cd9-902d-712141634017', '2023-08-09', 'a0e96ce5-ea4c-43bd-886b-4ebe68c3bd85', '379a43b6-ed27-49ac-a1e1-67427816e1e8', 4, 20000, 80000),
	('7f84e32c-bf7f-4c27-9300-fce5d99feae6', '2023-08-09', 'f7ccd42a-a137-4e00-8add-6e27eaa82c66', '379a43b6-ed27-49ac-a1e1-67427816e1e8', 3, 3600, 10800),
	('8dfdf16f-683f-499f-8423-19167c91de44', '2023-08-12', 'a0e96ce5-ea4c-43bd-886b-4ebe68c3bd85', 'b0a89dc1-49a9-4f26-bd50-8cc64935d815', 15, 20000, 300000),
	('8e4f610b-3665-476d-92c1-5c8bddb3919c', '2023-08-09', '952f21ee-5c63-4ccc-bb05-b15d5f16bae9', 'b0a89dc1-49a9-4f26-bd50-8cc64935d815', 2, 6000, 12000),
	('8f017a6f-bc66-4613-808a-8d599566cc2d', '2023-08-09', '6456a80a-92c0-4a77-890a-b4465d22fd6f', 'e7e5bbfe-26ad-4f64-b468-18c90ad195c2', 4, 2000, 8000),
	('a172f3f7-36fb-4f53-8f19-ec932d3d7da2', '2023-08-09', '979c4aab-818b-485b-a9f5-3c1a2c1e3fe7', 'e7e5bbfe-26ad-4f64-b468-18c90ad195c2', 1, 3000, 3000),
	('b64a6385-2728-4b39-a9fc-d24298e68781', '2023-08-10', '952f21ee-5c63-4ccc-bb05-b15d5f16bae9', 'b0a89dc1-49a9-4f26-bd50-8cc64935d815', 4, 6000, 24000),
	('bd8ebbba-8803-4ecc-a2b7-96a1093c0308', '2023-08-09', '6456a80a-92c0-4a77-890a-b4465d22fd6f', '8bb4d337-eedd-4c47-ba3e-0a4aff01a693', 36, 2000, 72000),
	('cc6c2940-3c7f-4e08-893e-90c416171f91', '2023-08-13', 'a0e96ce5-ea4c-43bd-886b-4ebe68c3bd85', 'e7e5bbfe-26ad-4f64-b468-18c90ad195c2', 2, 20000, 40000),
	('de3ffd13-6cd7-4a18-9097-7c1cca9b062c', '2023-08-14', '952f21ee-5c63-4ccc-bb05-b15d5f16bae9', '8879024b-b179-426d-849d-1c2428922255', 5, 6000, 30000),
	('e334a63f-6b52-4a25-866c-716b4e60ef89', '2023-08-09', '979c4aab-818b-485b-a9f5-3c1a2c1e3fe7', 'e7e5bbfe-26ad-4f64-b468-18c90ad195c2', 3, 3000, 9000),
	('e82813fd-ff4d-4836-a124-105cf51677e5', '2023-08-09', '952f21ee-5c63-4ccc-bb05-b15d5f16bae9', 'b0a89dc1-49a9-4f26-bd50-8cc64935d815', 1, 6000, 6000),
	('eaa5518b-bc75-46cf-be27-cea8f4cbed4b', '2023-08-09', 'a0e96ce5-ea4c-43bd-886b-4ebe68c3bd85', 'e7e5bbfe-26ad-4f64-b468-18c90ad195c2', 1, 20000, 20000),
	('eedb5197-9660-42de-b07c-261787ab82ce', '2023-08-10', 'f7ccd42a-a137-4e00-8add-6e27eaa82c66', 'b0a89dc1-49a9-4f26-bd50-8cc64935d815', 2, 3600, 7200),
	('fa973c56-3228-4b28-957f-726ad1a9a451', '2023-08-10', 'a0e96ce5-ea4c-43bd-886b-4ebe68c3bd85', 'e7e5bbfe-26ad-4f64-b468-18c90ad195c2', 4, 20000, 80000),
	('ff790e56-b0a0-4895-a601-73ca16fa54c7', '2023-08-15', 'a0e96ce5-ea4c-43bd-886b-4ebe68c3bd85', '8bb4d337-eedd-4c47-ba3e-0a4aff01a693', 4, 20000, 80000);

-- Dumping structure for table dbims.tbuser
CREATE TABLE IF NOT EXISTS `tbuser` (
  `username` varchar(50) NOT NULL,
  `fullname` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `email` varchar(50) NOT NULL,
  `userId` varchar(50) NOT NULL,
  PRIMARY KEY (`userId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table dbims.tbuser: ~6 rows (approximately)
INSERT INTO `tbuser` (`username`, `fullname`, `password`, `email`, `userId`) VALUES
	('', '', '', 'empty@empty.com', '2508f2ce-6a29-4396-8937-9b52c7626dec'),
	('admin', 'Best Admin', 'admin', 'admin@admin.test', '379a43b6-ed27-49ac-a1e1-67427816e1e8'),
	('swa', 'sasd', 'sdasd', 'asdasd@asdasd.co', '8879024b-b179-426d-849d-1c2428922255'),
	('miobix', 'Cristian', 'admin', 'swaaaa@swa.com', '8bb4d337-eedd-4c47-ba3e-0a4aff01a693'),
	('admin12345', 'Cris Adm', 'admin12345', 'admin@swa.cl', 'b0a89dc1-49a9-4f26-bd50-8cc64935d815'),
	('user3', 'best user ever', 'notsafe', '', 'e7e5bbfe-26ad-4f64-b468-18c90ad195c2');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
