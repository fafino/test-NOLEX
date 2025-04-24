BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "ambulatori" (
	"id"	INTEGER NOT NULL UNIQUE,
	"nome"	varchar(45) NOT NULL UNIQUE,
	PRIMARY KEY("id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "esami" (
	"id"	INTEGER NOT NULL UNIQUE,
	"CodiceMinisteriale"	varchar(10) NOT NULL UNIQUE,
	"CodiceInterno"	varchar(10) NOT NULL UNIQUE,
	"DescrizioneEsame"	varchar(100),
	"particorpo_id"	INTEGER,
	PRIMARY KEY("id" AUTOINCREMENT),
	CONSTRAINT "fk_particorpo_id" FOREIGN KEY("particorpo_id") REFERENCES "particorpo"("id")
);
CREATE TABLE IF NOT EXISTS "ambulatori_esami" (
	"ambulatori_id"	INTEGER NOT NULL,
	"esami_id"	INTEGER NOT NULL,
	CONSTRAINT "fk_ambulatori_id" FOREIGN KEY("ambulatori_id") REFERENCES "ambulatori"("id"),
	CONSTRAINT "fk_esami_id" FOREIGN KEY("esami_id") REFERENCES "esami"("id")
);

CREATE TABLE IF NOT EXISTS "particorpo" (
	"id"	INTEGER NOT NULL UNIQUE,
	"descrizione"	varchar(10) NOT NULL UNIQUE,
	PRIMARY KEY("id" AUTOINCREMENT)
);
INSERT INTO "ambulatori" VALUES (1,'EcografiaPrivitera');
INSERT INTO "ambulatori" VALUES (2,'EcografiaMassimino');
INSERT INTO "ambulatori" VALUES (3,'Ambulatorio Fabio');
INSERT INTO "ambulatori" VALUES (4,'Ambulatorio Finocchiaro');
INSERT INTO "particorpo" VALUES (1,'Testa');
INSERT INTO "particorpo" VALUES (2,'Arti superiori');
INSERT INTO "particorpo" VALUES (3,'Addome');
INSERT INTO "particorpo" VALUES (4,'Torace');
COMMIT;
