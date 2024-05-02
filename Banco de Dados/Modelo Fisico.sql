create database otica;
use otica;

create table log(
id int unsigned auto_increment not null primary key,
data datetime not null,
tabela varchar(20) not null,
tipo varchar(80) not null,
descricao varchar(1000) not null
);

create table funcionario(
id int unsigned not null primary key auto_increment,
nome varchar(80) not null,
data_nasc date not null,
cpf char(14) not null,
telefone char(15) not null,	
email varchar (100) not null,
salario double(9,2) not null,
comissao double(4,2) not null,
horario_entrada time not null,
horario_saida time not null,
cep char(9) not null,
estado char(2) not null,
cidade varchar(100) not null,
bairro varchar(100) not null,
rua varchar(100) not null,
numero int not null,
complemento varchar(150) not null,
usuario varchar(50) not null,
senha varchar(50) not null,
tipo varchar(20) not null
);

create table produto(
id int unsigned not null primary key auto_increment,
nome varchar(80) not null,
marca varchar(80) not null,
fornecedor varchar(80) not null,
preco double(9,2) not null,
quantidade int unsigned not null,
descricao varchar(250) not null
);

create table cliente(
id int unsigned not null primary key auto_increment,
nome varchar(80) not null,
data_nasc date not null,
cpf char(14) not null,
telefone char(15) not null,
email varchar(100) not null,
cep char(9) not null,
estado char(2) not null,
cidade varchar(100) not null,
bairro varchar(100) not null,
rua varchar(100) not null,
numero int not null,
complemento varchar(150) not null
);

create table venda(
id int unsigned not null primary key auto_increment, 
data_venda date not null,
forma_pagamento varchar(20) not null,
observacao varchar(150) not null,
funcionario_id_fk int unsigned not null,
cliente_id_fk int unsigned, 
foreign key (funcionario_id_fk) references funcionario(id),
foreign key (cliente_id_fk) references cliente(id)
);

create table lista(
produto_id int unsigned not null,
venda_id int unsigned not null,
quantidade int not null,
foreign key (produto_id) references produto(id),
foreign key (venda_id) references venda(id),
primary key (produto_id, venda_id)
);

DELIMITER $$

-- TRIGGERS

-- FUNCIONARIO
CREATE DEFINER = CURRENT_USER TRIGGER `otica`.`FUNCIONARIO-INSERT` AFTER INSERT ON `funcionario` FOR EACH ROW
BEGIN
	INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Inserir", CONCAT("Valores inseridos: ID: ", NEW.id, ", NOME: ", NEW.nome, ", DATA DE NASCIMENTO: ", NEW.data_nasc, ", CPF: ", NEW.cpf, ", TELEFONE: ", NEW.telefone, ", EMAIL: ", NEW.email, ", SALARIO: ", NEW.salario, ", COMISSAO: ", NEW.comissao, ", HORARIO DE ENTRADA: ", NEW.horario_entrada, ", HORARIO DE SAIDA: ", NEW.horario_saida, ", CEP: ", NEW.cep, ", ESTADO: ", NEW.estado, ", CIDADE: ", NEW.cidade, ", BAIRRO: ", NEW.bairro, ", RUA: ", NEW.rua, ", NUMERO: ", NEW.numero, ", COMPLEMENTO: ", NEW.complemento, ", USUARIO: ", NEW.usuario, ", SENHA: ", NEW.senha, ", TIPO: ", NEW.tipo));
END$$

