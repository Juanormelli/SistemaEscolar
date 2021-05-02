create database gestaoescolargestaoescolar;
use gestaoescolar;



create table responsaveis(
cod_responsavel int (10) primary key not null auto_increment, 
nome_resposavel varchar(50) not null,
email_responsavel varchar(50) not null,
telefone_responsavel varchar(50) not null,
cpf_resposnavel varchar (11) unique not null

);

create table aluno (
numero_matricula integer(25) primary key auto_increment not null,
nome varchar(50) not null,
cpf varchar (11) unique not null,
rg varchar(14) unique not null,
dt_nascimento varchar(25) not null,
telefone varchar(15) not null,

principal_responsavel varchar(2) not null,
email varchar(50) not null,
rua varchar (50) not null,
numero int (10) not null,
bairro varchar (50) not null,
cidade varchar(50) not null,
estado varchar(2) not null


);
create table ResponAlunos(
numero_matricula int(25) not null ,
cod_responsavel int (10) not null ,
FOREIGN KEY (cod_responsavel) references responsaveis (cod_responsavel),
FOREIGN KEY (numero_matricula) references aluno (numero_matricula),
primary key(numero_matricula,cod_responsavel)
);

create table usuario(
usuario varchar(8) not null primary key,
senha varchar(10) not null
);

insert into usuario values ("juan","123456");

select * from usuario;
select * from responsaveis;
select * from aluno;

delete from endereco;

delete from responsaveis;

ALTER USER 'root'@'localhost' IDENTIFIED WITH mysql_native_password BY 'password1';



The model backing the 'Context' context has changed since the database was created. Consider using Code First Migrations to update the database