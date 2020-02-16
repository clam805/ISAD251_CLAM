CREATE TABLE [dbo].[Item] (
    [ItemId]         INT             IDENTITY (1, 1) NOT NULL,
    [Name]           NVARCHAR (MAX)  NULL,
    [Description]    NVARCHAR (MAX)  NULL,
    [Price]          DECIMAL (18, 2) NOT NULL,
    [Category]       NVARCHAR (MAX)  NULL,
    [ItemPictureUrl] NVARCHAR (MAX)  NULL,
    [InternalImage]  VARBINARY (MAX) NULL,
    [Visible]        BIT             NOT NULL,
    CONSTRAINT [PK_dbo.Item] PRIMARY KEY CLUSTERED ([ItemId] ASC)
);

