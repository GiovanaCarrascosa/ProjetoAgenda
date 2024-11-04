create database dbagenda;

use dbagenda;

create table tbusuarios(

	nome varchar (80) not null,
	usuario varchar (20) not null primary key,
	telefone varchar (15),
	senha varchar (20) not null);
