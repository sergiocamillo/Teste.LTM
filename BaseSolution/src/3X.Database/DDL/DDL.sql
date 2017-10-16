--======================================================================
-- author: sergio.camillo
-- date: 16/10/2017
-- description: Script para criação das tabelas
--======================================================================

IF EXISTS(SELECT * FROM sys.databases WHERE name = 'LTM.Teste')
BEGIN
 Drop Database [LTM.Teste];
END

Create Database [LTM.Teste];
GO

Use [LTM.Teste];

Create Table Usuarios (
UsuarioId uniqueidentifier primary key,
Login varchar(64),
Senha varchar(128))

Create Table Categorias (
CategoriaId uniqueidentifier primary key,
Descricao Varchar(128)
)

Create Table Produtos (
ProdutoId uniqueidentifier primary key,
CategoriaId uniqueidentifier,
Descricao Varchar(128),
Valor decimal(18,4),
Imagem varchar(512)
)
