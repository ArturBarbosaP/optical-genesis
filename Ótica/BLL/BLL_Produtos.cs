using System;
using System.Data;
using Ótica.DAL;
using Ótica.DTO;

namespace Ótica.BLL
{
    class BLL_Produtos
    {
        ConexaoBD bd = new ConexaoBD();
        private string sql;

        public void Cadastrar(DTO_Produtos produtos)
        {
            try
            {
                sql = string.Format("insert into produto values(null, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                       produtos.Nome, produtos.Marca, produtos.Fornecedor, produtos.Preco.ToString().Replace(",","."), produtos.Quantidade, produtos.Descricao);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Alterar(DTO_Produtos produtos)
        {
            try
            {
                sql = string.Format("update produto set nome = '{0}', marca = '{1}', fornecedor = '{2}', preco = '{3}', quantidade = '{4}', descricao = '{5}' where id = '{6}'",
                       produtos.Nome, produtos.Marca, produtos.Fornecedor, produtos.Preco.ToString().Replace(",", "."), produtos.Quantidade, produtos.Descricao, produtos.Id);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Excluir(DTO_Produtos produtos)
        {
            try
            {
                sql = string.Format("delete from produto where id = '{0}'", produtos.Id);
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
                return bd.ConsultarTabelas("select ID, NOME, MARCA, FORNECEDOR, PRECO R$, QUANTIDADE QTD, DESCRICAO from produto order by id");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable Procurar(DTO_Produtos produtos)
        {
            try
            {
                sql = string.Format("select ID, NOME, MARCA, FORNECEDOR, PRECO R$, QUANTIDADE QTD, DESCRICAO from produto where {0} like '%{1}%'",
                      produtos.Pesquisar_campo, produtos.Pesquisar_valor);
                return bd.ConsultarTabelas(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}