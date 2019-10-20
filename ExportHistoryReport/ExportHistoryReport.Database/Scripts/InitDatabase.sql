PRINT N'Creating [dbo].[Exports]...';
GO
CREATE TABLE [dbo].[Exports] (
    [ID]                INT            IDENTITY (1, 1) NOT NULL,
    [Name]              NVARCHAR (256) NOT NULL,
    [ExecutionDateTime] DATETIME       NOT NULL,
    [UserName]          NVARCHAR (256) NOT NULL,
    [LocationName]      NVARCHAR (256) NOT NULL,
    CONSTRAINT [PK_Exports] PRIMARY KEY CLUSTERED ([ID] ASC)
);
GO
PRINT N'Inserting temp data to [dbo].[Exports]...';
GO

INSERT INTO [dbo].[Exports] ([Name], [ExecutionDateTime], [UserName], [LocationName])
VALUES
	(N'Export 1', '2019-09-23 12:34:05', 'User 1', 'Lokal 1'),
	(N'Export 2', '2019-09-23 14:12:45', 'User 1', 'Lokal 1'),
	(N'Export 3', '2019-09-23 16:20:10', 'User 1', 'Lokal 1'),
	(N'Export 4', '2019-09-25 11:15:00', 'User 2', 'Lokal 1'),
	(N'Export 5', '2019-09-25 09:36:10', 'User 2', 'Lokal 1'),
	(N'Export 6', '2019-09-27 23:59:59', 'User 3', 'Lokal 2'),
	(N'Export 7', '2019-10-02 08:04:33', 'User 3', 'Lokal 2'),
	(N'Export 8', '2019-10-13 17:22:00', 'User 3', 'Lokal 3'),
	(N'Export 9', '2019-10-13 18:31:00', 'User 1', 'Lokal 1'),
	(N'Export 10', '2019-10-20 14:04:00', 'User 5', 'Lokal 5')
GO
PRINT N'Update complete.';
GO
