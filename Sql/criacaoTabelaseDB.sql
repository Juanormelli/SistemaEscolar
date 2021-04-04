create database gestaoescolar;
use gestaoescolar;

create table endereco ( 
cod_endereco int (10) auto_increment primary key not null,
rua varchar (50) not null,
numero int (10) not null,
bairro varchar (50) not null,
cidade varchar(50) not null,
estado varchar(2) not null
);

create table responsaveis(
cod_responsaveis int (10) primary key not null auto_increment, 
nome_pai varchar(50) not null,
nome_mae varchar(50) not null,
email_pai varchar(50) not null,
email_mae varchar(50) not null,
telefone_pai varchar(50) not null,
telefone_mae varchar(50) not null,
cpf_pai varchar (11) unique not null,
cpf_mae varchar(11) unique not null
);

create table aluno (
numero_matricula integer(25) primary key auto_increment not null,
nome varchar(50) not null,
cpf varchar (11) unique not null,
rg varchar(14) unique not null,
dt_nascimento varchar(25) not null,
telefone varchar(15) not null,
cod_endereco int not null,
cod_responsaveis int not null,
principal_responsavel varchar(2) not null,
FOREIGN KEY (cod_endereco) references endereco (cod_endereco),
FOREIGN KEY (cod_responsaveis) references responsaveis (cod_responsaveis),
email varchar(50) not null
);

create table usuario(
usuario varchar(8) not null primary key,
senha varchar(10) not null
);

insert into usuario values ("juan","123456");

select * from endereco;
select * from responsaveis;
select * from aluno;

delete from endereco;

delete from responsaveis;

