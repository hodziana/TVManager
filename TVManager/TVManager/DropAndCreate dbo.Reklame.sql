USE [C:\USERS\HODZI\DESKTOP\FAKS\RP3\TVMANAGER\TVMANAGER\TVMANAGER\TVMANAGER\BAZATVMANAGER.MDF]
GO

/****** Object: Table [dbo].[Reklame] Script Date: 25.1.2025. 13:34:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Reklame];


GO
CREATE TABLE [dbo].[Reklame] (
    [Id]       INT           IDENTITY(1,1) NOT NULL,
    [Naziv]    NVARCHAR (100) NOT NULL,
    [Cijena]   FLOAT (53)     NOT NULL,
    [Termin]   NVARCHAR (50)  NOT NULL,
    [Trajanje] INT            NOT NULL
);


