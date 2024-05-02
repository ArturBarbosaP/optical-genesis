using System;
using System.Data;
using Ótica.DAL;
using Ótica.DTO;


namespace Ótica.BLL
{
    class BLL_Clientes
    {
        ConexaoBD bd = new ConexaoBD();
        private string sql;

        public void Cadastrar(DTO_Clientes clientes)
        {
            try
            {
                sql = string.Format("insert into cliente values(null, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')",
                                    clientes.Nome, clientes.Data_nasc.ToString("yyyy/MM/dd"), clientes.Cpf, clientes.Telefone, clientes.Email, clientes.Cep, clientes.Estado, clientes.Cidade, clientes.Bairro, clientes.Rua, clientes.Numero, clientes.Complemento);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Alterar(DTO_Clientes clientes)
        {
            try
            {
                sql = string.Format("update cliente set nome = '{0}', data_nasc = '{1}', cpf = '{2}', telefone = '{3}', email = '{4}', cep = '{5}', estado = '{6}', cidade = '{7}', bairro = '{8}', rua = '{9}', numero = '{10}', complemento = '{11}' where id = '{12}'",
                                    clientes.Nome, clientes.Data_nasc.ToString("yyyy/MM/dd"), clientes.Cpf, clientes.Telefone, clientes.Email, clientes.Cep, clientes.Estado, clientes.Cidade, clientes.Bairro, clientes.Rua,clientes.Numero, clientes.Complemento, clientes.Id);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Excluir(DTO_Clientes clientes)
        {
            try
            {
                sql = string.Format("delete from cliente where id = '{0}'", clientes.Id);
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
                return bd.ConsultarTabelas("select ID, NOME, DATA_NASC as 'DATA DE NASCIMENTO', CPF, TELEFONE, EMAIL, CEP, ESTADO, CIDADE, BAIRRO, RUA, NUMERO, COMPLEMENTO from cliente order by id");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable Procurar(DTO_Clientes clientes)
        {
            try
            {
                sql = string.Format("select ID, NOME, DATA_NASC as 'DATA DE NASCIMENTO', CPF, TELEFONE, EMAIL, CEP, ESTADO, CIDADE, BAIRRO, RUA, NUMERO, COMPLEMENTO from cliente where {0} like '%{1}%'",
                      clientes.Pesquisar_campo, clientes.Pesquisar_valor);
                return bd.ConsultarTabelas(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}