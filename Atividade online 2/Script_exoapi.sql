CREATE DATABASE dbExoAPIBANCO;

USE dbExoAPIBANCO;

CREATE TABLE Projetos(
	id INT PRIMARY KEY IDENTITY,
	Titulo VARCHAR(150) NOT NULL,
	Status VARCHAR(150) NOT NULL,
	Data_De_Inicio VARCHAR(10) NOT NULL,
	Area VARCHAR(150) NOT NULL
);

INSERT INTO Projetos (Titulo, Status, Data_De_Inicio, Area)
VALUES ('Projeto A', 'Em Planejamento', '04/10/2022', 'T.I');

INSERT INTO Projetos (Titulo, Status, Data_De_Inicio, Area)
VALUES ('Projeto B', 'Em execução', '04/12/2022', 'RH');

CREATE TABLE Usuarios(
	Id INT PRIMARY KEY IDENTITY,
	Email VARCHAR (255) NOT NULL UNIQUE,
	Senha VARCHAR (120) NOT NULL,
	Tipo CHAR (1) NOT NULL
);

INSERT INTO Usuarios VALUES ('willteste@email.com','12345','0');



