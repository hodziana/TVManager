USE [C:\USERS\HODZI\DESKTOP\FAKS\RP3\TVMANAGER\TVMANAGER\TVMANAGER\TVMANAGER\BAZATVMANAGER.MDF]
GO

/****** Object: Table [dbo].[Blokovi_Reklama] Script Date: 25.1.2025. 13:35:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Blokovi_Reklama];


GO
CREATE TABLE [dbo].[Blokovi_Reklama] (
    [Id]      INT  IDENTITY(1,1) NOT NULL,
    [reklame] TEXT NULL
);


