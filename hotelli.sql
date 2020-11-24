-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 24, 2020 at 08:02 PM
-- Server version: 10.4.16-MariaDB
-- PHP Version: 7.4.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotelli`
--

-- --------------------------------------------------------

--
-- Table structure for table `asiakkaat`
--

CREATE TABLE `asiakkaat` (
  `kayttajanimi` int(15) NOT NULL,
  `Etunimi` varchar(25) NOT NULL,
  `Sukunimi` varchar(35) NOT NULL,
  `Lahiosoite` varchar(50) NOT NULL,
  `Postinumero` varchar(10) NOT NULL,
  `Postitoimipaikka` varchar(25) NOT NULL,
  `Salasana` varchar(35) NOT NULL,
  `KayttajaID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `asiakkaat`
--

INSERT INTO `asiakkaat` (`kayttajanimi`, `Etunimi`, `Sukunimi`, `Lahiosoite`, `Postinumero`, `Postitoimipaikka`, `Salasana`, `KayttajaID`) VALUES
(1, 'Jaska', 'Parantainen', 'Velhokatu 6 a 1', '97600', 'Rovaniemi', 'xcxcRT6!2@', 1),
(2, 'JyriPekka', 'Lindroos', 'Metsurinkatu 38', '11130', 'Riihimäki', '1Ftm2Fts!', 2),
(3, 'Sirpa', 'Lindroos', 'Metsurinkatu 38', '11130', 'Riihimäki', 'Teittine', 3),
(4, 'Tytti', 'Tiivanainen', 'Torikatu 23 b 34', '20100', 'Turku', 'xcxcRT6!2@', 4);

-- --------------------------------------------------------

--
-- Table structure for table `huoneet`
--

CREATE TABLE `huoneet` (
  `Huoneen_numero` int(11) NOT NULL,
  `Huonetyyppi` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `huonekategoria`
--

CREATE TABLE `huonekategoria` (
  `kategoriaId` int(11) NOT NULL,
  `Huonetyyppi` varchar(15) NOT NULL,
  `Hinta` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `huonekategoria`
--

INSERT INTO `huonekategoria` (`kategoriaId`, `Huonetyyppi`, `Hinta`) VALUES
(1, 'Yhden hengen', '120'),
(2, 'Kahden hengen', '90'),
(3, 'Perhe', '150'),
(4, 'Sviitti', '300');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  ADD PRIMARY KEY (`kayttajanimi`);

--
-- Indexes for table `huoneet`
--
ALTER TABLE `huoneet`
  ADD PRIMARY KEY (`Huoneen_numero`),
  ADD KEY `Huonetyyppi` (`Huonetyyppi`);

--
-- Indexes for table `huonekategoria`
--
ALTER TABLE `huonekategoria`
  ADD PRIMARY KEY (`kategoriaId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  MODIFY `kayttajanimi` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `huonekategoria`
--
ALTER TABLE `huonekategoria`
  MODIFY `kategoriaId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `huoneet`
--
ALTER TABLE `huoneet`
  ADD CONSTRAINT `huoneet_ibfk_1` FOREIGN KEY (`Huonetyyppi`) REFERENCES `huonekategoria` (`kategoriaId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
