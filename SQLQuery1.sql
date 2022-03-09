
create database Empresa
go

use Empresa
go

create table Departamento(
	Codigo int identity (1,1) not null,
	Nome varchar (100),
	Rg varchar(18),
	Sexo varchar(20),
	constraint pk_Departamento primary key (Codigo)
)
go

create unique index ix_Nome on Departamento (Nome) where Nome is not null
go


insert into Departamento (Nome,Rg,Sexo) values ('Matheus','123456789','Masculino')
insert into Departamento (Nome,Rg,Sexo) values ('Junior','142353467','Masculino')
insert into Departamento (Nome,Rg,Sexo) values ('Ana','0192837465','Feminino')
insert into Departamento (Nome,Rg,Sexo) values ('Julia','992273843','Feminino')
insert into Departamento (Nome,Rg,Sexo) values ('Rodrigo','123441889','Masculino')

select * from Departamento


create table Funcionario(
	Codigo int identity (1,1) not null,
	CodigoDepartamento int not null,
	PrimeiroNome varchar (100) not null,
	SegundoNome varchar (100),
	UltimoNome varchar (100) not null,
	DataNascimento date not null,
	CPF int not null,
	RG varchar (9) not null,
	Endereço varchar (100),
	CEP int not null,
	Cidade varchar (100),
	Fone int not null,
	Funcao varchar (100) not null,
	Salario decimal (10,2) not null
	constraint pk_Funcionario primary key (Codigo)
)
go

select *from Funcionario
