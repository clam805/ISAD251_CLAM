CREATE TABLE [dbo].[Order] (
    [OrderId]    INT             IDENTITY (1, 1) NOT NULL,
    [UserId]     INT             NOT NULL,
    [Total]      DECIMAL (18, 2) NOT NULL,
    [CreateDate] DATETIME        NOT NULL,
    CONSTRAINT [PK_dbo.Order] PRIMARY KEY CLUSTERED ([OrderId] ASC)
);

