using System;
using System.Data;
using Ótica.DAL;
using Ótica.DTO;


namespace Ótica.BLL
{
    class BLL_Vendas
    {
        ConexaoBD bd = new ConexaoBD();
        private string sql;

        public void Cadastrar(DTO_Vendas vendas)
        {
            try
            {
                sql = string.Format("insert into venda values(null, '{0}', '{1}', '{2}', '{3}', '{4}')", 
                                    vendas.Data_venda.ToString("yyyy/MM/dd"), vendas.Forma_pagamento, vendas.Observacao, vendas.Funcionario_id, vendas.Cliente_id);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar(DTO_Vendas vendas)
        {
            try
            {
                sql = string.Format("update venda set data_venda = '{0}', forma_pagamento = '{1}', observacao = '{2}', funcionario_id_fk = '{3}', cliente_id_fk = '{4}' where id = '{5}'",
                                    vendas.Data_venda.ToString("yyyy/MM/dd"), vendas.Forma_pagamento, vendas.Observacao, vendas.Funcionario_id, vendas.Cliente_id, vendas.Id);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excuir(DTO_Vendas vendas)
        {
            try
            {
                sql = string.Format("delete from venda where id = '{0}'", vendas.Id);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Listar()
        {
            try
            {
                return bd.ConsultarTabelas("select venda.id as 'ID', venda.data_venda as 'DATA DA VENDA', venda.forma_pagamento as 'FORMA DE PAGAMENTO', venda.observacao as 'OBSERVACAO', funcionario.nome as 'FUNCIONARIO', cliente.nome as 'CLIENTE' from funcionario join venda on funcionario.id = venda.funcionario_id_fk left join cliente on cliente.id = venda.cliente_id_fk order by id;");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Procurar(DTO_Vendas vendas)
        {
            try
            {
                if (vendas.PesquisaCampo)
                {
                    sql = string.Format("select venda.id as 'ID', venda.data_venda as 'DATA DA VENDA', venda.forma_pagamento as 'FORMA DE PAGAMENTO', venda.observacao as 'OBSERVACAO', funcionario.nome as 'FUNCIONARIO', cliente.nome as 'CLIENTE' from funcionario join venda on funcionario.id = venda.funcionario_id_fk left join cliente on cliente.id = venda.cliente_id_fk where {0} like '%{1}%' and data_venda between '{2}' and '{3}'",
                      vendas.Pesquisar_campo, vendas.Pesquisar_valor, vendas.Pesquisar_dataI.ToString("yyyy/MM/dd"), vendas.Pesquisar_dataF.ToString("yyyy/MM/dd"));
                }
                else
                {
                    sql = string.Format("select venda.id as 'ID', venda.data_venda as 'DATA DA VENDA', venda.forma_pagamento as 'FORMA DE PAGAMENTO', venda.observacao as 'OBSERVACAO', funcionario.nome as 'FUNCIONARIO', cliente.nome as 'CLIENTE' from funcionario join venda on funcionario.id = venda.funcionario_id_fk left join cliente on cliente.id = venda.cliente_id_fk where data_venda between '{0}' and '{1}'",
                      vendas.Pesquisar_dataI.ToString("yyyy/MM/dd"), vendas.Pesquisar_dataF.ToString("yyyy/MM/dd"));
                }
                
                return bd.ConsultarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ClicarDTG()
        {
            try
            {
                return bd.ConsultarTabelas("select ID, DATA_VENDA as 'DATA DA VENDA', FORMA_PAGAMENTO as 'FORMA DE PAGAMENTO', OBSERVACAO, funcionario_id_fk as 'FUNCIONARIO', cliente_id_fk as 'CLIENTE' from venda order by id");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ProdutosVenda(DTO_Vendas vendas)
        {
            try
            {
                sql = string.Format("select produto.id as 'ID', produto.nome as 'PRODUTO', lista.quantidade as 'QTD', produto.preco as 'PRECO' from venda join lista on venda.id = lista.venda_id join produto on produto.id = lista.produto_id where venda.id = '{0}' order by id", vendas.Id);
                return bd.ConsultarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable UltimoIdInserido()
        {
            try
            {
                return bd.ConsultarTabelas("select MAX(id) from venda");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}