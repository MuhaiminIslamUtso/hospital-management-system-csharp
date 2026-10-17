CREATE TABLE [dbo].[Absence] (
    [AbsenceID] INT          IDENTITY (1, 1) NOT NULL,
    [StaffType] VARCHAR (50) NOT NULL,
    [StaffID]   INT          NOT NULL,
    [Date]      DATETIME     NOT NULL
);