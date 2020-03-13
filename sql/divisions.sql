BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "Divisions" (
	"IdDivision"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"Nom"	TEXT UNIQUE,
	"NomLong"	TEXT UNIQUE,
	"Niveau"	TEXT,
	"Ord"	INTEGER UNIQUE
);

INSERT INTO "Divisions" ("IdDivision","Nom","NomLong","Niveau","Ord") VALUES (23,'PRO A','PRO A','NATIONAL',10);
INSERT INTO "Divisions" ("IdDivision","Nom","NomLong","Niveau","Ord") VALUES (24,'PRO B','PRO B','NATIONAL',20);
INSERT INTO "Divisions" ("IdDivision","Nom","NomLong","Niveau","Ord") VALUES (25,'N1','Nationale une','NATIONAL',30);
INSERT INTO "Divisions" ("IdDivision","Nom","NomLong","Niveau","Ord") VALUES (26,'N2','Nationale deux','NATIONAL',40);
INSERT INTO "Divisions" ("IdDivision","Nom","NomLong","Niveau","Ord") VALUES (27,'N3','Nationale trois','NATIONAL',50);
INSERT INTO "Divisions" ("IdDivision","Nom","NomLong","Niveau","Ord") VALUES (28,'PN','Pré-nationale','REGIONAL',60);
INSERT INTO "Divisions" ("IdDivision","Nom","NomLong","Niveau","Ord") VALUES (29,'R1','Régionale une','REGIONAL',70);
INSERT INTO "Divisions" ("IdDivision","Nom","NomLong","Niveau","Ord") VALUES (30,'R2','Régionale deux','REGIONAL',80);
INSERT INTO "Divisions" ("IdDivision","Nom","NomLong","Niveau","Ord") VALUES (31,'R3','Régionale trois','REGIONAL',90);
INSERT INTO "Divisions" ("IdDivision","Nom","NomLong","Niveau","Ord") VALUES (32,'PR','Pré-Régionale','DEPARTEMENTAL',100);
INSERT INTO "Divisions" ("IdDivision","Nom","NomLong","Niveau","Ord") VALUES (33,'D1','Départemental un','DEPARTEMENTAL',110);
INSERT INTO "Divisions" ("IdDivision","Nom","NomLong","Niveau","Ord") VALUES (34,'D2','Départemental deux','DEPARTEMENTAL',120);
INSERT INTO "Categories" ("IdCategorie","Nom","Commentaire","Parent","Ord") VALUES (1,'Vétéran 5','nés en 1939 et avant','VÉTÉRANS',10);
INSERT INTO "Categories" ("IdCategorie","Nom","Commentaire","Parent","Ord") VALUES (2,'Vétéran 4','du 1er Janvier 1940 au 31 décembre 1949','VÉTÉRANS',20);
INSERT INTO "Categories" ("IdCategorie","Nom","Commentaire","Parent","Ord") VALUES (3,'Vétéran 3','du 1er Janvier 1920 au 31 Décembre 1959','VÉTÉRANS',30);
INSERT INTO "Categories" ("IdCategorie","Nom","Commentaire","Parent","Ord") VALUES (4,'Vétéran 2','du 1er Janvier 1960 au 31 Décembre 1969','VÉTÉRANS',40);
INSERT INTO "Categories" ("IdCategorie","Nom","Commentaire","Parent","Ord") VALUES (5,'Vétéran 1','du 1er Janvier 1970 au 31 Décembre 1979','VÉTÉRANS',50);
INSERT INTO "Categories" ("IdCategorie","Nom","Commentaire","Parent","Ord") VALUES (6,'Sénior','du 1er Janvier 1980 au 31 Décembre 2001','SÉNIORS',60);
INSERT INTO "Categories" ("IdCategorie","Nom","Commentaire","Parent","Ord") VALUES (7,'Junior 3 (« -de 18 ans »)','nés en 2002','JUNIORS',70);
INSERT INTO "Categories" ("IdCategorie","Nom","Commentaire","Parent","Ord") VALUES (8,'Junior 2 (« -de 17 ans »)','nés en 2003','JUNIORS',80);
INSERT INTO "Categories" ("IdCategorie","Nom","Commentaire","Parent","Ord") VALUES (9,'Junior 1 (« -de 16 ans »)','nés en 2004','JUNIORS',90);
INSERT INTO "Categories" ("IdCategorie","Nom","Commentaire","Parent","Ord") VALUES (10,'Cadet 2 (« -de 15 ans »)','nés en 2005','CADETS',100);
INSERT INTO "Categories" ("IdCategorie","Nom","Commentaire","Parent","Ord") VALUES (11,'Cadet 1 (« -de 14 ans »)','nés en 2006','CADETS',110);
INSERT INTO "Categories" ("IdCategorie","Nom","Commentaire","Parent","Ord") VALUES (12,'Minime 2 (« -de 13 ans »)','nés en 2007','MINIMES',120);
INSERT INTO "Categories" ("IdCategorie","Nom","Commentaire","Parent","Ord") VALUES (13,'Minime 1 (« -de 12 ans »)','nés en 2008','MINIMES',130);
INSERT INTO "Categories" ("IdCategorie","Nom","Commentaire","Parent","Ord") VALUES (14,'Benjamin 2 (« -de 11 ans »)','nés en 2009','BENJAMINS',140);
INSERT INTO "Categories" ("IdCategorie","Nom","Commentaire","Parent","Ord") VALUES (15,'Benjamin 1 (« -de 10 ans »)','nés en 2010','BENJAMINS',150);
INSERT INTO "Categories" ("IdCategorie","Nom","Commentaire","Parent","Ord") VALUES (16,'Poussin (« -de 9 ans »)','Nés en 2011 et après','POUSSINS',160);
COMMIT;
