BEGIN TRANSACTION;

CREATE TABLE IF NOT EXISTS "Groupes" (
	"IdGroupe"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"Nom"	TEXT UNIQUE
);
INSERT INTO "Groupes" ("IdGroupe","Nom") VALUES (1,'Un');
INSERT INTO "Groupes" ("IdGroupe","Nom") VALUES (2,'Deux');
INSERT INTO "Groupes" ("IdGroupe","Nom") VALUES (3,'Trois');
INSERT INTO "Groupes" ("IdGroupe","Nom") VALUES (4,'Quatre');
INSERT INTO "Groupes" ("IdGroupe","Nom") VALUES (5,'Cinq');
INSERT INTO "Groupes" ("IdGroupe","Nom") VALUES (6,'Six');
INSERT INTO "Groupes" ("IdGroupe","Nom") VALUES (7,'Sept');
INSERT INTO "Groupes" ("IdGroupe","Nom") VALUES (8,'Huit');
INSERT INTO "Groupes" ("IdGroupe","Nom") VALUES (9,'Neuf');
COMMIT;
