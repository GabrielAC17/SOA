
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/02/2017 17:07:58
-- Generated from EDMX file: C:\Users\gabri\Desktop\Positivo\Programação III\WindowsFormsApplication1\WindowsFormsApplication1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SAO];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ModelCar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarSet] DROP CONSTRAINT [FK_ModelCar];
GO
IF OBJECT_ID(N'[dbo].[FK_ModelPart]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PartSet] DROP CONSTRAINT [FK_ModelPart];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CarSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarSet];
GO
IF OBJECT_ID(N'[dbo].[ModelSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ModelSet];
GO
IF OBJECT_ID(N'[dbo].[ServiceSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ServiceSet];
GO
IF OBJECT_ID(N'[dbo].[PartSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PartSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CarSet'
CREATE TABLE [dbo].[CarSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Year] datetime  NOT NULL,
    [Model_Id] int  NOT NULL
);
GO

-- Creating table 'ModelSet'
CREATE TABLE [dbo].[ModelSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ServiceSet'
CREATE TABLE [dbo].[ServiceSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [PricePerHour] float  NOT NULL
);
GO

-- Creating table 'PartSet'
CREATE TABLE [dbo].[PartSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Year] datetime  NOT NULL,
    [EndYear] datetime  NOT NULL,
    [Price] float  NOT NULL,
    [Model_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CarSet'
ALTER TABLE [dbo].[CarSet]
ADD CONSTRAINT [PK_CarSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ModelSet'
ALTER TABLE [dbo].[ModelSet]
ADD CONSTRAINT [PK_ModelSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ServiceSet'
ALTER TABLE [dbo].[ServiceSet]
ADD CONSTRAINT [PK_ServiceSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PartSet'
ALTER TABLE [dbo].[PartSet]
ADD CONSTRAINT [PK_PartSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Model_Id] in table 'CarSet'
ALTER TABLE [dbo].[CarSet]
ADD CONSTRAINT [FK_ModelCar]
    FOREIGN KEY ([Model_Id])
    REFERENCES [dbo].[ModelSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ModelCar'
CREATE INDEX [IX_FK_ModelCar]
ON [dbo].[CarSet]
    ([Model_Id]);
GO

-- Creating foreign key on [Model_Id] in table 'PartSet'
ALTER TABLE [dbo].[PartSet]
ADD CONSTRAINT [FK_ModelPart]
    FOREIGN KEY ([Model_Id])
    REFERENCES [dbo].[ModelSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ModelPart'
CREATE INDEX [IX_FK_ModelPart]
ON [dbo].[PartSet]
    ([Model_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------