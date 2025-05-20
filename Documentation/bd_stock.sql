

USE [test];
GO

-- Tables
CREATE TABLE [dbo].[catégorie_d_articles](
	[codeCat] VARCHAR(5) NOT NULL PRIMARY KEY,
	[libelle] VARCHAR(50)
);
GO

CREATE TABLE [dbo].[dépôt](
	[idDepot] VARCHAR(50) NOT NULL PRIMARY KEY,
	[nom] VARCHAR(50),
	[ville] VARCHAR(50),
	[pays] VARCHAR(50),
	[lattitude] VARCHAR(50),
	[longitude] VARCHAR(50)
);
GO

CREATE TABLE [dbo].[fabricants](
	[refFab] VARCHAR(10) NOT NULL PRIMARY KEY,
	[nomEnt] VARCHAR(50),
	[marque] VARCHAR(50)
);
GO

CREATE TABLE [dbo].[unité](
	[codeUni] VARCHAR(10) NOT NULL PRIMARY KEY,
	[libelle] VARCHAR(30)
);
GO

CREATE TABLE [dbo].[Articles](
	[refArticles] VARCHAR(20) NOT NULL PRIMARY KEY,
	[libelle] VARCHAR(120),
	[codeUni] VARCHAR(10) NOT NULL,
	[refFab] VARCHAR(10) NOT NULL,
	[codeCat] VARCHAR(5) NOT NULL,
	[codeDep] VARCHAR(50),
	FOREIGN KEY ([codeUni]) REFERENCES [dbo].[unité]([codeUni]) ON UPDATE CASCADE,
	FOREIGN KEY ([refFab]) REFERENCES [dbo].[fabricants]([refFab]),
	FOREIGN KEY ([codeCat]) REFERENCES [dbo].[catégorie_d_articles]([codeCat]),
	FOREIGN KEY ([codeDep]) REFERENCES [dbo].[dépôt]([idDepot])
);
GO

CREATE TABLE [dbo].[mouvstock](
	[id] INT IDENTITY(1,1) PRIMARY KEY,
	[refArticle] VARCHAR(20),
	[dateHr] DATETIME,
	[type] CHAR(3),
	[qte] FLOAT,
	[numDepot] VARCHAR(50),
	FOREIGN KEY ([refArticle]) REFERENCES [dbo].[Articles]([refArticles]),
	FOREIGN KEY ([numDepot]) REFERENCES [dbo].[dépôt]([idDepot])
);
GO

CREATE TABLE [dbo].[utilisateurs](
	[id_utilisateur] INT IDENTITY(1,1) PRIMARY KEY,
	[nom_utilisateur] VARCHAR(50) NOT NULL UNIQUE,
	[mot_de_passe] VARCHAR(255) NOT NULL,
	[sel] VARCHAR(50) NOT NULL
);
GO


-- Données : unités
INSERT INTO [dbo].[unité] ([codeUni], [libelle]) VALUES 
('UNI001', 'Pièce'),
('UNI002', 'Boîte'),
('UNI003', 'test');
GO

-- Données : catégories
INSERT INTO [dbo].[catégorie_d_articles] ([codeCat], [libelle]) VALUES 
('CAT01', 'Smartphones'),
('CAT02', 'Accessoires');
GO

-- Données : dépôts
INSERT INTO [dbo].[dépôt] ([idDepot], [nom], [ville], [pays], [lattitude], [longitude]) VALUES 
('DEP002', 'Cyllas', 'St Tropez', 'France', '1', '1'),
('DEP01', 'Dépôt Central', 'Paris', 'France', '48.8566', '2.3522');
GO

-- Données : fabricants
INSERT INTO [dbo].[fabricants] ([refFab], [nomEnt], [marque]) VALUES 
('FAB01', 'Apple', 'Apple'),
('FAB02', 'Samsung', 'Samsung');
GO

-- Données : articles
INSERT INTO [dbo].[Articles] ([refArticles], [libelle], [codeUni], [refFab], [codeCat], [codeDep]) VALUES 
('ART001', 'iPhone 14 Pro', 'UNI001', 'FAB01', 'CAT01', 'DEP01'),
('ART002', 'Galaxy S22', 'UNI001', 'FAB02', 'CAT01', 'DEP01'),
('ART003', 'Test', 'UNI002', 'FAB01', 'CAT01', 'DEP01');
GO

-- Données : mouvements
SET IDENTITY_INSERT [dbo].[mouvstock] ON;
INSERT INTO [dbo].[mouvstock] ([id], [refArticle], [dateHr], [type], [qte], [numDepot]) VALUES 
(1, 'ART001', '2025-05-02T09:58:37', 'INV', 10, 'DEP01'),
(2, 'ART001', '2025-05-02T09:59:09', 'MVT', 2, 'DEP01'),
(3, 'ART001', '2025-05-02T10:00:12', 'MVT', -3, 'DEP01'),
(4, 'ART001', '2024-01-05T08:00:00', 'INV', 100, 'DEP01'),
(5, 'ART001', '2024-10-05T09:00:00', 'INV', 150, 'DEP01'),
(7, 'ART001', '2024-02-05T12:00:00', 'MVT', -10, 'DEP01'),
(8, 'ART001', '2024-05-05T15:30:00', 'MVT', 5, 'DEP01'),
(9, 'ART001', '2024-11-05T09:00:00', 'MVT', -20, 'DEP01'),
(14, 'ART001', '2024-05-01T08:00:00', 'INV', 100, 'DEP01'),
(15, 'ART001', '2024-05-10T09:00:00', 'INV', 150, 'DEP01'),
(16, 'ART001', '2024-05-20T10:00:00', 'INV', 130, 'DEP01'),
(17, 'ART001', '2024-05-02T12:00:00', 'MVT', -10, 'DEP01'),
(18, 'ART001', '2024-05-05T15:30:00', 'MVT', 5, 'DEP01'),
(19, 'ART001', '2024-05-11T09:00:00', 'MVT', -20, 'DEP01'),
(20, 'ART001', '2024-05-13T14:00:00', 'MVT', -10, 'DEP01'),
(21, 'ART001', '2024-05-15T16:00:00', 'MVT', 10, 'DEP01'),
(22, 'ART001', '2024-05-21T10:00:00', 'MVT', -5, 'DEP01'),
(23, 'ART001', '2024-05-22T11:00:00', 'MVT', 15, 'DEP01'),
(24, 'ART002', '2025-05-12T22:24:36.133', 'MVT', 50, 'DEP002'),
(25, 'ART003', '2025-05-12T22:28:22.463', 'MVT', 20, 'DEP002'),
(26, 'ART001', '2025-05-16T12:27:49.297', 'MVT', -10, 'DEP002'),
(27, 'ART001', '2025-05-16T12:29:24.860', 'MVT', 10, 'DEP002');
SET IDENTITY_INSERT [dbo].[mouvstock] OFF;
GO

-- Données : utilisateur
SET IDENTITY_INSERT [dbo].[utilisateurs] ON;
INSERT INTO [dbo].[utilisateurs] ([id_utilisateur], [nom_utilisateur], [mot_de_passe], [sel]) VALUES 
(1, 'genis', 'yyp9FiZ6HLsui8vCAQPIBhrSG97LaCZAMKdvJKprBBA=', 'Wkheyhu7+xi2ZZpiPIactA==');
SET IDENTITY_INSERT [dbo].[utilisateurs] OFF;
GO
