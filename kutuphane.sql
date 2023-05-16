-- --------------------------------------------------------
-- Sunucu:                       127.0.0.1
-- Sunucu sürümü:                8.0.21 - MySQL Community Server - GPL
-- Sunucu İşletim Sistemi:       Win64
-- HeidiSQL Sürüm:               11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- kutuphane için veritabanı yapısı dökülüyor
DROP DATABASE IF EXISTS `kutuphane`;
CREATE DATABASE IF NOT EXISTS `kutuphane` /*!40100 DEFAULT CHARACTER SET latin5 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `kutuphane`;

-- tablo yapısı dökülüyor kutuphane.kitaplar
DROP TABLE IF EXISTS `kitaplar`;
CREATE TABLE IF NOT EXISTS `kitaplar` (
  `kitap_id` int NOT NULL AUTO_INCREMENT,
  `tur_id` tinyint NOT NULL,
  `kitap_adi` varchar(40) DEFAULT NULL,
  `yazar` varchar(40) DEFAULT NULL,
  `yayinevi` varchar(40) DEFAULT NULL,
  `sayfa_sayisi` smallint NOT NULL,
  PRIMARY KEY (`kitap_id`),
  KEY `FK_kitaplar_kitap_turleri` (`tur_id`),
  CONSTRAINT `FK_kitaplar_kitap_turleri` FOREIGN KEY (`tur_id`) REFERENCES `kitap_turleri` (`tur_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- kutuphane.kitaplar: ~0 rows (yaklaşık) tablosu için veriler indiriliyor
DELETE FROM `kitaplar`;
/*!40000 ALTER TABLE `kitaplar` DISABLE KEYS */;
/*!40000 ALTER TABLE `kitaplar` ENABLE KEYS */;

-- tablo yapısı dökülüyor kutuphane.kitap_turleri
DROP TABLE IF EXISTS `kitap_turleri`;
CREATE TABLE IF NOT EXISTS `kitap_turleri` (
  `tur_id` tinyint NOT NULL AUTO_INCREMENT,
  `tur_adi` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`tur_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- kutuphane.kitap_turleri: ~0 rows (yaklaşık) tablosu için veriler indiriliyor
DELETE FROM `kitap_turleri`;
/*!40000 ALTER TABLE `kitap_turleri` DISABLE KEYS */;
/*!40000 ALTER TABLE `kitap_turleri` ENABLE KEYS */;

-- tablo yapısı dökülüyor kutuphane.odunc_kitaplar
DROP TABLE IF EXISTS `odunc_kitaplar`;
CREATE TABLE IF NOT EXISTS `odunc_kitaplar` (
  `ogr_no` int NOT NULL AUTO_INCREMENT,
  `kitap_id` int DEFAULT NULL,
  `verilis_tarihi` date DEFAULT NULL,
  `teslim_tarihi` date DEFAULT NULL,
  `aciklama` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ogr_no`),
  KEY `FK_odunc_kitaplar_kitaplar` (`kitap_id`),
  CONSTRAINT `FK_odunc_kitaplar_kitaplar` FOREIGN KEY (`kitap_id`) REFERENCES `kitaplar` (`kitap_id`),
  CONSTRAINT `FK_odunc_kitaplar_ogrenciler` FOREIGN KEY (`ogr_no`) REFERENCES `ogrenciler` (`ogrenci_no`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- kutuphane.odunc_kitaplar: ~0 rows (yaklaşık) tablosu için veriler indiriliyor
DELETE FROM `odunc_kitaplar`;
/*!40000 ALTER TABLE `odunc_kitaplar` DISABLE KEYS */;
/*!40000 ALTER TABLE `odunc_kitaplar` ENABLE KEYS */;

-- tablo yapısı dökülüyor kutuphane.ogrenciler
DROP TABLE IF EXISTS `ogrenciler`;
CREATE TABLE IF NOT EXISTS `ogrenciler` (
  `ogrenci_no` int NOT NULL,
  `ad` varchar(20) DEFAULT NULL,
  `soyad` varchar(20) DEFAULT NULL,
  `sinif` tinyint DEFAULT NULL,
  `cinsiyet` varchar(7) DEFAULT NULL,
  `telefon` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`ogrenci_no`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- kutuphane.ogrenciler: ~2 rows (yaklaşık) tablosu için veriler indiriliyor
DELETE FROM `ogrenciler`;
/*!40000 ALTER TABLE `ogrenciler` DISABLE KEYS */;
INSERT INTO `ogrenciler` (`ogrenci_no`, `ad`, `soyad`, `sinif`, `cinsiyet`, `telefon`) VALUES
	(4548, 'hatice', 'demir', 9, 'Kız', '888787787'),
	(123123, 'qweq', 'asd', 10, 'Kız', '3423423');
/*!40000 ALTER TABLE `ogrenciler` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
