CREATE DATABASE Chapte;

USE Chapter;

CREATE TABLE Livros(
	Id INT PRIMARY KEY IDENTITY,
	Titulo VARCHAR(150) NOT NULL,
	QuantidadePaginas INT,
	Disponivel BIT
);

INSERT INTO Livros (Titulo, QuantidadePaginas, Disponivel)
VALUES ('Caveira preta', 240, 1);

INSERT INTO Livros (Titulo, QuantidadePaginas, Disponivel)
VALUES ('Macaquinhos rosa', 140, 0);