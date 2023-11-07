CREATE TABLE [dbo].[Book] (
    [ID]             INT            IDENTITY (1, 1) NOT NULL,
    [Title]          NVARCHAR (MAX) NOT NULL,
    [Author]         NVARCHAR (MAX) NOT NULL,
    [Price]          DECIMAL (6, 2) NOT NULL,
    [PublishingDate] DATETIME2 (7)  DEFAULT ('0001-01-01T00:00:00.0000000') NOT NULL,
    CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED ([ID] ASC)
);

