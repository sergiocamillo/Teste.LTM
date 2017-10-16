--======================================================================
-- author: sergio.camillo
-- date: 16/10/2017
-- description: Script inserção de valores
--======================================================================
Use [LTM.Teste]; 

GO

-- ********************** Usuários ****************************************
INSERT INTO Usuarios (UsuarioId, Login, Senha)
VALUES (NEWID(),'40017870836','EC7117851C0E5DBAAD4EFFDB7CD17C050CEA88CB'); -- Senha é 102030

-- ********************** Categorias ****************************************
INSERT INTO Categorias(CategoriaId, Descricao)
VALUES (NEWID(),'Cama, Mesa e Banho');

INSERT INTO Categorias(CategoriaId, Descricao)
VALUES (NEWID(),'Beleza e Saúde');

INSERT INTO Categorias(CategoriaId, Descricao)
VALUES (NEWID(),'Artigos Esportivos');

INSERT INTO Categorias(CategoriaId, Descricao)
VALUES (NEWID(),'Roupas');


Declare 
@CategoriaCama UNIQUEIDENTIFIER,
@CategoriaBeleza UNIQUEIDENTIFIER,
@CategoriaEsporte UNIQUEIDENTIFIER,
@CategoriaRoupas UNIQUEIDENTIFIER

SELECT @CategoriaCama = CategoriaId FROM Categorias (NOLOCK) WHERE Descricao = 'Cama, Mesa e Banho';
SELECT @CategoriaBeleza = CategoriaId FROM Categorias (NOLOCK) WHERE Descricao = 'Beleza e Saúde';
SELECT @CategoriaEsporte = CategoriaId FROM Categorias (NOLOCK) WHERE Descricao = 'Artigos Esportivos';
SELECT @CategoriaRoupas = CategoriaId FROM Categorias (NOLOCK) WHERE Descricao = 'Roupas';


-- ********************** Produtos ****************************************

Insert into Produtos (ProdutoId,Descricao,Valor,CategoriaId, Imagem)
Values (NEWID(), 'Colcha', '9.99', @CategoriaCama, 'Colcha.png');

Insert into Produtos (ProdutoId,Descricao,Valor,CategoriaId, Imagem)
Values (NEWID(), 'Travesseiro', '9.99', @CategoriaCama, 'Travesseiro.png');

Insert into Produtos (ProdutoId,Descricao,Valor,CategoriaId, Imagem)
Values (NEWID(), 'Manta', '9.99', @CategoriaCama, 'Manta.png');

Insert into Produtos (ProdutoId,Descricao,Valor,CategoriaId, Imagem)
Values (NEWID(), 'Perfume', '9.99', @CategoriaBeleza, 'Perfume.png');

Insert into Produtos (ProdutoId,Descricao,Valor,CategoriaId, Imagem)
Values (NEWID(), 'Creme Corporal', '9.99', @CategoriaBeleza, 'CremeCorporal.png');

Insert into Produtos (ProdutoId,Descricao,Valor,CategoriaId, Imagem)
Values (NEWID(), 'Redutor de Medidas', '9.99', @CategoriaBeleza, 'Redutor.png');

Insert into Produtos (ProdutoId,Descricao,Valor,CategoriaId, Imagem)
Values (NEWID(), 'Camisa São Paulo FC', '9.99', @CategoriaEsporte, 'SPFC.png');

Insert into Produtos (ProdutoId,Descricao,Valor,CategoriaId, Imagem)
Values (NEWID(), 'Chuteira Campo', '9.99', @CategoriaEsporte, 'Chuteira.png');

Insert into Produtos (ProdutoId,Descricao,Valor,CategoriaId, Imagem)
Values (NEWID(), 'Camisa Corinthians', '9.99', @CategoriaEsporte, 'Corinthians.png');

Insert into Produtos (ProdutoId,Descricao,Valor,CategoriaId, Imagem)
Values (NEWID(), 'Camisa Social', '9.99', @CategoriaRoupas, 'Camisa.png');

Insert into Produtos (ProdutoId,Descricao,Valor,CategoriaId, Imagem)
Values (NEWID(), 'Bermuda', '9.99', @CategoriaRoupas, 'Bermuda.png');

Insert into Produtos (ProdutoId,Descricao,Valor,CategoriaId, Imagem)
Values (NEWID(), 'Camisa Regata', '9.99', @CategoriaRoupas, 'Regata.png');