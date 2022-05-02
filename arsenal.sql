-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: May 02, 2022 at 11:49 AM
-- Server version: 5.7.36
-- PHP Version: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `arsenal`
--

-- --------------------------------------------------------

--
-- Table structure for table `lot`
--

DROP TABLE IF EXISTS `lot`;
CREATE TABLE IF NOT EXISTS `lot` (
  `id` int(4) NOT NULL AUTO_INCREMENT,
  `quantity` int(4) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=28 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `lot`
--

INSERT INTO `lot` (`id`, `quantity`) VALUES
(1, 5),
(2, 437),
(3, 0),
(4, 0),
(5, 0),
(6, 0),
(7, 0),
(8, 0),
(9, 0),
(10, 0),
(11, 0),
(12, 0),
(13, 0),
(14, 0),
(15, 0),
(16, 0),
(17, 0),
(18, 0),
(19, 0),
(20, 0),
(21, 0),
(22, 0),
(23, 0),
(24, 0),
(25, 0),
(26, 0),
(27, 0);

-- --------------------------------------------------------

--
-- Table structure for table `lots_date`
--

DROP TABLE IF EXISTS `lots_date`;
CREATE TABLE IF NOT EXISTS `lots_date` (
  `idLotDate` int(11) NOT NULL AUTO_INCREMENT,
  `idLot` int(4) NOT NULL,
  `winningDate` datetime NOT NULL,
  `winningTime` time NOT NULL,
  PRIMARY KEY (`idLotDate`),
  KEY `fk_lot` (`idLot`),
  KEY `fk_date_marche` (`winningDate`)
) ENGINE=MyISAM AUTO_INCREMENT=22 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `lots_date`
--

INSERT INTO `lots_date` (`idLotDate`, `idLot`, `winningDate`, `winningTime`) VALUES
(1, 2, '2012-09-14 00:00:00', '10:49:00'),
(2, 2, '2012-09-14 00:00:00', '10:49:00'),
(3, 2, '2012-09-14 00:00:00', '10:51:00'),
(4, 2, '2012-09-14 00:00:00', '11:05:00'),
(5, 2, '2012-09-14 00:00:00', '11:14:00'),
(6, 2, '2012-09-14 00:00:00', '11:23:00'),
(7, 2, '2012-09-14 00:00:00', '11:48:00'),
(8, 2, '2012-09-14 00:00:00', '11:51:00'),
(9, 2, '2012-09-14 00:00:00', '12:05:00'),
(10, 2, '2012-09-14 00:00:00', '12:32:00'),
(11, 2, '2012-09-14 00:00:00', '12:35:00'),
(12, 2, '2012-09-14 00:00:00', '12:48:00'),
(13, 2, '2012-09-14 00:00:00', '13:01:00'),
(14, 2, '2012-09-14 00:00:00', '13:17:00'),
(15, 2, '2012-09-14 00:00:00', '13:59:00'),
(16, 2, '2012-09-14 00:00:00', '14:00:00'),
(17, 2, '2012-09-14 00:00:00', '14:18:00'),
(18, 2, '2012-09-15 00:00:00', '10:27:00'),
(19, 2, '2012-09-14 00:00:00', '10:37:00'),
(20, 2, '2012-09-14 00:00:00', '11:08:00'),
(21, 2, '2012-09-14 00:00:00', '11:27:00');

-- --------------------------------------------------------

--
-- Table structure for table `winnings_history`
--

DROP TABLE IF EXISTS `winnings_history`;
CREATE TABLE IF NOT EXISTS `winnings_history` (
  `date` datetime NOT NULL,
  `players` int(5) DEFAULT NULL,
  `lotsWon` int(5) DEFAULT NULL,
  PRIMARY KEY (`date`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `winnings_history`
--

INSERT INTO `winnings_history` (`date`, `players`, `lotsWon`) VALUES
('2012-09-13 00:00:00', 0, 0),
('2012-09-14 00:00:00', 249, 45),
('2012-09-15 00:00:00', 1273, 44),
('2012-09-16 00:00:00', 1026, 44),
('2012-09-17 00:00:00', 513, 46),
('2012-09-18 00:00:00', 768, 42),
('2012-09-19 00:00:00', 741, 45),
('2012-09-20 00:00:00', 804, 45),
('2012-09-21 00:00:00', 957, 47),
('2012-09-22 00:00:00', 1214, 39),
('2012-09-23 00:00:00', 859, 45);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
