/*
SQLyog Ultimate v10.42 
MySQL - 5.6.21-log : Database - sim_penjualan
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
/*Table structure for table `barang` */

DROP TABLE IF EXISTS `barang`;

CREATE TABLE `barang` (
  `kd_barang` char(7) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `harga` int(11) DEFAULT NULL,
  `satuan` varchar(20) DEFAULT NULL,
  `jenis` varchar(30) DEFAULT NULL,
  `stok` int(11) DEFAULT NULL,
  PRIMARY KEY (`kd_barang`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `barang` */

insert  into `barang`(`kd_barang`,`nama`,`harga`,`satuan`,`jenis`,`stok`) values ('BRG0002','Kertas',1000,'PCS','Kertas A4',97),('BRG0003','Mug A',4000,'PCS','Mug',98);

/*Table structure for table `detail_penjualan` */

DROP TABLE IF EXISTS `detail_penjualan`;

CREATE TABLE `detail_penjualan` (
  `kd_detail_penjualan` int(11) NOT NULL AUTO_INCREMENT,
  `no_faktur` varchar(19) DEFAULT NULL,
  `kd_barang` char(7) DEFAULT NULL,
  `harga` int(11) DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  PRIMARY KEY (`kd_detail_penjualan`),
  KEY `no_faktur` (`no_faktur`),
  KEY `kd_barang` (`kd_barang`),
  CONSTRAINT `detail_penjualan_ibfk_1` FOREIGN KEY (`no_faktur`) REFERENCES `penjualan` (`no_faktur`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `detail_penjualan_ibfk_2` FOREIGN KEY (`kd_barang`) REFERENCES `barang` (`kd_barang`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

/*Data for the table `detail_penjualan` */

insert  into `detail_penjualan`(`kd_detail_penjualan`,`no_faktur`,`kd_barang`,`harga`,`jumlah`,`total`) values (1,'TRJ20151105-0000001','BRG0002',1000,0,2000),(2,'TRJ20151105-0000002','BRG0002',1000,0,1000),(3,'TRJ20151105-0000002','BRG0002',1000,0,2000),(4,'TRJ20151106-0000003','BRG0002',1000,2,2000),(5,'TRJ20151106-0000004','BRG0002',1000,3,3000),(6,'TRJ20151106-0000004','BRG0003',4000,2,8000);

/*Table structure for table `karyawan` */

DROP TABLE IF EXISTS `karyawan`;

CREATE TABLE `karyawan` (
  `kd_karyawan` char(7) NOT NULL,
  `nama` varchar(40) DEFAULT NULL,
  `alamat` text,
  `no_telepon` varchar(20) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `hak_akses` varchar(20) DEFAULT NULL,
  `username` varchar(30) DEFAULT NULL,
  `password` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`kd_karyawan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `karyawan` */

insert  into `karyawan`(`kd_karyawan`,`nama`,`alamat`,`no_telepon`,`email`,`hak_akses`,`username`,`password`) values ('KRY0001','Dwi Randy Herdinanto','lama	 edit',NULL,'fw@gmail.com edit','Gudang','edit','root edit'),('KRY0004','Dwi Randy','Bandar Lampung','08999080288','nanda@yahoo.com','Gudang','nanda','nanda');

/*Table structure for table `konsumen` */

DROP TABLE IF EXISTS `konsumen`;

CREATE TABLE `konsumen` (
  `kd_konsumen` char(7) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `alamat` text,
  `no_telepon` varchar(20) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`kd_konsumen`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `konsumen` */

insert  into `konsumen`(`kd_konsumen`,`nama`,`alamat`,`no_telepon`,`email`) values ('KSM0001','Randy edit','bandar jaya bara editt','08999080222','randy@yahoo.co.iddd'),('KSM0002','Eko Hendro','bandar jaya','089898989','eko@yahoo.co.id');

/*Table structure for table `pembayaran` */

DROP TABLE IF EXISTS `pembayaran`;

CREATE TABLE `pembayaran` (
  `kd_pembayaran` int(11) NOT NULL AUTO_INCREMENT,
  `no_faktur` varchar(19) DEFAULT NULL,
  `tgl` datetime DEFAULT NULL,
  `kd_karyawan` char(7) DEFAULT NULL,
  `total_bayar` int(11) DEFAULT NULL,
  `dibayar` int(11) DEFAULT NULL,
  `kembali` int(11) DEFAULT NULL,
  PRIMARY KEY (`kd_pembayaran`),
  KEY `no_faktur` (`no_faktur`),
  KEY `kd_karyawan` (`kd_karyawan`),
  CONSTRAINT `pembayaran_ibfk_1` FOREIGN KEY (`no_faktur`) REFERENCES `penjualan` (`no_faktur`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `pembayaran_ibfk_2` FOREIGN KEY (`kd_karyawan`) REFERENCES `karyawan` (`kd_karyawan`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `pembayaran_ibfk_3` FOREIGN KEY (`kd_karyawan`) REFERENCES `karyawan` (`kd_karyawan`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `pembayaran_ibfk_4` FOREIGN KEY (`kd_karyawan`) REFERENCES `karyawan` (`kd_karyawan`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

/*Data for the table `pembayaran` */

insert  into `pembayaran`(`kd_pembayaran`,`no_faktur`,`tgl`,`kd_karyawan`,`total_bayar`,`dibayar`,`kembali`) values (1,'TRJ20151105-0000001','2015-11-07 13:01:19','KRY0001',2000,5000,3000),(2,'TRJ20151105-0000002','2015-11-08 16:12:47','KRY0001',3000,4000,1000),(3,'TRJ20151106-0000003','2015-11-06 14:30:03','KRY0001',2000,4000,2000),(4,'TRJ20151106-0000004','2015-11-06 14:46:02','KRY0001',11000,20000,9000);

/*Table structure for table `penjualan` */

DROP TABLE IF EXISTS `penjualan`;

CREATE TABLE `penjualan` (
  `no_faktur` varchar(19) NOT NULL,
  `kd_konsumen` char(7) DEFAULT NULL,
  `kd_karyawan` char(7) DEFAULT NULL,
  `tgl` datetime DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  `status` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`no_faktur`),
  KEY `kd_konsumen` (`kd_konsumen`),
  KEY `kd_karyawan` (`kd_karyawan`),
  CONSTRAINT `penjualan_ibfk_1` FOREIGN KEY (`kd_konsumen`) REFERENCES `konsumen` (`kd_konsumen`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `penjualan_ibfk_2` FOREIGN KEY (`kd_karyawan`) REFERENCES `karyawan` (`kd_karyawan`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `penjualan` */

insert  into `penjualan`(`no_faktur`,`kd_konsumen`,`kd_karyawan`,`tgl`,`total`,`status`) values ('TRJ20151105-0000001','KSM0001','KRY0001','2015-11-05 13:01:19',2000,1),('TRJ20151105-0000002','KSM0001','KRY0001','2015-11-05 16:12:47',3000,1),('TRJ20151106-0000003','KSM0002','KRY0001','2015-11-06 14:30:03',2000,1),('TRJ20151106-0000004','KSM0001','KRY0001','2015-11-06 14:46:02',11000,1);

/* Trigger structure for table `pembayaran` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `pembayaran_ai` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'root'@'localhost' */ /*!50003 TRIGGER `pembayaran_ai` AFTER INSERT ON `pembayaran` FOR EACH ROW BEGIN
	update penjualan set status = 1 where no_faktur=new.no_faktur;
    END */$$


DELIMITER ;

/* Procedure structure for procedure `penomoran` */

/*!50003 DROP PROCEDURE IF EXISTS  `penomoran` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `penomoran`(in kode varchar(5), in tabel varchar(20), in pk varchar(20))
BEGIN
	set @no_urut = '';
	set @query = concat_ws('','select right(',pk,',4) as penomoran into @no_urut from ',tabel,' where left(',pk,',3)="',kode,'" order by ',pk,' desc limit 0,1');
	
	prepare stmt from @query;
	execute stmt;
	deallocate prepare stmt;
	if @no_urut is null then
		set @no_urut = concat(kode,'0001');
	else
		set @no_urut = concat(kode, right(concat('0000', @no_urut + 1), 4));
	end if;
	select @no_urut;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `penomoran_transaksi` */

/*!50003 DROP PROCEDURE IF EXISTS  `penomoran_transaksi` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `penomoran_transaksi`(IN kode VARCHAR(4), tabel VARCHAR(20), pk VARCHAR(20))
BEGIN
	SET @no_urut = '';
	SET @hitung = '';
	SET @jumlah = LENGTH(kode);
	SET @query = CONCAT_WS('','select right(',pk,',7) as penomoran into @no_urut from ',tabel,' where left(',pk,',',@jumlah,')="',kode,'" order by ',pk,' desc limit 0,1');
	
	PREPARE stmt FROM @query;
	EXECUTE stmt;
	DEALLOCATE PREPARE stmt;
	IF @no_urut IS NULL THEN
		SET @no_urut = CONCAT(kode,DATE_FORMAT(NOW(),'%Y%m%d'),"-0000001");
	ELSE 
		SET @hitung = CONCAT("00000000",@no_urut + 1);
		SET @no_urut = CONCAT(kode,DATE_FORMAT(NOW(),'%Y%m%d'),'-',RIGHT(@hitung,7));
	END IF;
	SELECT @no_urut;
END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
