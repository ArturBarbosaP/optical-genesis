using System;
using System.Data;
using Ótica.DAL;
using Ótica.DTO;

namespace Ótica.BLL
{
    class BLL_Lista
    {
        ConexaoBD bd = new ConexaoBD();
        private string sql;

        public void Cadastrar(DTO_Lista lista)
        {
            try
            {
                sql = string.Format("insert into lista values('{0}', '{1}', '{2}')", lista.Produto_id, lista.Venda_id, lista.Quantidade);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Duplicate entry"))
                {
                    throw new Exception("Produto já existente na venda!");
                }
                else if (ex.Message.Contains("BIGINT UNSIGNED value is out of range in"))
                {
                    throw new Exception("Estoque insuficiente!");
                }
                else
                {
                    throw ex;
                }
            }
        }

        public void Alterar(DTO_Lista lista)
        {
            try
            {
                sql = string.Format("update lista set quantidade = '{0}' where produto_id = '{1}' and venda_id = '{2}'", lista.Quantidade, lista.Produto_id, lista.Venda_id);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("BIGINT UNSIGNED value is out of range in"))
                {
                    throw new Exception("Estoque insuficiente!");
                }
                else
                {
                    throw ex;
                }
            }
        }

        public void ExcluirProduto(DTO_Lista lista)
        {
            try
            {
                sql = string.Format("delete from lista where produto_id = '{0}' and venda_id = '{1}'", lista.Produto_id, lista.Venda_id);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Excluir(DTO_Lista lista)
        {
            try
            {
                sql = string.Format("delete from lista where venda_id = '{0}'", lista.Venda_id);
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
                return bd.ConsultarTabelas("select produto_id as 'PRODUTO', venda_id as 'VENDA', QUANTIDADE");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}