USE [C:\USERS\HODZI\DESKTOP\FAKS\RP3\TVMANAGER\TVMANAGER\TVMANAGER\TVMANAGER\BAZATVMANAGER.MDF]
GO

/****** Object: Table [dbo].[Filmovi] Script Date: 25.1.2025. 13:02:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Filmovi];


GO
CREATE TABLE [dbo].[Filmovi] (
    [Id]               INT           IDENTITY(1,1) NOT NULL,
    [Naziv]            NVARCHAR (100) NOT NULL,
    [Trajanje]         INT            NOT NULL,
    [Vrijeme_Pocetka]  TIME (7)       NOT NULL,
    [Dan_Prikazivanja] NVARCHAR (100) NOT NULL,
    [Prioritet]        INT            NULL,
    [Rezervan]         BIT            NULL
);


