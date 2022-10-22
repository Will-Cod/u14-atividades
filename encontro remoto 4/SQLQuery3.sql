CREATE database UC132;

USE UC132;

CREATE TABLE Usuarios(
	Id INT PRIMARY KEY IDENTITY,
	Email VARCHAR (255) NOT NULL UNIQUE,
	Senha VARCHAR (120) NOT NULL,
	Tipo CHAR (1) NOT NULL
);

INSERT INTO Usuarios VALUES ('willteste@email.com','12345','0');

SELECT *FROM Usuarios;

DROP table Usuarios;