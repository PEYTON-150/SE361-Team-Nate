CREATE TABLE [dbo].[Raw Materials] (
    [Material]          NVARCHAR (50) NOT NULL,
    [Quantity on Hand]  INT           NOT NULL,
    [Price Per Unit]    FLOAT (53)    NOT NULL,
    [Who We Order From] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Material] ASC)
);
