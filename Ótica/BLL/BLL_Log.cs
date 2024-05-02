using System;
using System.Data;
using Ótica.DAL;
using Ótica.DTO;

namespace Ótica.BLL
{
    class BLL_Log
    {
        ConexaoBD bd = new ConexaoBD();
        private string sql;

        public DataTable Listar()
        {
            try
            {
                return bd.ConsultarTabelas("select ID, DATA, TABELA, TIPO, DESCRICAO from log order by id");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Excluir()
        {
            try
            {
                bd.AlterarTabelas("delete from log where id != 0");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public DataTable Procurar(DTO_Log log)
        {
            try
            {
                if (log.PesquisaCampo)
                {
                    sql = string.Format("select ID, DATA, TABELA, TIPO, DESCRICAO from log where {0} like '%{1}%' and data between '{2}' and '{3}'",
                      log.Pesquisar_campo, log.Pesquisar_valor, log.Pesquisar_dataI.ToString("yyyy/MM/dd"), log.Pesquisar_dataF.ToString("yyyy/MM/dd"));
                }
                else
                {
                    sql = string.Format("select ID, DATA, TABELA, TIPO, DESCRICAO from log where data between '{0}' and '{1}'",
                      log.Pesquisar_dataI.ToString("yyyy/MM/dd"), log.Pesquisar_dataF.ToString("yyyy/MM/dd"));
                }

                return bd.ConsultarTabelas(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}