-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: 2019 年 6 月 04 日 23:45
-- サーバのバージョン： 10.1.38-MariaDB
-- PHP Version: 7.2.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `techtest`
--

-- --------------------------------------------------------

--
-- テーブルの構造 `finalranking`
--

CREATE TABLE `finalranking` (
  `id` int(11) NOT NULL COMMENT 'AUTO_INCREMENT',
  `Score` int(50) NOT NULL,
  `Date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=tis620 COLLATE=tis620_bin;

--
-- テーブルのデータのダンプ `finalranking`
--

INSERT INTO `finalranking` (`id`, `Score`, `Date`) VALUES
(1, 3, '2019-05-23 01:21:18'),
(2, 7, '2019-05-23 01:21:43'),
(3, 4, '2019-05-23 01:22:16'),
(4, 7, '2019-05-23 02:26:39');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `finalranking`
--
ALTER TABLE `finalranking`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `finalranking`
--
ALTER TABLE `finalranking`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'AUTO_INCREMENT', AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
