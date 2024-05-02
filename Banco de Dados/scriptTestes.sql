use otica;


call pr_resetBanco;
call pr_insertDefault;
call pr_diminuirEstoque(1, 97);
drop trigger `LISTA_BEFORE_UPDATE`;
select * from log;

select * from funcionario;

select * from produto;
update produto set quantidade = 63 where id = 3;
select * from cliente;

select * from venda;

select * from lista;

insert into lista value (3, 1, 1);
update lista set quantidade = 1 where produto_id = 3 and venda_id = 1;
delete from lista where produto_id = 2 and venda_id = 1;