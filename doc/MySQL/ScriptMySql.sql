create database ReadingTracker; 
use ReadingTracker;


/*drop table tb_rt_clientes;*/
create table tb_rt_clientes(
	id_cliente int primary key auto_increment, 
    nome varchar(50) not null, 
    dataNascimento datetime not null, 
    email varchar(50),
    senha varchar(100), 
    apiId varchar(200), 
    statusPessoa bit
);

insert into tb_rt_clientes (nome,dataNascimento,email,senha,apiId,statusPessoa)
select 
'Jane Doe', 
'2000-02-28 00:00:00', 
'JaneDoe@gmail.com', 
MD5('Jane_Doe'), 
'',
1;




