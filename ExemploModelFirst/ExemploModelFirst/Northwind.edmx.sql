
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/07/2019 11:38:39
-- Generated from EDMX file: C:\Users\rafael.lima\Desktop\Rodexo\ASP .NET\ExemploModelFirst\ExemploModelFirst\Northwind.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelTest];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ClienteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClienteSet];
GO
IF OBJECT_ID(N'[dbo].[PedidosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PedidosSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ClienteSet'
CREATE TABLE [dbo].[ClienteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'PedidosSet'
CREATE TABLE [dbo].[PedidosSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Data] datetime  NOT NULL,
    [Cliente_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ClienteSet'
ALTER TABLE [dbo].[ClienteSet]
ADD CONSTRAINT [PK_ClienteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PedidosSet'
ALTER TABLE [dbo].[PedidosSet]
ADD CONSTRAINT [PK_PedidosSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Cliente_Id] in table 'PedidosSet'
ALTER TABLE [dbo].[PedidosSet]
ADD CONSTRAINT [FK_ClientePedidos]
    FOREIGN KEY ([Cliente_Id])
    REFERENCES [dbo].[ClienteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientePedidos'
CREATE INDEX [IX_FK_ClientePedidos]
ON [dbo].[PedidosSet]
    ([Cliente_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------