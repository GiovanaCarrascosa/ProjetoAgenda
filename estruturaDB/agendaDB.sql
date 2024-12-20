
-- criando e usando a dbagenda
create database dbagenda;
use dbagenda;


-- tabelas
-- criando tabela de usuarios
create table tbusuarios(

	nome varchar (80) not null,
	usuario varchar (20) not null primary key,
	telefone varchar (15),
	senha varchar (20) not null);

-- criando tabela de categorias
create table categorias(

cod_categoria int auto_increment primary key not null,
categoria varchar (80) not null,
usuario varchar (20)
);

-- criando tabela de log
create table tblog(
	cod_log int auto_increment primary key,
	usuario varchar (80) not null,
    data_alterada datetime,
    descricao varchar (300) 
);

-- criando tabela de contato
create table tbcontatos(
	cod_contato int auto_increment primary key,
    nome varchar (20),
    telefone varchar (15),
    categoria varchar (40),
    usuario varchar (30)
);





--categorias
-- criando o trigger para inserir categoria na tabela
delimiter $$

create trigger trInsertCategorias
	before
    insert
    on categorias
    for each row
begin
	set new.usuario = USER();
end;
$$

delimiter ;

-- criando o trigger para inserir as categorias na tabela de log
delimiter $$
CREATE TRIGGER trInsertCategoria
after insert ON categorias
FOR EACH ROW

begin
	insert into tblog
		(usuario,
         data_alterada,
         descricao)
	values 
		(user(),
         current_timestamp(),
         concat("A categoria ", new.categoria, " foi inserida.")
         );
         
end;
$$
delimiter ;

-- criando o trigger de deletar categoria da tabela e adicionar na tabela de log
delimiter $$

CREATE TRIGGER trlogcategoriadelete
after delete ON categorias
FOR EACH ROW

begin
	insert into tblog
		(usuario,
         data_alterada,
         descricao)
	values 
		(user(),
         current_timestamp(),
         concat("A categoria ", old.categoria, " foi excluida.")
         );
         
end;
$$

delimiter ;

-- criando o trigger para alterar categoria e add na tabela de log
delimiter $$

CREATE TRIGGER trlogcategoriaupdate
after update ON categorias
FOR EACH ROW

begin
	insert into tblog
		(usuario,
         data_alterada,
         descricao)
	values 
		(user(),
         current_timestamp(),
         concat("A categoria ", old.categoria, " foi alterada.")
         );
         
end;
$$

delimiter ;



-- contatos
-- criando o trigger para inserir contatos na tabela
delimiter $$

create trigger trInsertContato
	before
    insert
    on tbcontatos
    for each row
begin
	set new.usuario = USER();
end;
$$

delimiter ;

-- criando o trigger para inserir os contatos na tabela de log
delimiter $$
CREATE TRIGGER trInsertContatos
after insert ON tbcontatos
FOR EACH ROW

begin
	insert into tblog
		(usuario,
         data_alterada,
         descricao)
	values 
		(user(),
         current_timestamp(),
         concat("O contato ", new.nome, " foi inserido.")
         );
         
end;
$$
delimiter ;

-- criando o trigger de deletar contato da tabela e adicionar na tabela de log
delimiter $$

CREATE TRIGGER trlogcontatodelete
after delete ON tbcontatos
FOR EACH ROW

begin
	insert into tblog
		(usuario,
         data_alterada,
         descricao)
	values 
		(user(),
         current_timestamp(),
         concat("O contato ", old.nome, " foi excluido.")
         );
         
end;
$$

delimiter ;

-- criando o trigger para alterar contato e add na tabela de log
delimiter $$

CREATE TRIGGER trlogcontatoupdate
after update ON tbcontatos
FOR EACH ROW

begin
	insert into tblog
		(usuario,
         data_alterada,
         descricao)
	values 
		(user(),
         current_timestamp(),
         concat("O contato ", old.nome, " foi alterado.")
         );
         
end;
$$

delimiter ;



select * from categorias;
select * from tblog;
select * from tbusuarios;
drop trigger trInsertCategoria;