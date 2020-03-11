CREATE TABLE [dbo].[Joueur] (
    [IdJoueur]  INT      NOT NULL,
    [Numero]     INT      NOT NULL,
    [Nom]        TEXT     NULL,
    [Dossard]    TEXT     NULL,
    [Licence]    TEXT     NULL,
    [Categorie]  TEXT     NULL,
    [Points]     INT      DEFAULT ((500)) NOT NULL,
    [DatNais]    DATE     NULL,
    [IdClub]    INT      NOT NULL,
    [Lettre]     CHAR (1) DEFAULT ('A') NOT NULL,
    [Ordre]      INT      DEFAULT ((0)) NULL,
    [Poule]      CHAR (1) DEFAULT ('A') NOT NULL,
    [NumInPoule] INT      DEFAULT ((0)) NULL,
    [Classement] INT      DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([IdJoueur] ASC),
    CONSTRAINT [FK_Joueur_club] FOREIGN KEY ([IdClub]) REFERENCES [dbo].[Clubs] ([IdClub])
);

