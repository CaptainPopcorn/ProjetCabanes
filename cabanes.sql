-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Jeu 20 Novembre 2014 à 13:26
-- Version du serveur :  5.6.15-log
-- Version de PHP :  5.4.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `cabanes`
--

-- --------------------------------------------------------

--
-- Structure de la table `appartenir`
--

CREATE TABLE IF NOT EXISTS `appartenir` (
  `id_contact` int(11) NOT NULL,
  `id_cabane` int(11) NOT NULL,
  PRIMARY KEY (`id_contact`,`id_cabane`),
  KEY `FK_appartenir_id_cabane` (`id_cabane`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `appartenir`
--

INSERT INTO `appartenir` (`id_contact`, `id_cabane`) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6);

-- --------------------------------------------------------

--
-- Structure de la table `t_cabanes`
--

CREATE TABLE IF NOT EXISTS `t_cabanes` (
  `id_cabane` int(11) NOT NULL AUTO_INCREMENT,
  `nom_cabane` varchar(50) NOT NULL,
  `altitude` int(11) NOT NULL,
  `nombre_lit` int(11) NOT NULL,
  `douche` tinyint(1) DEFAULT NULL,
  `tarif` varchar(50) NOT NULL,
  `id_visite` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_cabane`),
  KEY `FK_t_cabanes_id_visite` (`id_visite`),
  KEY `douche` (`douche`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Contenu de la table `t_cabanes`
--

INSERT INTO `t_cabanes` (`id_cabane`, `nom_cabane`, `altitude`, `nombre_lit`, `douche`, `tarif`, `id_visite`) VALUES
(1, 'Bertol', 3311, 80, 1, '13-73', NULL),
(2, 'Petit Mountet', 2142, 28, 1, '16-66', NULL),
(3, 'Bec De Bosson', 2985, 60, 1, '0-65', NULL),
(4, 'Cabane Britannia', 3030, 134, 1, '22-75', NULL),
(5, 'Vélan', 2642, 60, 1, '10-36', NULL),
(6, 'Cabane L''ornithorynque', 2222, 24, 1, '100-400', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `t_contacts`
--

CREATE TABLE IF NOT EXISTS `t_contacts` (
  `id_contact` int(11) NOT NULL AUTO_INCREMENT,
  `nom_contact` varchar(50) NOT NULL,
  `address` varchar(100) NOT NULL,
  `tel` varchar(25) DEFAULT NULL,
  `web` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_contact`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Contenu de la table `t_contacts`
--

INSERT INTO `t_contacts` (`id_contact`, `nom_contact`, `address`, `tel`, `web`) VALUES
(1, 'Anne-Marie Dolivet', 'cabane.bertol@gmail.com', '076 711 19 22', NULL),
(2, 'Melly Bochatay', 'melly-bochatay@netplus.ch', '076 760 53 47', NULL),
(3, 'Annick et Thierry Conus Rey', 'nicki78@netplus.ch', '079 276 50 68', NULL),
(4, 'Dario Andenmatten', 'cabane.britannia@saas-fee.ch', '+41 27 957 22 88', NULL),
(5, 'Sylvie Balmet et Yan Moix', 'info@velan.ch', '079 287 29 44', NULL),
(6, 'Dr Chêne', 'rue de la pleine 1196 Gland', '+41 78 421 54 71', 'www.gland-du-chene.ornithorynque.ch');

-- --------------------------------------------------------

--
-- Structure de la table `t_visites`
--

CREATE TABLE IF NOT EXISTS `t_visites` (
  `id_visite` int(11) NOT NULL AUTO_INCREMENT,
  `date_visite` date DEFAULT NULL,
  `rapport` longtext,
  `id_contact` int(11) NOT NULL,
  `id_cabane` int(11) NOT NULL,
  PRIMARY KEY (`id_visite`),
  KEY `FK_t_visites_id_contact` (`id_contact`),
  KEY `FK_t_visites_id_cabane` (`id_cabane`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `appartenir`
--
ALTER TABLE `appartenir`
  ADD CONSTRAINT `FK_appartenir_id_cabane` FOREIGN KEY (`id_cabane`) REFERENCES `t_cabanes` (`id_cabane`),
  ADD CONSTRAINT `FK_appartenir_id_contact` FOREIGN KEY (`id_contact`) REFERENCES `t_contacts` (`id_contact`);

--
-- Contraintes pour la table `t_cabanes`
--
ALTER TABLE `t_cabanes`
  ADD CONSTRAINT `FK_t_cabanes_id_visite` FOREIGN KEY (`id_visite`) REFERENCES `t_visites` (`id_visite`);

--
-- Contraintes pour la table `t_visites`
--
ALTER TABLE `t_visites`
  ADD CONSTRAINT `FK_t_visites_id_cabane` FOREIGN KEY (`id_cabane`) REFERENCES `t_cabanes` (`id_cabane`),
  ADD CONSTRAINT `FK_t_visites_id_contact` FOREIGN KEY (`id_contact`) REFERENCES `t_contacts` (`id_contact`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