CREATE DEFINER = CURRENT_USER TRIGGER `otica`.`FUNCIONARIO-UPDATE` AFTER UPDATE ON `funcionario` FOR EACH ROW
BEGIN
	IF NEW.nome <> OLD.nome THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Alterar", CONCAT("Valores alterados: Nome: De: ", OLD.nome, " para: ", NEW.nome, ". ID: ", NEW.id));
	END IF;
    
    IF NEW.data_nasc <> OLD.data_nasc THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Alterar", CONCAT("Valores alterados: Data de Nascimento: De: ", OLD.data_nasc, " para: ", NEW.data_nasc, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.cpf <> OLD.cpf THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Alterar", CONCAT("Valores alterados: CPF: De: ", OLD.cpf, " para: ", NEW.cpf, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.telefone <> OLD.telefone THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Alterar", CONCAT("Valores alterados: Telefone: De: ", OLD.telefone, " para: ", NEW.telefone, ". ID: ", NEW.id));
	END IF;
    
    IF NEW.email <> OLD.email THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Alterar", CONCAT("Valores alterados: Email: De: ", OLD.email, " para: ", NEW.email, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.salario <> OLD.salario THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Alterar", CONCAT("Valores alterados: Salario: De: ", OLD.salario, " para: ", NEW.salario, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.comissao <> OLD.comissao THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Alterar", CONCAT("Valores alterados: Comissao: De: ", OLD.comissao, " para: ", NEW.comissao, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.horario_entrada <> OLD.horario_entrada THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Alterar", CONCAT("Valores alterados: Horario de Entrada: De: ", OLD.horario_entrada, " para: ", NEW.horario_entrada, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.horario_saida <> OLD.horario_saida THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Alterar", CONCAT("Valores alterados: Horario de Saida: De: ", OLD.horario_saida, " para: ", NEW.horario_saida, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.cep <> OLD.cep THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Alterar", CONCAT("Valores alterados: CEP: De: ", OLD.cep, " para: ", NEW.cep, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.estado <> OLD.estado THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Alterar", CONCAT("Valores alterados: Estado: De: ", OLD.estado, " para: ", NEW.estado, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.cidade <> OLD.cidade THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Alterar", CONCAT("Valores alterados: Cidade: De: ", OLD.cidade, " para: ", NEW.cidade, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.bairro <> OLD.bairro THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Alterar", CONCAT("Valores alterados: Bairro: De: ", OLD.bairro, " para: ", NEW.bairro, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.rua <> OLD.rua THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Alterar", CONCAT("Valores alterados: Rua: De: ", OLD.rua, " para: ", NEW.rua, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.numero <> OLD.numero THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Alterar", CONCAT("Valores alterados: Numero: De: ", OLD.numero, " para: ", NEW.numero, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.complemento <> OLD.complemento THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Alterar", CONCAT("Valores alterados: Complemento: De: ", OLD.complemento, " para: ", NEW.complemento, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.usuario <> OLD.usuario THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Alterar", CONCAT("Valores alterados: Usuario: De: ", OLD.usuario, " para: ", NEW.usuario, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.senha <> OLD.senha THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Alterar", CONCAT("Valores alterados: Senha: De: ", OLD.senha, " para: ", NEW.senha, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.tipo <> OLD.tipo THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Alterar", CONCAT("Valores alterados: Tipo: De: ", OLD.tipo, " para: ", NEW.tipo, ". ID: ", NEW.id));
	END IF;
END$$

CREATE DEFINER = CURRENT_USER TRIGGER `otica`.`FUNCIONARIO-DELETE` AFTER DELETE ON `funcionario` FOR EACH ROW
BEGIN
	INSERT INTO LOG VALUES (NULL, NOW(), "Funcionario", "Excluir" ,CONCAT("Valores excluidos: ID: ", OLD.id, ", NOME: ", OLD.nome, ", DATA DE NASCIMENTO: ", OLD.data_nasc, ", CPF: ", OLD.cpf, ", TELEFONE: ", OLD.telefone, ", EMAIL: ", OLD.email, ", SALARIO: ", OLD.salario, ", COMISSAO: ", OLD.comissao, ", HORARIO DE ENTRADA: ", OLD.horario_entrada, ", HORARIO DE SAIDA: ", OLD.horario_saida, ", CEP: ", OLD.cep, ", ESTADO: ", OLD.estado, ", CIDADE: ", OLD.cidade, ", BAIRRO: ", OLD.bairro, ", RUA: ", OLD.rua, ", NUMERO: ", OLD.numero, ", COMPLEMENTO: ", OLD.complemento, ", USUARIO: ", OLD.usuario, ", SENHA: ", OLD.senha, ", TIPO: ", OLD.tipo));
END$$

-- PRODUTO
CREATE DEFINER = CURRENT_USER TRIGGER `otica`.`PRODUTO-INSERT` AFTER INSERT ON `produto` FOR EACH ROW
BEGIN
	INSERT INTO LOG VALUES (NULL, NOW(), "Produto", "Inserir" ,CONCAT("Valores inseridos: ID: ",NEW.id, ", NOME: ", NEW.nome, ", MARCA: ", NEW.marca, ", FORNECEDOR: ", NEW.fornecedor, ", PRECO: ", NEW.preco, ", QUANTIDADE: ", NEW.quantidade, ", DESCRICAO: ", NEW.descricao));
END$$

CREATE DEFINER = CURRENT_USER TRIGGER `otica`.`PRODUTO-UPDATE` AFTER UPDATE ON `produto` FOR EACH ROW
BEGIN
	IF NEW.nome <> OLD.nome THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Produto", "Alterar", CONCAT("Valores alterados: Nome: De: ", OLD.nome, " para: ", NEW.nome, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.marca <> OLD.marca THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Produto", "Alterar", CONCAT("Valores alterados: Marca: De: ", OLD.marca, " para: ", NEW.marca, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.fornecedor <> OLD.fornecedor THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Produto", "Alterar", CONCAT("Valores alterados: Fornecedor: De: ", OLD.fornecedor, " para: ", NEW.fornecedor, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.preco <> OLD.preco THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Produto", "Alterar", CONCAT("Valores alterados: Preco: De: ", OLD.preco, " para: ", NEW.preco, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.quantidade <> OLD.quantidade THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Produto", "Alterar", CONCAT("Valores alterados: Quantidade: De: ", OLD.quantidade, " para: ", NEW.quantidade, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.descricao <> OLD.descricao THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Produto", "Alterar", CONCAT("Valores alterados: Descricao: De: ", OLD.descricao, " para: ", NEW.descricao, ". ID: ", NEW.id));
	END IF;
END$$

CREATE DEFINER = CURRENT_USER TRIGGER `otica`.`PRODUTO-DELETE` AFTER DELETE ON `produto` FOR EACH ROW
BEGIN
	INSERT INTO LOG VALUES (NULL, NOW(), "Produto", "Excluir" ,CONCAT("Valores excluidos: ID: ",OLD.id, ", NOME: ", OLD.nome, ", MARCA: ", OLD.marca, ", FORNECEDOR: ", OLD.fornecedor, ", PRECO: ", OLD.preco, ", QUANTIDADE: ", OLD.quantidade, ", DESCRICAO: ", OLD.descricao));
END$$

-- CLIENTE
CREATE DEFINER = CURRENT_USER TRIGGER `otica`.`CLIENTE-INSERT` AFTER INSERT ON `cliente` FOR EACH ROW
BEGIN
	INSERT INTO LOG VALUES (NULL, NOW(), "Cliente", "Inserir" ,CONCAT("Valores inseridos: ID: ", NEW.id, ", NOME: ", NEW.nome, ", DATA DE NASCIMENTO: ", NEW.data_nasc, ", CPF: ", NEW.cpf, ", TELEFONE: ", NEW.telefone, ", EMAIL: ", NEW.email, ", CEP: ", NEW.cep, ", ESTADO: ", NEW.estado, ", CIDADE: ", NEW.cidade, ", BAIRRO: ", NEW.bairro, ", RUA: ", NEW.rua, ", NUMERO: ", NEW.numero, ", COMPLEMENTO: ", NEW.complemento));
END$$

CREATE DEFINER = CURRENT_USER TRIGGER `otica`.`CLIENTE-UPDATE` AFTER UPDATE ON `cliente` FOR EACH ROW
BEGIN
	IF NEW.nome <> OLD.nome THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Cliente", "Alterar", CONCAT("Valores alterados: Nome: De: ", OLD.nome, " para: ", NEW.nome, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.data_nasc <> OLD.data_nasc THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Cliente", "Alterar", CONCAT("Valores alterados: Data de Nascimento: De: ", OLD.data_nasc, " para: ", NEW.data_nasc, ". ID: ", NEW.id));
	END IF;
    
    IF NEW.cpf <> OLD.cpf THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Cliente", "Alterar", CONCAT("Valores alterados: CPF: De: ", OLD.cpf, " para: ", NEW.cpf, ". ID: ", NEW.id));
    END IF;
    
    IF NEW.telefone <> OLD.telefone THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Cliente", "Alterar", CONCAT("Valores alterados: Telefone: De: ", OLD.telefone, " para: ", NEW.telefone, ". ID: ", NEW.id));
	END IF;
    
    IF NEW.email <> OLD.email THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Cliente", "Alterar", CONCAT("Valores alterados: Email: De: ", OLD.email, " para: ", NEW.email, ". ID: ", NEW.id));
	END IF;
    
    IF NEW.cep <> OLD.cep THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Cliente", "Alterar", CONCAT("Valores alterados: CEP: De: ", OLD.cep, " para: ", NEW.cep, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.estado <> OLD.estado THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Cliente", "Alterar", CONCAT("Valores alterados: Estado: De: ", OLD.estado, " para: ", NEW.estado, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.cidade <> OLD.cidade THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Cliente", "Alterar", CONCAT("Valores alterados: Cidade: De: ", OLD.cidade, " para: ", NEW.cidade, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.bairro <> OLD.bairro THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Cliente", "Alterar", CONCAT("Valores alterados: Bairro: De: ", OLD.bairro, " para: ", NEW.bairro, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.rua <> OLD.rua THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Cliente", "Alterar", CONCAT("Valores alterados: Rua: De: ", OLD.rua, " para: ", NEW.rua, ". ID: ", NEW.id));
	END IF;
    
    IF NEW.numero <> OLD.numero THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Cliente", "Alterar", CONCAT("Valores alterados: Numero: De: ", OLD.numero, " para: ", NEW.numero, ". ID: ", NEW.id));
	END IF;
    
    IF NEW.complemento <> OLD.complemento THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Cliente", "Alterar", CONCAT("Valores alterados: Complemento: De: ", OLD.complemento, " para: ", NEW.complemento, ". ID: ", NEW.id));
	END IF;
END$$

CREATE DEFINER = CURRENT_USER TRIGGER `otica`.`CLIENTE-DELETE` AFTER DELETE ON `cliente` FOR EACH ROW
BEGIN
	INSERT INTO LOG VALUES (NULL, NOW(), "Cliente", "Excluir" ,CONCAT("Valores excluidos: ID: ", OLD.id, ", NOME: ", OLD.nome, ", DATA DE NASCIMENTO: ", OLD.data_nasc, ", CPF: ", OLD.cpf, ", TELEFONE: ", OLD.telefone, ", EMAIL: ", OLD.email, ", CEP: ", OLD.cep, ", ESTADO: ", OLD.estado, ", CIDADE: ", OLD.cidade, ", BAIRRO: ", OLD.bairro, ", RUA: ", OLD.rua, ", NUMERO: ", OLD.numero, ", COMPLEMENTO: ", OLD.complemento));
END$$

-- VENDA
CREATE DEFINER = CURRENT_USER TRIGGER `otica`.`VENDA-INSERT` AFTER INSERT ON `venda` FOR EACH ROW
BEGIN
	INSERT INTO LOG VALUES (NULL, NOW(), "Venda", "Inserir" ,CONCAT("Valores inseridos: ID: ", NEW.id, ", DATA DA VENDA: ", NEW.data_venda, ", FORMA DE PAGAMENTO: ", NEW.forma_pagamento, ", OBSERVACAO: ", NEW.observacao, "ID DO FUNCIONARIO: ", NEW.funcionario_id_fk, ", ID DO CLIENTE: ", NEW.cliente_id_fk));
END$$

CREATE DEFINER = CURRENT_USER TRIGGER `otica`.`VENDA-UPDATE` AFTER UPDATE ON `venda` FOR EACH ROW
BEGIN
	IF NEW.data_venda <> OLD.data_venda THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Cliente", "Alterar", CONCAT("Valores alterados: Data da venda: De: ", OLD.data_venda, " para: ", NEW.data_venda, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.forma_pagamento <> OLD.forma_pagamento THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Cliente", "Alterar", CONCAT("Valores alterados: Forma de pagamento: De: ", OLD.forma_pagamento, " para: ", NEW.forma_pagamento, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.observacao <> OLD.observacao THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Cliente", "Alterar", CONCAT("Valores alterados: Observacao: De: ", OLD.observacao, " para: ", NEW.observacao, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.funcionario_id_fk <> OLD.funcionario_id_fk THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Cliente", "Alterar", CONCAT("Valores alterados: ID do funcionario: De: ", OLD.funcionario_id_fk, " para: ", NEW.funcionario_id_fk, ". ID: ", NEW.id));
	END IF;
    
	IF NEW.cliente_id_fk <> OLD.cliente_id_fk THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Cliente", "Alterar", CONCAT("Valores alterados: ID do cliente: De: ", OLD.cliente_id_fk, " para: ", NEW.cliente_id_fk, ". ID: ", NEW.id));
	END IF;
END$$

CREATE DEFINER = CURRENT_USER TRIGGER `otica`.`VENDA-DELETE` AFTER DELETE ON `venda` FOR EACH ROW
BEGIN
	INSERT INTO LOG VALUES (NULL, NOW(), "Venda", "Excluir" ,CONCAT("Valores excluidos: ID: ", OLD.id, ", DATA DA VENDA: ", OLD.data_venda, ", FORMA DE PAGAMENTO: ", OLD.forma_pagamento, ", OBSERVACAO: ", OLD.observacao, "ID DO FUNCIONARIO: ", OLD.funcionario_id_fk, ", ID DO CLIENTE: ", OLD.cliente_id_fk));
END$$

-- LISTA
CREATE DEFINER = CURRENT_USER TRIGGER `otica`.`LISTA_BEFORE_INSERT` BEFORE INSERT ON `lista` FOR EACH ROW
BEGIN
	call pr_diminuirEstoqueInsert(NEW.produto_id, NEW.quantidade);
END$$

CREATE DEFINER = CURRENT_USER TRIGGER `otica`.`LISTA-INSERT` AFTER INSERT ON `lista` FOR EACH ROW
BEGIN
	INSERT INTO LOG VALUES (NULL, NOW(), "Lista", "Inserir" ,CONCAT("Valores inseridos: ID DO PRODUTO: ", NEW.produto_id, ", ID DA VENDA: ", NEW.venda_id, ", QUANTIDADE: ", NEW.quantidade));
END$$

CREATE DEFINER = CURRENT_USER TRIGGER `otica`.`LISTA_BEFORE_UPDATE` BEFORE UPDATE ON `lista` FOR EACH ROW
BEGIN
	IF NEW.quantidade > OLD.quantidade THEN
		call pr_diminuirEstoqueUpdate(NEW.produto_id, NEW.quantidade, OLD.quantidade);
	ELSEIF NEW.quantidade < OLD.quantidade THEN
		call pr_aumentarEstoqueUpdate(NEW.produto_id, NEW.quantidade, OLD.quantidade);
	END IF;
END$$

CREATE DEFINER = CURRENT_USER TRIGGER `otica`.`LISTA-UPDATE` AFTER UPDATE ON `lista` FOR EACH ROW
BEGIN
	IF NEW.produto_id <> OLD.produto_id THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Lista", "Alterar", CONCAT("Valores alterados: ID do produto: De: ", OLD.produto_id, " para: ", NEW.produto_id));
	END IF;
    
	IF NEW.venda_id <> OLD.venda_id THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Lista", "Alterar", CONCAT("Valores alterados: ID da venda: De: ", OLD.venda_id, " para: ", NEW.venda_id));
	END IF;
    
	IF NEW.quantidade <> OLD.quantidade THEN
		INSERT INTO LOG VALUES (NULL, NOW(), "Lista", "Alterar", CONCAT("Valores alterados: Quantidade: De: ", OLD.quantidade, " para: ", NEW.quantidade));
	END IF;
END$$

CREATE DEFINER = CURRENT_USER TRIGGER `otica`.`LISTA-DELETE` AFTER DELETE ON `lista` FOR EACH ROW
BEGIN
	INSERT INTO LOG VALUES (NULL, NOW(), "Lista", "Excluir" ,CONCAT("Valores excluidos: ID DO PRODUTO: ", OLD.produto_id, ", ID DA VENDA: ", OLD.venda_id, ", QUANTIDADE: ", OLD.quantidade));
END$$

-- PROCEDURES

CREATE PROCEDURE pr_resetBanco()
BEGIN
    delete from funcionario where funcionario.id != 0;
    alter table funcionario auto_increment = 1;
	delete from produto where produto.id != 0;
	alter table produto auto_increment = 1;
	delete from cliente where cliente.id != 0;
	alter table cliente auto_increment = 1;
	delete from venda where venda.id != 0;
	alter table venda auto_increment = 1;
	delete from lista where lista.venda_id != 0;
	alter table lista auto_increment = 1;
	delete from log where log.id != 0;
	alter table log auto_increment = 1;
END$$

CREATE PROCEDURE pr_insertDefault()
BEGIN
	insert into funcionario values
	(null, "Yago Tomás Sérgio Cardoso", "1999/03/20", "019.582.427-05", "(62) 98729-4658", "marcio_silva@fosjc.unesp.br", 5300, 0, "07:00", "18:00", "74595-308", "GO", "Goiânia", "Residencial Itália", "Rua FL42", 750, "", "Gerente", "123456", "Gerente"),
	(null, "Marcos Thomas Luan Novaes", "1968/04/23", "292.350.596-40", "(91) 98798-4738", "marcos_thomas_novaes@companyvivo.com.br", 2500, 15.5, "11:00", "18:00", "66840-295", "PA", "Belém", "São João do Outeiro (Outeiro)", "Rua das Mangas", 986, "", "Vendas", "123456", "cadVendas"),
	(null, "Elias Raul Alves", "1948/03/22", "300.355.715-78", "(82) 98620-2938", "eliasraulalves@marcossousa.com", 2800, 0, "07:00", "18:00", "57071-171", "AL", "Maceió", "Clima Bom", "3ª Travessa Santa Rita", 889, "", "Produtos", "123456", "cadProdutos");

	insert into produto values
	(null, "Produto 1", "Marca 1", "Fornecedor 1", 105.24, 100, "Descrição 1"),
	(null, "Produto 2", "Marca 2", "Fornecedor 2", 24.62, 27, "Descrição 2"),
	(null, "Produto 3", "Marca 3", "Fornecedor 3", 98.77, 66, "Descrição 3"),
	(null, "Produto 4", "Marca 4", "Fornecedor 4", 55.99, 10, "Descrição 4"),
	(null, "Produto 5", "Marca 5", "Fornecedor 5", 75.99, 49, "Descrição 5"),
	(null, "Produto 6", "Marca 6", "Fornecedor 6", 10.00, 17, "Descrição 6"),
	(null, "Produto 7", "Marca 7", "Fornecedor 7", 15.99, 16, "Descrição 7"),
	(null, "Produto 8", "Marca 8", "Fornecedor 8", 19.90, 74, "Descrição 8"),
	(null, "Produto 9", "Marca 9", "Fornecedor 9", 78.54, 25, "Descrição 9"),
	(null, "Produto 10", "Marca 10", "Fornecedor 10", 200.65, 10, "Descrição 10");

	insert into cliente values
	(null, "Rosa Aline Clara Pinto", "1980/03/04", "434.793.861-64", "(65) 98811-4663", "rosa-pinto93@iahoo.com", "78095-382", "MT", "Cuiabá", "Parque Cuiabá", "Rua H-5", 717, ""),
	(null, "Isaac Kaique Vinicius Novaes", "1977/02/18", "472.453.724-89", "(85) 99420-9591", "isaac_kaique_novaes@efetivaseguros.com.br", "60762-625", "CE", "Fortaleza", "Mondubim", "Rua 4", 749, ""),
	(null, "Raimundo Renato Arthur Assunção", "1957/09/14", "583.605.361-80", "(98) 98822-2182", "raimundo_renato_assuncao@gmai.com", "65054-070", "MA", "São Luís", "Forquilha", "Rua Nossa Senhora da Conceição", 802, ""),
	(null, "Edson Cauã Bento Martins", "1993/03/11", "407.717.536-40", "(74) 98325-2123", "edson.caua.martins@onset.com.br", "48901-460", "BA", "Juazeiro", "Pedra do Lord", "Rua Gabriel Castro", 690, ""),
	(null, "Milena Jaqueline Costa", "1991/09/07", "039.338.591-40", "(51) 98203-2267", "milena.jaqueline.costa@novadeliveri.com.br", "94450-460", "RS", "Viamão", "São Lucas", "Rua Luperce Miranda", 660, "");

	insert into venda values
	(null, "2022/09/29", "Cartão de Crédito", "Compra parcelada em 12x sem juros", 2, 1),
	(null, "2022/09/29", "Cartão de Débito", "Compra paga a vista", 2, 2),
	(null, "2022/09/29", "PIX", "Compra paga a vista", 2, 3),
	(null, "2022/09/29", "Dinheiro", "Compra paga a vista, com troco de R$ 20,50", 2, 4),
	(null, "2022/09/29", "Cartão de Crédito", "Compra parcelada em 5x sem juros", 2, 5),
	(null, "2022/09/30", "Dinheiro", "Compra paga a vista, com troco de R$ 20,50", 2, 3),
	(null, "2022/10/29", "Dinheiro", "Compra paga a vista, com troco de R$ 20,50", 2, 4);

	insert into lista values
	(1, 1, 1),
	(2, 2, 1),
	(4, 3, 3),
	(3, 4, 4),
	(5, 5, 1),
	(6, 6, 1),
	(10, 7, 10);
END$$

CREATE PROCEDURE pr_diminuirEstoqueInsert(in pID int, in pQTD int)
BEGIN
	update produto set produto.quantidade = produto.quantidade - pQTD where produto.id = pID;
END$$

CREATE PROCEDURE pr_diminuirEstoqueUpdate(in pID int, in NEWpQTD int, in OLDpQTD int)
BEGIN
	update produto set produto.quantidade = produto.quantidade - (NEWpQTD - OLDpQTD) where produto.id = pID;
END$$

CREATE PROCEDURE pr_aumentarEstoqueUpdate(in pID int, in NEWpQTD int, in OLDpQTD int)
BEGIN
	update produto set produto.quantidade = produto.quantidade + (OLDpQTD - NEWpQTD) where produto.id = pID;
END$$

DELIMITER ;

