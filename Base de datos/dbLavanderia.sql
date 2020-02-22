/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 5.5.5-10.1.30-MariaDB : Database - dblavanderia
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`dblavanderia` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `dblavanderia`;

/*Table structure for table `clientes` */

DROP TABLE IF EXISTS `clientes`;

CREATE TABLE `clientes` (
  `numCliente` INT(10) NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(50) DEFAULT NULL,
  `apellidoPaterno` VARCHAR(50) DEFAULT NULL,
  `apellidoMaterno` VARCHAR(50) DEFAULT NULL,
  `telefono` VARCHAR(15) DEFAULT NULL,
  `status` BOOLEAN NULL,
  PRIMARY KEY (`numCliente`)
) ENGINE=INNODB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `clientes` */

INSERT  INTO `clientes`(`numCliente`,`nombre`,`apellidoPaterno`, `apellidoMaterno`,`telefono`, `status`) VALUES (1,'Ana Gabriela','Pérez', 'Tiznado','6692456878', 1),(2,'Alan Josué','Barraza', 'Osuna','6697386541', 0),(3,'Gloria','Trevi', 'Moteros','6698784562', 1);

/*Table structure for table `detalleservicio` */

DROP TABLE IF EXISTS `detalleservicio`;

CREATE TABLE `detalleservicio` (
  `numDetalleSer` INT(10) NOT NULL AUTO_INCREMENT,
  `cantidad` INT(10) DEFAULT NULL,
  `totalPagar` FLOAT DEFAULT NULL,
  `numServicio` INT(10) DEFAULT NULL,
  `numVentaServicio` INT(10) DEFAULT NULL,
  PRIMARY KEY (`numDetalleSer`),
  KEY `numServicio` (`numServicio`),
  KEY `numVentaServicio` (`numVentaServicio`),
  CONSTRAINT `detalleservicio_ibfk_1` FOREIGN KEY (`numServicio`) REFERENCES `servicios` (`numServicio`),
  CONSTRAINT `detalleservicio_ibfk_2` FOREIGN KEY (`numVentaServicio`) REFERENCES `ventaservicio` (`numVentaServicio`)
) ENGINE=INNODB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `detalleservicio` */

INSERT  INTO `detalleservicio`(`numDetalleSer`,`cantidad`,`totalPagar`,`numServicio`, `numVentaServicio`) VALUES (1,1,16.5,1, 1),(2,3,25.5,2, 2);

/*Table structure for table `empleados` */

DROP TABLE IF EXISTS `empleados`;

CREATE TABLE `empleados` (
  `numEmpleado` INT(10) NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(50) DEFAULT NULL,
  `apellidoPaterno` VARCHAR(50) DEFAULT NULL,
  `apellidoMaterno` VARCHAR(50) DEFAULT NULL,
  `telefono` VARCHAR(15) DEFAULT NULL,
  `direccion` VARCHAR(50) DEFAULT NULL,
  `status` BOOLEAN NULL,
  PRIMARY KEY (`numEmpleado`)
) ENGINE=INNODB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `empleados` */

INSERT  INTO `empleados`(`numEmpleado`,`nombre`,`apellidoPaterno`, `apellidoMaterno`,`telefono`,`direccion`, `status`) VALUES (1,'Juana Lacu','Bana', 'Carrillo','9852710','Av. Insurgentes #563', 1),(2,'Elvio','Lando', 'Ando','9802333','Av. Colosio #8561', 1),(3,'Alma Marcera','Fuerte', 'Rico','9551536',NULL, 1);

/*Table structure for table `servicios` */

DROP TABLE IF EXISTS `servicios`;

CREATE TABLE `servicios` (
  `numServicio` INT(10) NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(30) DEFAULT NULL,
  `formaCobro` VARCHAR(20) DEFAULT NULL,
  `precio` FLOAT DEFAULT NULL,
  `status` BOOLEAN NULL,
  PRIMARY KEY (`numServicio`)
) ENGINE=INNODB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `servicios` */

INSERT  INTO `servicios`(`numServicio`,`nombre`,`formaCobro`,`precio`, `status`) VALUES (1,'Lavado','kilogramo',16.5, 1),(2,'Planchado','pieza',8.5, 1),(3,'Tintorería','pieza',30, 1);

/*Table structure for table `usuario` */

DROP TABLE IF EXISTS `usuario`;

CREATE TABLE `usuario` (
  `numUsuario` INT(10) NOT NULL AUTO_INCREMENT,
  `nombreUsuario` VARCHAR(50) DEFAULT NULL,
  `contraseña` VARCHAR(50) DEFAULT NULL,
  `tipoUsuario` VARCHAR(20) DEFAULT NULL,
  `status` BOOLEAN NULL,
  `numEmpleado` INT(10) DEFAULT NULL,
  PRIMARY KEY (`numUsuario`),
  KEY `numEmpleado` (`numEmpleado`),
  CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`numEmpleado`) REFERENCES `empleados` (`numEmpleado`)
) ENGINE=INNODB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `usuario` */

INSERT  INTO `usuario`(`numUsuario`,`nombreUsuario`,`contraseña`,`tipoUsuario`, `status`,`numEmpleado`) VALUES (1,'AlamaMar','elsapo','Usuario',0,3),(2,'ElvioLand','tutia','Administrador',0,2),(3,'Juanita19','amocuba','Usuario',0,1);

/*Table structure for table `ventaservicio` */

DROP TABLE IF EXISTS `ventaservicio`;

CREATE TABLE `ventaservicio` (
  `numVentaServicio` INT(10) NOT NULL AUTO_INCREMENT,
  `fecha` DATE DEFAULT NULL,
  `importe` FLOAT DEFAULT NULL,
  `status` BOOLEAN DEFAULT NULL,
  `numUsuario` INT(10) DEFAULT NULL,
  `numCliente` INT(10) DEFAULT NULL,
  PRIMARY KEY (`numVentaServicio`),
  KEY `numCliente` (`numCliente`),
  KEY `ventaservicio_ibfk_1` (`numUsuario`),
  CONSTRAINT `ventaservicio_ibfk_1` FOREIGN KEY (`numUsuario`) REFERENCES `usuario` (`numUsuario`),
  CONSTRAINT `ventaservicio_ibfk_2` FOREIGN KEY (`numCliente`) REFERENCES `clientes` (`numCliente`)
) ENGINE=INNODB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Data for the table `ventaservicio` */

INSERT  INTO `ventaservicio`(`numVentaServicio`,`fecha`,`importe`,`status`,`numUsuario`,`numCliente`) VALUES (1,'2019-12-04',102,0,2,2),(2,NULL,NULL,NULL,NULL,NULL);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
