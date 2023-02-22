DROP DATABASE DB_FluxoDeCaixa;

CREATE DATABASE DB_FluxoDeCaixa;

USE DB_FluxoDeCaixa;

CREATE TABLE tbl_contas (
  idConta int(11) NOT NULL AUTO_INCREMENT,
  descricao varchar(45) NOT NULL,
  PRIMARY KEY (idConta)
  );
  
CREATE TABLE tbl_lancamentos (
  idLancamento int(11) NOT NULL AUTO_INCREMENT,
  descricao varchar(45) NOT NULL,
  idConta int(11) NOT NULL,
  dataLancamento date NOT NULL,
  entradaSaida char(1) DEFAULT NULL,
  valor double DEFAULT NULL,
  PRIMARY KEY (idLancamento),
  FOREIGN KEY (idConta) REFERENCES tbl_contas (idConta)
);
CREATE TABLE tbl_usuario(
id INT NOT NULL AUTO_INCREMENT,
login VARCHAR(100) NOT NULL,
senha VARCHAR(100) NOT NULL,
PRIMARY KEY(id)
);

insert into tbl_contas values (1, 'teste 1');
insert into tbl_contas values (2, 'teste 2');

insert into tbl_usuario values (1, 'admin', 'admin');