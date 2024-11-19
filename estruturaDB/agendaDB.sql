create database dbagenda;

use dbagenda;

create table tbusuarios(

	nome varchar (80) not null,
	usuario varchar (20) not null primary key,
	telefone varchar (15),
	senha varchar (20) not null);



create table categorias(

	cod_categoria int not null auto_increment primary key,
    categoria varchar (50) not null);


create table categorias(

cod_categoria int auto_increment primary key not null,
categoria varchar (80) not null,
usuario varchar (20)
);

delimiter $$

create trigger trInsertCategoria
	before
    insert
    on categorias
    for each row
begin
	set new.usuario = CURRENT_USER();
end;
$$

delimiter ;