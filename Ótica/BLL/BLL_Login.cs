using System;
using System.Data;
using Ótica.DTO;
using Ótica.DAL;

namespace Ótica.BLL
{
    class BLL_Login
    {
        ConexaoBD bd = new ConexaoBD();
        private string sql;
        private static int id;
        private static string tipo;

        public bool ValidarLogin(DTO_Login login)
        {
            try
            {
                sql = string.Format("select * from funcionario where usuario = '{0}' and senha = '{1}'", login.Usuario, login.Senha);
                DataTable data = new DataTable();
                data = bd.ConsultarTabelas(sql);
                if (data.Rows.Count > 0)
                {
                    id = int.Parse(data.Rows[0]["id"].ToString());
                    tipo = data.Rows[0]["tipo"].ToString();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool PrimeiroLogin()
        {
            try
            {
                sql = string.Format("select * from funcionario");
                DataTable data = new DataTable();
                data = bd.ConsultarTabelas(sql);
                if (data.Rows.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int UsuarioLogado()
        {
            return id;
        }

        public string TipoUsuario()
        {
            return tipo;
        }
    }
}