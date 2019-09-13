create database db_tcc
use db_tcc

create table veiculo(

id int primary key identity not null,
anoFabricacao datetime not null,
tipoCarroceria varchar(20) not null,
combustivel decimal not null,
docProprietario int not null,
localEmplacamento varchar(50) not null,
marca varchar(50) not null,
mesSEguro datetime not null,
modelo varchar(20) not null,
observacao varchar(50) not null,
odometro int not null,
placa varchar (10) not null,
nomeProprietario varchar(50) not null,
qtdeEixos int not null,
renavam int not null,
seguradora varchar(50) not null,
tipoVeiculo varchar(50) not null,

)