CREATE TABLE [dbo].[Aluno]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(150) NOT NULL, 
    [DataNascimento] DATETIME NOT NULL, 
    [Bolsa] BIT NOT NULL, 
    [Desconto] FLOAT NULL, 
    [GrupoId] INT NOT NULL, 
    [Cep] NVARCHAR(50) NULL, 
    [Logradouro] NVARCHAR(50) NULL, 
    [Cidade] NVARCHAR(150) NULL, 
    [Numero] INT NULL, 
    CONSTRAINT [FK_Aluno_Grupo] FOREIGN KEY ([GrupoId]) REFERENCES [Grupo]([Id])
)
