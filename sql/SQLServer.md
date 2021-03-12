# Comandos SQL Server

CREATE DATABASE Loja;
USE Loja;
CREATE TABLE Cliente(
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Nome VARCHAR(50) NOT NULL,
    Telefone VARCHAR(20) NOT NULL,
    Endereco VARCHAR(70) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE() NOT NULL,
    UpdatedAt DATETIME NULL
);
CREATE TABLE Produto(
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Nome VARCHAR(30) NOT NULL,
    Descricao VARCHAR(50) NOT NULL,
    Preco FLOAT NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE() NOT NULL,
    UpdatedAt DATETIME NULL
);
CREATE TABLE Venda(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    IdCliente INT NOT NULL FOREIGN KEY REFERENCES Cliente(Id),
    ValorTotal FLOAT NOT NULL,
	CreatedAt DATETIME DEFAULT GETDATE() NOT NULL,
    UpdatedAt DATETIME NULL
);
CREATE TABLE ItemVenda(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    IdProduto INT NOT NULL FOREIGN KEY REFERENCES Produto(Id),
    IdVenda INT NOT NULL FOREIGN KEY REFERENCES Venda(Id),
    Quantidade INT NOT NULL,
    ValorTotal FLOAT NOT NULL,
	CreatedAt DATETIME DEFAULT GETDATE() NOT NULL,
    UpdatedAt DATETIME NULL
);



## Uso do Insert:
INSERT INTO Cliente (Nome, Telefone, Endereco)
VALUES ('Charuto Hokage', '17 66666-9999', 'Rua dos hokage');
INSERT INTO Produto (Nome, Descricao, Preco)
VALUES ('Blusa Hokage', 'cor branca, 100% NINJA', 25.5);
INSERT INTO Produto (Nome, Descricao, Preco)
VALUES ('Blusa GENIN', 'cor preta, 100% NINJA', 28);
INSERT INTO Venda (IdCliente, ValorTotal) VALUES (1, 51);
INSERT INTO ItemVenda (IdProduto, IdVenda, Quantidade, ValorTotal) VALUES (1, 1, 2, 51);


## Uso do Select:
SELECT * FROM Produto;
SELECT Quantidade, ValorTotal FROM ItemVenda;


## Uso do Update:
UPDATE Produto
SET Nome = 'Regata Aldeia da folha, Preco = 27
WHERE Id = 2;


## Uso do Delete:
DELETE FROM Produto WHERE Id = 2;


## Uso de Comentario
--Isto é um comentário ninja!

