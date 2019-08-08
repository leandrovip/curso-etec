CREATE DATABASE Oficina

USE Oficina;
GO

CREATE TABLE Estado
(
    Codigo INT PRIMARY KEY,
    Uf VARCHAR(2) NOT NULL
)

CREATE TABLE Cliente 
(
    Cpf varchar(20) PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Endereco VARCHAR(100),
    Cidade VARCHAR(50),
    Codigo_Uf INT,
    Cep VARCHAR(20),
    Rg VARCHAR(20),
    DataNascimento DATETIME,
    Renda DECIMAL(18,2)
)

CREATE TABLE Dependente
(
    Cpf VARCHAR(20) PRIMARY KEY,
    Cpf_Cliente VARCHAR(20),
    Nome VARCHAR(100) NOT NULL,
    Endereco VARCHAR(100),
    Cidade VARCHAR(50),
    Codigo_UF INT,
    Cep VARCHAR(20),
    Renda DECIMAL(18,2)
)

CREATE TABLE Telefone 
(
    Codigo INT IDENTITY(1,1) PRIMARY KEY,
    Cpf_Cliente VARCHAR(20),
    Tipo VARCHAR(10),
    Numero VARCHAR(20) NOT NULL 
)

CREATE TABLE Veiculo
(
    Placa VARCHAR(10) PRIMARY KEY,
    Cpf_Cliente VARCHAR(20),
    Modelo VARCHAR(20),
    Ano INT,
    Fabricante VARCHAR(20),
    Cor VARCHAR(20),
    Detalhes VARCHAR(100)
)

CREATE TABLE OrdemServico
(
    Numero INT IDENTITY(1,1) PRIMARY KEY,
    DataCadastro DATETIME,
    Cpf_Cliente VARCHAR(20),
    Placa_Veiculo VARCHAR(10)
)

CREATE TABLE DetalheOs 
(
    Codigo INT PRIMARY KEY IDENTITY(1,1),
    Numero_Os INT,
    Codigo_Peca INT
)

CREATE TABLE Peca
(
    Codigo INT PRIMARY KEY IDENTITY(1,1),
    Descricao VARCHAR(50),
    Valor DECIMAL(18,2)
)


-- Cria chaves estrangeiras

-- Cliente
ALTER TABLE Cliente ADD CONSTRAINT FK_CodigoUf FOREIGN KEY (Codigo_Uf) REFERENCES Estado (Codigo)

-- Telefone
ALTER TABLE Telefone ADD CONSTRAINT FK_Cpf_Cliente FOREIGN KEY (Cpf_Cliente) REFERENCES Cliente (Cpf)

-- Dependente
ALTER TABLE Dependente ADD CONSTRAINT FK_Dependente_Cpf_Cliente FOREIGN KEY (Cpf_Cliente) REFERENCES Cliente (Cpf)
ALTER TABLE Dependente ADD CONSTRAINT FK_Dependente_CodigoUf FOREIGN KEY (Codigo_UF) REFERENCES Estado (Codigo)

-- Veiculo
ALTER TABLE Veiculo ADD CONSTRAINT FK_Veiculo_Cpf_Cliente FOREIGN KEY (Cpf_Cliente) REFERENCES Cliente (Cpf)

-- Ordem Serviço
ALTER TABLE OrdemServico ADD CONSTRAINT FK_OrdemServico_Cpf_Cliente FOREIGN KEY (Cpf_Cliente) REFERENCES Cliente (Cpf)
ALTER TABLE OrdemServico ADD CONSTRAINT FK_OrdemServico_Placa_Veiculo FOREIGN KEY (Placa_Veiculo) REFERENCES Veiculo (Placa)

-- Detalhe OS
ALTER TABLE DetalheOs ADD CONSTRAINT FK_DetalheOs_Numero_Os FOREIGN KEY (Numero_Os) REFERENCES OrdemServico (Numero)
ALTER TABLE DetalheOs ADD CONSTRAINT FK_DetalheOs_Codigo_Peca FOREIGN KEY (Codigo_Peca) REFERENCES Peca (Codigo)

