
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/03/2022 20:19:23
-- Generated from EDMX file: F:\PROJET C#\gestion_com_2022\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [gestionCom2022];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ProduitCategorie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Produits] DROP CONSTRAINT [FK_ProduitCategorie];
GO
IF OBJECT_ID(N'[dbo].[FK_ImageProduit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Images] DROP CONSTRAINT [FK_ImageProduit];
GO
IF OBJECT_ID(N'[dbo].[FK_CommandeDetailCommande]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetailCommandes] DROP CONSTRAINT [FK_CommandeDetailCommande];
GO
IF OBJECT_ID(N'[dbo].[FK_ProduitDetailCommande]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetailCommandes] DROP CONSTRAINT [FK_ProduitDetailCommande];
GO
IF OBJECT_ID(N'[dbo].[FK_LivraisonCommande]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Livraisons] DROP CONSTRAINT [FK_LivraisonCommande];
GO
IF OBJECT_ID(N'[dbo].[FK_PaiementCommande]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Paiements] DROP CONSTRAINT [FK_PaiementCommande];
GO
IF OBJECT_ID(N'[dbo].[FK_LivreurLivraison]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Livraisons] DROP CONSTRAINT [FK_LivreurLivraison];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientPaiement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Paiements] DROP CONSTRAINT [FK_ClientPaiement];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientCommande]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Commandes] DROP CONSTRAINT [FK_ClientCommande];
GO
IF OBJECT_ID(N'[dbo].[FK_Livreur_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users_Livreur] DROP CONSTRAINT [FK_Livreur_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Client_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users_Client] DROP CONSTRAINT [FK_Client_inherits_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Livraisons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Livraisons];
GO
IF OBJECT_ID(N'[dbo].[Commandes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Commandes];
GO
IF OBJECT_ID(N'[dbo].[Paiements]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Paiements];
GO
IF OBJECT_ID(N'[dbo].[Images]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Images];
GO
IF OBJECT_ID(N'[dbo].[Produits]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produits];
GO
IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[DetailCommandes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetailCommandes];
GO
IF OBJECT_ID(N'[dbo].[Users_Livreur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users_Livreur];
GO
IF OBJECT_ID(N'[dbo].[Users_Client]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users_Client];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Fullname] nvarchar(max)  NOT NULL,
    [Role] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Livraisons'
CREATE TABLE [dbo].[Livraisons] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [Statut] nvarchar(max)  NOT NULL,
    [LivreurId] int  NOT NULL,
    [CommandeId] int  NOT NULL,
    [LivraisonCommande_Livraison_Id] int  NOT NULL
);
GO

-- Creating table 'Commandes'
CREATE TABLE [dbo].[Commandes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Numero] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Montant] float  NOT NULL,
    [AdresseLivraison] nvarchar(max)  NOT NULL,
    [Etat] nvarchar(max)  NOT NULL,
    [ClientId] int  NOT NULL
);
GO

-- Creating table 'Paiements'
CREATE TABLE [dbo].[Paiements] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Montant] float  NOT NULL,
    [Date] datetime  NOT NULL,
    [ClientId] int  NOT NULL,
    [Reference] nvarchar(max)  NOT NULL,
    [Commande_Id] int  NOT NULL
);
GO

-- Creating table 'Images'
CREATE TABLE [dbo].[Images] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ImageByte] tinyint  NOT NULL,
    [ProduitId] int  NOT NULL
);
GO

-- Creating table 'Produits'
CREATE TABLE [dbo].[Produits] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Libelle] nvarchar(max)  NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [Prix] float  NOT NULL,
    [Stock] int  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [SeuilStock] int  NOT NULL,
    [CategorieId] int  NOT NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Libelle] nvarchar(max)  NOT NULL,
    [Image] tinyint  NOT NULL,
    [Code] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DetailCommandes'
CREATE TABLE [dbo].[DetailCommandes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [QteProduits] nvarchar(max)  NOT NULL,
    [CommandeId] int  NOT NULL,
    [ProduitId] int  NOT NULL
);
GO

-- Creating table 'Users_Livreur'
CREATE TABLE [dbo].[Users_Livreur] (
    [Matricule] nvarchar(max)  NOT NULL,
    [Telephone] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Users_Client'
CREATE TABLE [dbo].[Users_Client] (
    [Telephone] nvarchar(max)  NOT NULL,
    [Adresse] nvarchar(max)  NOT NULL,
    [Solde] float  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Livraisons'
ALTER TABLE [dbo].[Livraisons]
ADD CONSTRAINT [PK_Livraisons]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Commandes'
ALTER TABLE [dbo].[Commandes]
ADD CONSTRAINT [PK_Commandes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Paiements'
ALTER TABLE [dbo].[Paiements]
ADD CONSTRAINT [PK_Paiements]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Images'
ALTER TABLE [dbo].[Images]
ADD CONSTRAINT [PK_Images]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Produits'
ALTER TABLE [dbo].[Produits]
ADD CONSTRAINT [PK_Produits]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetailCommandes'
ALTER TABLE [dbo].[DetailCommandes]
ADD CONSTRAINT [PK_DetailCommandes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users_Livreur'
ALTER TABLE [dbo].[Users_Livreur]
ADD CONSTRAINT [PK_Users_Livreur]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users_Client'
ALTER TABLE [dbo].[Users_Client]
ADD CONSTRAINT [PK_Users_Client]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CategorieId] in table 'Produits'
ALTER TABLE [dbo].[Produits]
ADD CONSTRAINT [FK_ProduitCategorie]
    FOREIGN KEY ([CategorieId])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProduitCategorie'
CREATE INDEX [IX_FK_ProduitCategorie]
ON [dbo].[Produits]
    ([CategorieId]);
GO

-- Creating foreign key on [ProduitId] in table 'Images'
ALTER TABLE [dbo].[Images]
ADD CONSTRAINT [FK_ImageProduit]
    FOREIGN KEY ([ProduitId])
    REFERENCES [dbo].[Produits]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ImageProduit'
CREATE INDEX [IX_FK_ImageProduit]
ON [dbo].[Images]
    ([ProduitId]);
GO

-- Creating foreign key on [CommandeId] in table 'DetailCommandes'
ALTER TABLE [dbo].[DetailCommandes]
ADD CONSTRAINT [FK_CommandeDetailCommande]
    FOREIGN KEY ([CommandeId])
    REFERENCES [dbo].[Commandes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CommandeDetailCommande'
CREATE INDEX [IX_FK_CommandeDetailCommande]
ON [dbo].[DetailCommandes]
    ([CommandeId]);
GO

-- Creating foreign key on [ProduitId] in table 'DetailCommandes'
ALTER TABLE [dbo].[DetailCommandes]
ADD CONSTRAINT [FK_ProduitDetailCommande]
    FOREIGN KEY ([ProduitId])
    REFERENCES [dbo].[Produits]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProduitDetailCommande'
CREATE INDEX [IX_FK_ProduitDetailCommande]
ON [dbo].[DetailCommandes]
    ([ProduitId]);
GO

-- Creating foreign key on [LivraisonCommande_Livraison_Id] in table 'Livraisons'
ALTER TABLE [dbo].[Livraisons]
ADD CONSTRAINT [FK_LivraisonCommande]
    FOREIGN KEY ([LivraisonCommande_Livraison_Id])
    REFERENCES [dbo].[Commandes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LivraisonCommande'
CREATE INDEX [IX_FK_LivraisonCommande]
ON [dbo].[Livraisons]
    ([LivraisonCommande_Livraison_Id]);
GO

-- Creating foreign key on [Commande_Id] in table 'Paiements'
ALTER TABLE [dbo].[Paiements]
ADD CONSTRAINT [FK_PaiementCommande]
    FOREIGN KEY ([Commande_Id])
    REFERENCES [dbo].[Commandes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PaiementCommande'
CREATE INDEX [IX_FK_PaiementCommande]
ON [dbo].[Paiements]
    ([Commande_Id]);
GO

-- Creating foreign key on [LivreurId] in table 'Livraisons'
ALTER TABLE [dbo].[Livraisons]
ADD CONSTRAINT [FK_LivreurLivraison]
    FOREIGN KEY ([LivreurId])
    REFERENCES [dbo].[Users_Livreur]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LivreurLivraison'
CREATE INDEX [IX_FK_LivreurLivraison]
ON [dbo].[Livraisons]
    ([LivreurId]);
GO

-- Creating foreign key on [ClientId] in table 'Paiements'
ALTER TABLE [dbo].[Paiements]
ADD CONSTRAINT [FK_ClientPaiement]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[Users_Client]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientPaiement'
CREATE INDEX [IX_FK_ClientPaiement]
ON [dbo].[Paiements]
    ([ClientId]);
GO

-- Creating foreign key on [ClientId] in table 'Commandes'
ALTER TABLE [dbo].[Commandes]
ADD CONSTRAINT [FK_ClientCommande]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[Users_Client]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientCommande'
CREATE INDEX [IX_FK_ClientCommande]
ON [dbo].[Commandes]
    ([ClientId]);
GO

-- Creating foreign key on [CommandeId] in table 'Livraisons'
ALTER TABLE [dbo].[Livraisons]
ADD CONSTRAINT [FK_CommandeLivraison]
    FOREIGN KEY ([CommandeId])
    REFERENCES [dbo].[Commandes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CommandeLivraison'
CREATE INDEX [IX_FK_CommandeLivraison]
ON [dbo].[Livraisons]
    ([CommandeId]);
GO

-- Creating foreign key on [Id] in table 'Users_Livreur'
ALTER TABLE [dbo].[Users_Livreur]
ADD CONSTRAINT [FK_Livreur_inherits_User]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Users_Client'
ALTER TABLE [dbo].[Users_Client]
ADD CONSTRAINT [FK_Client_inherits_User]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------