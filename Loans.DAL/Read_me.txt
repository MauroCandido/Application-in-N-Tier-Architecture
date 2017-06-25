USE [LOANS]
CREATE TABLE [dbo].[Nationality] (
    [ID]          INT        IDENTITY (1, 1) NOT NULL,
    [Nationality] NCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

