create database dbAgendamento;

use dbAgendamento;

create table tb_Agendamento_11(
	id int primary key identity(1,1),
	h1 varchar(50),
	h2 varchar(50),
	h3 varchar(50),
	h4 varchar(50),
	h5 varchar(50),
	agendamento varchar(50)
);

select * from tb_Agendamento_11;

drop database dbAgendamento;
