-- MySQL dump 10.13  Distrib 5.6.22, for Win64 (x86_64)
--
-- Host: localhost    Database: solafide_v6
-- ------------------------------------------------------
-- Server version	5.6.22-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tb_client_montapolice`
--

DROP TABLE IF EXISTS `tb_client_montapolice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_client_montapolice` (
  `id_client_MontApolice` int(11) NOT NULL AUTO_INCREMENT,
  `tb_MontagemApolice_id_MontagemApolice` int(11) DEFAULT NULL,
  `cod_cliente` int(11) DEFAULT NULL,
  `nome_cliente` varchar(75) DEFAULT NULL,
  `tb_Dados_Veiculo_id_Dados_Veiculo` int(11) DEFAULT NULL,
  `modelo` varchar(30) DEFAULT NULL,
  `fabricante` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_client_MontApolice`),
  KEY `fk_tb_client_orcamento_tb_Dados_Veiculo1_idx` (`tb_Dados_Veiculo_id_Dados_Veiculo`),
  KEY `fk_tb_client_orcamento_tb_MontagemApolice1_idx` (`tb_MontagemApolice_id_MontagemApolice`),
  CONSTRAINT `fk_tb_client_orcamento_tb_Dados_Veiculo1` FOREIGN KEY (`tb_Dados_Veiculo_id_Dados_Veiculo`) REFERENCES `tb_dados_veiculo` (`id_Dados_Veiculo`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_client_orcamento_tb_MontagemApolice1` FOREIGN KEY (`tb_MontagemApolice_id_MontagemApolice`) REFERENCES `tb_montagemapolice` (`id_MontagemApolice`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_client_montapolice`
--

LOCK TABLES `tb_client_montapolice` WRITE;
/*!40000 ALTER TABLE `tb_client_montapolice` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_client_montapolice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_client_sinistro`
--

DROP TABLE IF EXISTS `tb_client_sinistro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_client_sinistro` (
  `id_client_sinistro` int(11) NOT NULL AUTO_INCREMENT,
  `tb_Sinistro_id_sinistro` int(11) DEFAULT NULL,
  `cod_cliente` int(11) DEFAULT NULL,
  `nome_cliente` varchar(45) DEFAULT NULL,
  `tb_Dados_Veiculo_id_Dados_Veiculo` int(11) DEFAULT NULL,
  `modelo` varchar(45) DEFAULT NULL,
  `fabricante` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_client_sinistro`),
  KEY `fk_tb_client_sinistro_tb_Sinistro1_idx` (`tb_Sinistro_id_sinistro`),
  KEY `fk_tb_client_sinistro_tb_Dados_Veiculo1_idx` (`tb_Dados_Veiculo_id_Dados_Veiculo`),
  CONSTRAINT `fk_tb_client_sinistro_tb_Dados_Veiculo1` FOREIGN KEY (`tb_Dados_Veiculo_id_Dados_Veiculo`) REFERENCES `tb_dados_veiculo` (`id_Dados_Veiculo`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_client_sinistro_tb_Sinistro1` FOREIGN KEY (`tb_Sinistro_id_sinistro`) REFERENCES `tb_sinistro` (`id_sinistro`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_client_sinistro`
--

LOCK TABLES `tb_client_sinistro` WRITE;
/*!40000 ALTER TABLE `tb_client_sinistro` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_client_sinistro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_cliente_veiculo`
--

DROP TABLE IF EXISTS `tb_cliente_veiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_cliente_veiculo` (
  `id_cliente_veiculo` int(11) NOT NULL AUTO_INCREMENT,
  `nome_cliente_veiculo` varchar(45) DEFAULT NULL,
  `tb_Questionario_Seguro_Auto_id_questionario` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_cliente_veiculo`),
  KEY `fk_tb_cliente_veiculo_tb_Questionario_Seguro_Auto1_idx` (`tb_Questionario_Seguro_Auto_id_questionario`),
  CONSTRAINT `fk_tb_cliente_veiculo_tb_Questionario_Seguro_Auto1` FOREIGN KEY (`tb_Questionario_Seguro_Auto_id_questionario`) REFERENCES `tb_questionario_seguro_auto` (`id_questionario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_cliente_veiculo`
--

LOCK TABLES `tb_cliente_veiculo` WRITE;
/*!40000 ALTER TABLE `tb_cliente_veiculo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_cliente_veiculo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_comissoes`
--

DROP TABLE IF EXISTS `tb_comissoes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_comissoes` (
  `id_Comissoes` int(11) NOT NULL AUTO_INCREMENT,
  `pago` varchar(4) DEFAULT NULL,
  `apolice` varchar(30) DEFAULT NULL,
  `valor_pago` varchar(15) DEFAULT NULL,
  `valor_pagar` varchar(15) DEFAULT NULL,
  `dt_pagamento` varchar(14) DEFAULT NULL,
  `nome_cliente` varchar(45) DEFAULT NULL,
  `seguradora` varchar(75) DEFAULT NULL,
  `parcelas` int(11) DEFAULT NULL,
  `Premio` double DEFAULT NULL,
  `perc_comissao` int(3) DEFAULT NULL,
  `comissao_bruta` varchar(15) DEFAULT NULL,
  `desconto` varchar(15) DEFAULT NULL,
  `liquido` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id_Comissoes`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_comissoes`
--

LOCK TABLES `tb_comissoes` WRITE;
/*!40000 ALTER TABLE `tb_comissoes` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_comissoes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_contato_pessoal`
--

DROP TABLE IF EXISTS `tb_contato_pessoal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_contato_pessoal` (
  `id_Contato_Pessoal` int(11) NOT NULL AUTO_INCREMENT,
  `tel_residencial` varchar(13) NOT NULL,
  `tel_recado` varchar(13) DEFAULT NULL,
  `cel_pessoal` varchar(14) DEFAULT NULL,
  `nextel` varchar(15) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `tb_Pessoa_Fisica_id_Pessoa_Fisica` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_Contato_Pessoal`),
  KEY `fk_tb_Contato_Pessoal_tb_Pessoa_Fisica1_idx` (`tb_Pessoa_Fisica_id_Pessoa_Fisica`),
  CONSTRAINT `fk_tb_Contato_Pessoal_tb_Pessoa_Fisica1` FOREIGN KEY (`tb_Pessoa_Fisica_id_Pessoa_Fisica`) REFERENCES `tb_pessoa_fisica` (`id_Pessoa_Fisica`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_contato_pessoal`
--

LOCK TABLES `tb_contato_pessoal` WRITE;
/*!40000 ALTER TABLE `tb_contato_pessoal` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_contato_pessoal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_contato_profissional`
--

DROP TABLE IF EXISTS `tb_contato_profissional`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_contato_profissional` (
  `id_contato` int(11) NOT NULL AUTO_INCREMENT,
  `tel_comercial` varchar(20) DEFAULT NULL,
  `cel_comercial` varchar(20) DEFAULT NULL,
  `nextel` varchar(15) DEFAULT NULL,
  `email` varchar(60) DEFAULT NULL,
  `tb_Seguradora_id_seguradora` int(11) DEFAULT NULL,
  `tb_Pessoa_Juridica_id_Pessoa_Juridica` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_contato`),
  KEY `fk_tb_Contato_tb_Seguradora1_idx` (`tb_Seguradora_id_seguradora`),
  KEY `fk_tb_Contato_tb_Pessoa_Juridica1_idx` (`tb_Pessoa_Juridica_id_Pessoa_Juridica`),
  CONSTRAINT `fk_tb_Contato_tb_Pessoa_Juridica1` FOREIGN KEY (`tb_Pessoa_Juridica_id_Pessoa_Juridica`) REFERENCES `tb_pessoa_juridica` (`id_Pessoa_Juridica`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_tb_Contato_tb_Seguradora1` FOREIGN KEY (`tb_Seguradora_id_seguradora`) REFERENCES `tb_seguradora` (`id_seguradora`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_contato_profissional`
--

LOCK TABLES `tb_contato_profissional` WRITE;
/*!40000 ALTER TABLE `tb_contato_profissional` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_contato_profissional` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_dados_veiculo`
--

DROP TABLE IF EXISTS `tb_dados_veiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_dados_veiculo` (
  `id_Dados_Veiculo` int(11) NOT NULL AUTO_INCREMENT,
  `fabricante` varchar(30) NOT NULL,
  `modelo` varchar(30) NOT NULL,
  `placa` varchar(9) DEFAULT NULL,
  `renavam` varchar(11) DEFAULT NULL,
  `cor_veiculo` varchar(15) NOT NULL,
  `qtde_portas` varchar(2) DEFAULT NULL,
  `tipo_combustivel` varchar(10) NOT NULL,
  `chassi` varchar(17) DEFAULT NULL,
  `financiamento` varchar(14) DEFAULT NULL,
  `kit_gas` varchar(3) DEFAULT NULL,
  `tb_Questionario_Seguro_Auto_id_questionario` int(11) DEFAULT NULL,
  `tb_Pessoa_Fisica_id_Pessoa_Fisica` int(11) DEFAULT NULL,
  `tb_Pessoa_Juridica_id_Pessoa_Juridica` int(11) DEFAULT NULL,
  `Disposit_Ant_Furto` varchar(22) DEFAULT NULL,
  `Ano_frabric` varchar(4) DEFAULT NULL,
  PRIMARY KEY (`id_Dados_Veiculo`),
  KEY `fk_tb_Dados_Veiculo_tb_Questionario_Seguro_Auto1_idx` (`tb_Questionario_Seguro_Auto_id_questionario`),
  KEY `fk_tb_Dados_Veiculo_tb_Pessoa_Fisica1_idx` (`tb_Pessoa_Fisica_id_Pessoa_Fisica`),
  KEY `fk_tb_Dados_Veiculo_tb_Pessoa_Juridica1_idx` (`tb_Pessoa_Juridica_id_Pessoa_Juridica`),
  CONSTRAINT `fk_tb_Dados_Veiculo_tb_Pessoa_Fisica1` FOREIGN KEY (`tb_Pessoa_Fisica_id_Pessoa_Fisica`) REFERENCES `tb_pessoa_fisica` (`id_Pessoa_Fisica`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_tb_Dados_Veiculo_tb_Pessoa_Juridica1` FOREIGN KEY (`tb_Pessoa_Juridica_id_Pessoa_Juridica`) REFERENCES `tb_pessoa_juridica` (`id_Pessoa_Juridica`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_tb_Dados_Veiculo_tb_Questionario_Seguro_Auto1` FOREIGN KEY (`tb_Questionario_Seguro_Auto_id_questionario`) REFERENCES `tb_questionario_seguro_auto` (`id_questionario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_dados_veiculo`
--

LOCK TABLES `tb_dados_veiculo` WRITE;
/*!40000 ALTER TABLE `tb_dados_veiculo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_dados_veiculo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_endereco`
--

DROP TABLE IF EXISTS `tb_endereco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_endereco` (
  `id_Endereco` int(11) NOT NULL AUTO_INCREMENT,
  `endereco` varchar(60) DEFAULT NULL,
  `numero` varchar(7) DEFAULT NULL,
  `cep` varchar(9) DEFAULT NULL,
  `bairro` varchar(60) DEFAULT NULL,
  `cidade` varchar(60) DEFAULT NULL,
  `uf` varchar(2) DEFAULT NULL,
  `bloco` varchar(2) DEFAULT NULL,
  `complemento` varchar(45) DEFAULT NULL,
  `apto` varchar(4) DEFAULT NULL,
  `tb_Pessoa_Juridica_id_Pessoa_Juridica` int(11) DEFAULT NULL,
  `tb_Pessoa_Fisica_id_Pessoa_Fisica` int(11) DEFAULT NULL,
  `tb_Sinistro_id_sinistro` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_Endereco`),
  KEY `fk_tb_Endereco_tb_Pessoa_Juridica1_idx` (`tb_Pessoa_Juridica_id_Pessoa_Juridica`),
  KEY `fk_tb_Endereco_tb_Pessoa_Fisica1_idx` (`tb_Pessoa_Fisica_id_Pessoa_Fisica`),
  KEY `fk_tb_Endereco_tb_Sinistro1_idx` (`tb_Sinistro_id_sinistro`),
  CONSTRAINT `fk_tb_Endereco_tb_Pessoa_Fisica1` FOREIGN KEY (`tb_Pessoa_Fisica_id_Pessoa_Fisica`) REFERENCES `tb_pessoa_fisica` (`id_Pessoa_Fisica`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_tb_Endereco_tb_Pessoa_Juridica1` FOREIGN KEY (`tb_Pessoa_Juridica_id_Pessoa_Juridica`) REFERENCES `tb_pessoa_juridica` (`id_Pessoa_Juridica`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_tb_Endereco_tb_Sinistro1` FOREIGN KEY (`tb_Sinistro_id_sinistro`) REFERENCES `tb_sinistro` (`id_sinistro`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_endereco`
--

LOCK TABLES `tb_endereco` WRITE;
/*!40000 ALTER TABLE `tb_endereco` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_endereco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_estacionamento_escola`
--

DROP TABLE IF EXISTS `tb_estacionamento_escola`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_estacionamento_escola` (
  `id_estacionamento_escola` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(10) DEFAULT NULL,
  `tb_Questionario_id_questionario` int(11) NOT NULL,
  PRIMARY KEY (`id_estacionamento_escola`),
  KEY `fk_tb_Estacionamento_Escola_tb_Questionario1_idx` (`tb_Questionario_id_questionario`),
  CONSTRAINT `fk_tb_Estacionamento_Escola_tb_Questionario1` FOREIGN KEY (`tb_Questionario_id_questionario`) REFERENCES `tb_questionario_seguro_auto` (`id_questionario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_estacionamento_escola`
--

LOCK TABLES `tb_estacionamento_escola` WRITE;
/*!40000 ALTER TABLE `tb_estacionamento_escola` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_estacionamento_escola` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_estacionamento_residencia`
--

DROP TABLE IF EXISTS `tb_estacionamento_residencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_estacionamento_residencia` (
  `id_Estacionamento_Residencia` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(10) DEFAULT NULL,
  `tb_Questionario_id_questionario` int(11) NOT NULL,
  PRIMARY KEY (`id_Estacionamento_Residencia`),
  KEY `fk_tb_Estacionamento_Residencia_tb_Questionario1_idx` (`tb_Questionario_id_questionario`),
  CONSTRAINT `fk_tb_Estacionamento_Residencia_tb_Questionario1` FOREIGN KEY (`tb_Questionario_id_questionario`) REFERENCES `tb_questionario_seguro_auto` (`id_questionario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_estacionamento_residencia`
--

LOCK TABLES `tb_estacionamento_residencia` WRITE;
/*!40000 ALTER TABLE `tb_estacionamento_residencia` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_estacionamento_residencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_estado_civil`
--

DROP TABLE IF EXISTS `tb_estado_civil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_estado_civil` (
  `id_Estado_Civil` int(11) NOT NULL AUTO_INCREMENT,
  `estado_civil` varchar(10) NOT NULL,
  `tb_Pessoa_Fisica_id_Pessoa_Fisica` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_Estado_Civil`),
  KEY `fk_tb_Estado_Civil_tb_Pessoa_Fisica1_idx` (`tb_Pessoa_Fisica_id_Pessoa_Fisica`),
  CONSTRAINT `fk_tb_Estado_Civil_tb_Pessoa_Fisica1` FOREIGN KEY (`tb_Pessoa_Fisica_id_Pessoa_Fisica`) REFERENCES `tb_pessoa_fisica` (`id_Pessoa_Fisica`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_estado_civil`
--

LOCK TABLES `tb_estado_civil` WRITE;
/*!40000 ALTER TABLE `tb_estado_civil` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_estado_civil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_filho_enteado_17_anos`
--

DROP TABLE IF EXISTS `tb_filho_enteado_17_anos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_filho_enteado_17_anos` (
  `id_filho_enteado_17_anos` int(11) NOT NULL AUTO_INCREMENT,
  `qnt_filhos` int(3) DEFAULT NULL,
  `idade` varchar(3) DEFAULT NULL,
  `tb_Questionario_id_questionario` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_filho_enteado_17_anos`),
  KEY `fk_tb_Filho_Enteado_17_Anos_tb_Questionario1_idx` (`tb_Questionario_id_questionario`),
  CONSTRAINT `fk_tb_Filho_Enteado_17_Anos_tb_Questionario1` FOREIGN KEY (`tb_Questionario_id_questionario`) REFERENCES `tb_questionario_seguro_auto` (`id_questionario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_filho_enteado_17_anos`
--

LOCK TABLES `tb_filho_enteado_17_anos` WRITE;
/*!40000 ALTER TABLE `tb_filho_enteado_17_anos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_filho_enteado_17_anos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_garagem`
--

DROP TABLE IF EXISTS `tb_garagem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_garagem` (
  `id_Estacionamento_Trabalho` int(11) NOT NULL AUTO_INCREMENT,
  `residencia` varchar(40) DEFAULT NULL,
  `trabalho` varchar(3) DEFAULT NULL,
  `local_estudos` varchar(3) DEFAULT NULL,
  `tb_Questionario_id_questionario` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_Estacionamento_Trabalho`),
  KEY `fk_tb_Estacionamento_Trabalho_tb_Questionario1_idx` (`tb_Questionario_id_questionario`),
  CONSTRAINT `fk_tb_Estacionamento_Trabalho_tb_Questionario1` FOREIGN KEY (`tb_Questionario_id_questionario`) REFERENCES `tb_questionario_seguro_auto` (`id_questionario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_garagem`
--

LOCK TABLES `tb_garagem` WRITE;
/*!40000 ALTER TABLE `tb_garagem` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_garagem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_item`
--

DROP TABLE IF EXISTS `tb_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_item` (
  `id_Item` int(11) NOT NULL AUTO_INCREMENT,
  `item` varchar(20) DEFAULT NULL,
  `tb_Pessoa_Juridica_id_Pessoa_Juridica` int(11) DEFAULT NULL,
  `tb_Pessoa_Fisica_id_Pessoa_Fisica` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_Item`),
  KEY `fk_table1_tb_Pessoa_Juridica1_idx` (`tb_Pessoa_Juridica_id_Pessoa_Juridica`),
  KEY `fk_Item_tb_Pessoa_Fisica1_idx` (`tb_Pessoa_Fisica_id_Pessoa_Fisica`),
  CONSTRAINT `fk_Item_tb_Pessoa_Fisica1` FOREIGN KEY (`tb_Pessoa_Fisica_id_Pessoa_Fisica`) REFERENCES `tb_pessoa_fisica` (`id_Pessoa_Fisica`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_table1_tb_Pessoa_Juridica1` FOREIGN KEY (`tb_Pessoa_Juridica_id_Pessoa_Juridica`) REFERENCES `tb_pessoa_juridica` (`id_Pessoa_Juridica`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_item`
--

LOCK TABLES `tb_item` WRITE;
/*!40000 ALTER TABLE `tb_item` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_lista_marca_veiculo`
--

DROP TABLE IF EXISTS `tb_lista_marca_veiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_lista_marca_veiculo` (
  `id_lista_veiculo` int(11) NOT NULL AUTO_INCREMENT,
  `Marca` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_lista_veiculo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_lista_marca_veiculo`
--

LOCK TABLES `tb_lista_marca_veiculo` WRITE;
/*!40000 ALTER TABLE `tb_lista_marca_veiculo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_lista_marca_veiculo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_lista_nome_veiculo`
--

DROP TABLE IF EXISTS `tb_lista_nome_veiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_lista_nome_veiculo` (
  `id_lista_Nome_veiculo` int(11) NOT NULL AUTO_INCREMENT,
  `Nome_veiculo` varchar(45) DEFAULT NULL,
  `tb_lista_Marca_Veiculo_id_lista_veiculo` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_lista_Nome_veiculo`),
  KEY `fk_tb_lista_Nome_veiculo_tb_lista_Marca_Veiculo1_idx` (`tb_lista_Marca_Veiculo_id_lista_veiculo`),
  CONSTRAINT `fk_tb_lista_Nome_veiculo_tb_lista_Marca_Veiculo1` FOREIGN KEY (`tb_lista_Marca_Veiculo_id_lista_veiculo`) REFERENCES `tb_lista_marca_veiculo` (`id_lista_veiculo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_lista_nome_veiculo`
--

LOCK TABLES `tb_lista_nome_veiculo` WRITE;
/*!40000 ALTER TABLE `tb_lista_nome_veiculo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_lista_nome_veiculo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_montagemapolice`
--

DROP TABLE IF EXISTS `tb_montagemapolice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_montagemapolice` (
  `id_MontagemApolice` int(11) NOT NULL AUTO_INCREMENT,
  `ci` varchar(20) DEFAULT NULL,
  `dt_calculo` varchar(10) DEFAULT NULL,
  `dt_inicio` varchar(10) DEFAULT NULL,
  `dt_fim` date DEFAULT NULL,
  `premio_seguradora` double DEFAULT NULL,
  `franquia` double DEFAULT NULL,
  `tipo_cobertura` varchar(40) DEFAULT NULL,
  `dano_material` double DEFAULT NULL,
  `dano_corporal` double DEFAULT NULL,
  `app_morte` double DEFAULT NULL,
  `app_invalidez` double DEFAULT NULL,
  `dano_moral` double DEFAULT NULL,
  `assist_24_horas` varchar(3) DEFAULT NULL,
  `vidros` varchar(3) DEFAULT NULL,
  `car_reserv` varchar(3) DEFAULT NULL,
  `comentarios` varchar(300) DEFAULT NULL,
  `tb_Questionario_id_questionario` int(11) DEFAULT NULL,
  `tb_Principal_Condutor_id_principal_condutor` int(11) DEFAULT NULL,
  `tb_Segundo_Condutor_id_segundo_condutor` int(11) DEFAULT NULL,
  `Seguradora_Orc` varchar(30) DEFAULT NULL,
  `perc_comissao` int(11) DEFAULT NULL,
  `tb_Dados_Veiculo_id_Dados_Veiculo` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_MontagemApolice`),
  KEY `fk_tb_Orcamento_tb_Questionario1_idx` (`tb_Questionario_id_questionario`),
  KEY `fk_tb_Orcamento_tb_Dados_Veiculo1_idx` (`tb_Dados_Veiculo_id_Dados_Veiculo`),
  CONSTRAINT `fk_tb_Orcamento_tb_Dados_Veiculo1` FOREIGN KEY (`tb_Dados_Veiculo_id_Dados_Veiculo`) REFERENCES `tb_dados_veiculo` (`id_Dados_Veiculo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_Orcamento_tb_Questionario1` FOREIGN KEY (`tb_Questionario_id_questionario`) REFERENCES `tb_questionario_seguro_auto` (`id_questionario`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_montagemapolice`
--

LOCK TABLES `tb_montagemapolice` WRITE;
/*!40000 ALTER TABLE `tb_montagemapolice` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_montagemapolice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_pagamento`
--

DROP TABLE IF EXISTS `tb_pagamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_pagamento` (
  `id_Pagamento` int(11) NOT NULL AUTO_INCREMENT,
  `parcelas` int(11) DEFAULT NULL,
  `tb_MontagemApolice_id_MontagemApolice` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_Pagamento`),
  KEY `fk_tb_Pagamento_tb_MontagemApolice1_idx` (`tb_MontagemApolice_id_MontagemApolice`),
  CONSTRAINT `fk_tb_Pagamento_tb_MontagemApolice1` FOREIGN KEY (`tb_MontagemApolice_id_MontagemApolice`) REFERENCES `tb_montagemapolice` (`id_MontagemApolice`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pagamento`
--

LOCK TABLES `tb_pagamento` WRITE;
/*!40000 ALTER TABLE `tb_pagamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_pagamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_periodo_estudo`
--

DROP TABLE IF EXISTS `tb_periodo_estudo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_periodo_estudo` (
  `id_periodo_estudo` int(11) NOT NULL AUTO_INCREMENT,
  `matutino` varchar(3) DEFAULT NULL,
  `vespertino` varchar(3) DEFAULT NULL,
  `noturno` varchar(3) DEFAULT NULL,
  `tb_Questionario_id_questionario` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_periodo_estudo`),
  KEY `fk_tb_Periodo_Estudo_tb_Questionario1_idx` (`tb_Questionario_id_questionario`),
  CONSTRAINT `fk_tb_Periodo_Estudo_tb_Questionario1` FOREIGN KEY (`tb_Questionario_id_questionario`) REFERENCES `tb_questionario_seguro_auto` (`id_questionario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_periodo_estudo`
--

LOCK TABLES `tb_periodo_estudo` WRITE;
/*!40000 ALTER TABLE `tb_periodo_estudo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_periodo_estudo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_pessoa_fisica`
--

DROP TABLE IF EXISTS `tb_pessoa_fisica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_pessoa_fisica` (
  `id_Pessoa_Fisica` int(11) NOT NULL AUTO_INCREMENT,
  `nome_completo` varchar(75) NOT NULL,
  `cpf` varchar(14) DEFAULT NULL,
  `rg` varchar(12) DEFAULT NULL,
  `dt_expedicao` varchar(10) DEFAULT NULL,
  `orgao_exped` varchar(6) DEFAULT NULL,
  `cnh` varchar(11) DEFAULT NULL,
  `tempo_habilitacao` varchar(2) DEFAULT NULL,
  `especif_temp_hap` varchar(5) DEFAULT NULL,
  `dt_nascimento` date DEFAULT NULL,
  `profissao` varchar(40) DEFAULT NULL,
  `comentarios` varchar(300) DEFAULT NULL,
  `status` varchar(22) DEFAULT NULL,
  PRIMARY KEY (`id_Pessoa_Fisica`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pessoa_fisica`
--

LOCK TABLES `tb_pessoa_fisica` WRITE;
/*!40000 ALTER TABLE `tb_pessoa_fisica` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_pessoa_fisica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_pessoa_juridica`
--

DROP TABLE IF EXISTS `tb_pessoa_juridica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_pessoa_juridica` (
  `id_Pessoa_Juridica` int(11) NOT NULL AUTO_INCREMENT,
  `razao_social` varchar(50) NOT NULL,
  `nome_fantasia` varchar(50) NOT NULL,
  `representante` varchar(75) NOT NULL,
  `cnpj` varchar(18) DEFAULT NULL,
  `area_atuacao` varchar(20) DEFAULT NULL,
  `site` varchar(120) DEFAULT NULL,
  `comentarios` text,
  `status` varchar(22) DEFAULT NULL,
  PRIMARY KEY (`id_Pessoa_Juridica`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pessoa_juridica`
--

LOCK TABLES `tb_pessoa_juridica` WRITE;
/*!40000 ALTER TABLE `tb_pessoa_juridica` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_pessoa_juridica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_principal_condutor`
--

DROP TABLE IF EXISTS `tb_principal_condutor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_principal_condutor` (
  `id_principal_condutor` int(11) NOT NULL AUTO_INCREMENT,
  `especifique` varchar(20) DEFAULT NULL,
  `tb_Pessoa_Fisica_id_Pessoa_Fisica` int(11) DEFAULT NULL,
  `tb_Pessoa_Juridica_id_Pessoa_Juridica` int(11) DEFAULT NULL,
  `tb_Questionario_Seguro_Auto_id_questionario` int(11) DEFAULT NULL,
  `Reside_Em` varchar(40) DEFAULT NULL,
  `Nome_princ_condut` varchar(75) DEFAULT NULL,
  PRIMARY KEY (`id_principal_condutor`),
  KEY `fk_tb_Principal_Condutor_tb_Pessoa_Fisica1_idx` (`tb_Pessoa_Fisica_id_Pessoa_Fisica`),
  KEY `fk_tb_Principal_Condutor_tb_Pessoa_Juridica1_idx` (`tb_Pessoa_Juridica_id_Pessoa_Juridica`),
  KEY `fk_tb_Principal_Condutor_tb_Questionario_Seguro_Auto1_idx` (`tb_Questionario_Seguro_Auto_id_questionario`),
  CONSTRAINT `fk_tb_Principal_Condutor_tb_Pessoa_Fisica1` FOREIGN KEY (`tb_Pessoa_Fisica_id_Pessoa_Fisica`) REFERENCES `tb_pessoa_fisica` (`id_Pessoa_Fisica`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_tb_Principal_Condutor_tb_Pessoa_Juridica1` FOREIGN KEY (`tb_Pessoa_Juridica_id_Pessoa_Juridica`) REFERENCES `tb_pessoa_juridica` (`id_Pessoa_Juridica`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_tb_Principal_Condutor_tb_Questionario_Seguro_Auto1` FOREIGN KEY (`tb_Questionario_Seguro_Auto_id_questionario`) REFERENCES `tb_questionario_seguro_auto` (`id_questionario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_principal_condutor`
--

LOCK TABLES `tb_principal_condutor` WRITE;
/*!40000 ALTER TABLE `tb_principal_condutor` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_principal_condutor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_proponente`
--

DROP TABLE IF EXISTS `tb_proponente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_proponente` (
  `id_Proponente` int(11) NOT NULL AUTO_INCREMENT,
  `nomeProponente` varchar(75) NOT NULL,
  `dt_nascimento` varchar(8) DEFAULT NULL,
  `tb_MontagemApolice_id_MontagemApolice` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_Proponente`),
  KEY `fk_tb_Proponente_tb_MontagemApolice1_idx` (`tb_MontagemApolice_id_MontagemApolice`),
  CONSTRAINT `fk_tb_Proponente_tb_MontagemApolice1` FOREIGN KEY (`tb_MontagemApolice_id_MontagemApolice`) REFERENCES `tb_montagemapolice` (`id_MontagemApolice`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_proponente`
--

LOCK TABLES `tb_proponente` WRITE;
/*!40000 ALTER TABLE `tb_proponente` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_proponente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_questionario_seguro_auto`
--

DROP TABLE IF EXISTS `tb_questionario_seguro_auto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_questionario_seguro_auto` (
  `id_questionario` int(11) NOT NULL AUTO_INCREMENT,
  `cep_pernoite` varchar(9) DEFAULT NULL,
  `qtde_sinis_ult_perio` varchar(3) DEFAULT NULL,
  `bonus` double DEFAULT NULL,
  `uso_veiculo` varchar(15) DEFAULT NULL,
  `resid_princ_cond_pes_18_24` varchar(50) DEFAULT NULL,
  `distan_resi_trab_km` varchar(5) DEFAULT NULL,
  `principal_condutor_estuda` varchar(3) DEFAULT NULL,
  `veiculo_usado_cli_forn` varchar(3) DEFAULT NULL,
  `roub_veic_ult_dois_anos` varchar(3) DEFAULT NULL,
  `Possui_FIlhos_ate_17` varchar(3) DEFAULT NULL,
  `garagem_fechada` varchar(3) DEFAULT NULL,
  `profissao` varchar(20) DEFAULT NULL,
  `segurado_proprie_veicu` varchar(3) DEFAULT NULL,
  `quantos_filhos` int(3) DEFAULT NULL,
  `cep_trabalho` varchar(9) DEFAULT NULL,
  `tb_Pessoa_Fisica_id_Pessoa_Fisica` int(11) DEFAULT NULL,
  `tb_Pessoa_Juridica_id_Pessoa_Juridica` int(11) DEFAULT NULL,
  `Seguradora_quest` varchar(30) DEFAULT NULL,
  `Km_Media_Mensal` varchar(6) DEFAULT NULL,
  PRIMARY KEY (`id_questionario`),
  KEY `fk_tb_Questionario_Seguro_Auto_tb_Pessoa_Fisica1_idx` (`tb_Pessoa_Fisica_id_Pessoa_Fisica`),
  KEY `fk_tb_Questionario_Seguro_Auto_tb_Pessoa_Juridica1_idx` (`tb_Pessoa_Juridica_id_Pessoa_Juridica`),
  CONSTRAINT `fk_tb_Questionario_Seguro_Auto_tb_Pessoa_Fisica1` FOREIGN KEY (`tb_Pessoa_Fisica_id_Pessoa_Fisica`) REFERENCES `tb_pessoa_fisica` (`id_Pessoa_Fisica`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_tb_Questionario_Seguro_Auto_tb_Pessoa_Juridica1` FOREIGN KEY (`tb_Pessoa_Juridica_id_Pessoa_Juridica`) REFERENCES `tb_pessoa_juridica` (`id_Pessoa_Juridica`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_questionario_seguro_auto`
--

LOCK TABLES `tb_questionario_seguro_auto` WRITE;
/*!40000 ALTER TABLE `tb_questionario_seguro_auto` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_questionario_seguro_auto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_recibo`
--

DROP TABLE IF EXISTS `tb_recibo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_recibo` (
  `id_recibo` int(11) NOT NULL AUTO_INCREMENT,
  `pg` varchar(2) DEFAULT NULL,
  `apolice` varchar(75) DEFAULT NULL,
  `nome_cliente` varchar(75) DEFAULT NULL,
  `Seguradora` varchar(75) DEFAULT NULL,
  `parcelas` int(11) DEFAULT NULL,
  `Premio` double DEFAULT NULL,
  `perc_comissao` int(3) DEFAULT NULL,
  `comissao_bruta` varchar(15) DEFAULT NULL,
  `desconto` varchar(15) DEFAULT NULL,
  `liquido` varchar(15) DEFAULT NULL,
  `valor_pago` varchar(15) DEFAULT NULL,
  `valor_pagar` varchar(15) DEFAULT NULL,
  `dt_pagamento` varchar(14) DEFAULT NULL,
  PRIMARY KEY (`id_recibo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_recibo`
--

LOCK TABLES `tb_recibo` WRITE;
/*!40000 ALTER TABLE `tb_recibo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_recibo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_segundo_condutor`
--

DROP TABLE IF EXISTS `tb_segundo_condutor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_segundo_condutor` (
  `id_segundo_condutor` int(11) NOT NULL AUTO_INCREMENT,
  `nomeSegundCondut` varchar(75) DEFAULT NULL,
  `dt_nascimento` varchar(14) DEFAULT NULL,
  `tb_Questionario_Seguro_Auto_id_questionario` int(11) DEFAULT NULL,
  `CNH_Seg_Condult` varchar(11) DEFAULT NULL,
  PRIMARY KEY (`id_segundo_condutor`),
  KEY `fk_tb_Segundo_Condutor_tb_Questionario_Seguro_Auto1_idx` (`tb_Questionario_Seguro_Auto_id_questionario`),
  CONSTRAINT `fk_tb_Segundo_Condutor_tb_Questionario_Seguro_Auto1` FOREIGN KEY (`tb_Questionario_Seguro_Auto_id_questionario`) REFERENCES `tb_questionario_seguro_auto` (`id_questionario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_segundo_condutor`
--

LOCK TABLES `tb_segundo_condutor` WRITE;
/*!40000 ALTER TABLE `tb_segundo_condutor` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_segundo_condutor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_seguradora`
--

DROP TABLE IF EXISTS `tb_seguradora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_seguradora` (
  `id_seguradora` int(11) NOT NULL AUTO_INCREMENT,
  `nome_seguradora` varchar(30) NOT NULL,
  `site_corretor` varchar(120) DEFAULT NULL,
  `site_principal` varchar(120) DEFAULT NULL,
  `comentarios` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`id_seguradora`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_seguradora`
--

LOCK TABLES `tb_seguradora` WRITE;
/*!40000 ALTER TABLE `tb_seguradora` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_seguradora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_sexo`
--

DROP TABLE IF EXISTS `tb_sexo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_sexo` (
  `id_Sexo` int(11) NOT NULL AUTO_INCREMENT,
  `sexo` varchar(9) DEFAULT NULL,
  `tb_Pessoa_Fisica_id_Pessoa_Fisica` int(11) DEFAULT NULL,
  `tb_Proponente_id_Proponente` int(11) DEFAULT NULL,
  `tb_Segundo_Condutor_id_segundo_condutor` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_Sexo`),
  KEY `fk_tb_Sexo_tb_Pessoa_Fisica1_idx` (`tb_Pessoa_Fisica_id_Pessoa_Fisica`),
  KEY `fk_tb_Sexo_tb_Proponente1_idx` (`tb_Proponente_id_Proponente`),
  KEY `fk_tb_Sexo_tb_Segundo_Condutor1_idx` (`tb_Segundo_Condutor_id_segundo_condutor`),
  CONSTRAINT `fk_tb_Sexo_tb_Pessoa_Fisica1` FOREIGN KEY (`tb_Pessoa_Fisica_id_Pessoa_Fisica`) REFERENCES `tb_pessoa_fisica` (`id_Pessoa_Fisica`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_tb_Sexo_tb_Proponente1` FOREIGN KEY (`tb_Proponente_id_Proponente`) REFERENCES `tb_proponente` (`id_Proponente`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_tb_Sexo_tb_Segundo_Condutor1` FOREIGN KEY (`tb_Segundo_Condutor_id_segundo_condutor`) REFERENCES `tb_segundo_condutor` (`id_segundo_condutor`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_sexo`
--

LOCK TABLES `tb_sexo` WRITE;
/*!40000 ALTER TABLE `tb_sexo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_sexo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_sinistro`
--

DROP TABLE IF EXISTS `tb_sinistro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_sinistro` (
  `id_sinistro` int(11) NOT NULL AUTO_INCREMENT,
  `nro_sinistro` int(11) NOT NULL,
  `apolice` varchar(30) NOT NULL,
  `sinistro_ocorrido` varchar(30) NOT NULL,
  `pessoas_envolvidas` varchar(75) NOT NULL,
  `dt_sinistro` varchar(14) NOT NULL,
  `acompanhamento` text,
  PRIMARY KEY (`id_sinistro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 PACK_KEYS=0;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_sinistro`
--

LOCK TABLES `tb_sinistro` WRITE;
/*!40000 ALTER TABLE `tb_sinistro` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_sinistro` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-07-06 21:28:18
