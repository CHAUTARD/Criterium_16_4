CREATE TABLE [dbo].[Divisions] (
    [IdDivision] INT        NOT NULL,
    [Nom]        NVARCHAR(20) NOT NULL,
    [NomLong]    TEXT       NOT NULL,
	[Niveau]	 NVARCHAR(20) NOT NULL ,
    [Ord]        INT        DEFAULT 10 NOT NULL,
    PRIMARY KEY CLUSTERED ([IdDivision] ASC)
);

