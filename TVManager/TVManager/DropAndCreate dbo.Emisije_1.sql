USE [C:\USERS\HODZI\DESKTOP\FAKS\RP3\TVMANAGER\TVMANAGER\TVMANAGER\TVMANAGER\BAZATVMANAGER.MDF]
GO

/****** Object: Table [dbo].[Emisije] Script Date: 25.1.2025. 11:53:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Emisije];


GO
CREATE TABLE [dbo].[Emisije] (
    [Id]                INT            IDENTITY(1,1) NOT NULL,
    [Naziv]             NVARCHAR (100) NOT NULL,
    [Trajanje]          INT            NOT NULL,
    [Vrijeme_Pocetka]   TIME (7)       NOT NULL,
    [Dani_Prikazivanja] TEXT           NOT NULL,
    [Prioritet]         INT            NOT NULL,
    [Rezervna]          BIT            NOT NULL
);


