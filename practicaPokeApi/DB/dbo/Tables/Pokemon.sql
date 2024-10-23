CREATE TABLE [dbo].[Pokemon] (
    [numero] UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [nombre] NVARCHAR (100)   NOT NULL,
    [tipo]   NVARCHAR (50)    NOT NULL,
    [sprite] NVARCHAR (255)   NOT NULL,
    [crie]   NVARCHAR (100)   NULL,
    [nivel]  INT              NOT NULL,
    PRIMARY KEY CLUSTERED ([numero] ASC),
    CHECK ([nivel]>=(1) AND [nivel]<=(100))
);

