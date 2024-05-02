using System;
using System.Data;
using Ótica.DAL;
using Ótica.DTO;


namespace Ótica.BLL
{
    class BLL_Funcionarios
    {
        ConexaoBD bd = new ConexaoBD();
        private string sql;

        public void Cadastrar(DTO_Funcionarios funcionarios)
        {
            try
            {
                sql = string.Format("insert into funcionario values(null, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}')",
                                    funcionarios.Nome, funcionarios.Data_nasc.ToString("yyyy/MM/dd"), funcionarios.Cpf, funcionarios.Telefone, funcionarios.Email, 
                                    funcionarios.Salario.ToString().Replace(",", "."), funcionarios.Comissao.ToString().Replace(",", "."), funcionarios.Horario_entrada.ToString("HH:mm"),
                                    funcionarios.Horario_saida.ToString("HH:mm"), funcionarios.Cep, funcionarios.Estado, funcionarios.Cidade, funcionarios.Bairro, funcionarios.Rua, 
                                    funcionarios.Numero, funcionarios.Complemento, funcionarios.Usuario, funcionarios.Senha, funcionarios.Tipo);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Alterar(DTO_Funcionarios funcionarios)
        {
            try
            {
                sql = string.Format("update funcionario set nome = '{0}', data_nasc = '{1}', cpf = '{2}', telefone = '{3}', email = '{4}', salario = '{5}', comissao = '{6}', horario_entrada = '{7}', horario_saida = '{8}', cep = '{9}', estado = '{10}', cidade = '{11}', bairro = '{12}', rua = '{13}', numero = '{14}', complemento = '{15}', usuario = '{16}', senha = '{17}', tipo = '{18}' where id = '{19}'",
                                    funcionarios.Nome, funcionarios.Data_nasc.ToString("yyyy/MM/dd"), funcionarios.Cpf, funcionarios.Telefone, funcionarios.Email,
                                    funcionarios.Salario.ToString().Replace(",", "."), funcionarios.Comissao.ToString().Replace(",", "."), funcionarios.Horario_entrada.ToString("HH:mm"),
                                    funcionarios.Horario_saida.ToString("HH:mm"), funcionarios.Cep, funcionarios.Estado, funcionarios.Cidade, funcionarios.Bairro, funcionarios.Rua, 
                                    funcionarios.Numero, funcionarios.Complemento, funcionarios.Usuario, funcionarios.Senha, funcionarios.Tipo, funcionarios.Id);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Excluir(DTO_Funcionarios funcionarios)
        {
            try
            {
                sql = string.Format("delete from funcionario where id = '{0}'", funcionarios.Id);
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
                return bd.ConsultarTabelas("select ID, NOME, DATA_NASC as 'DATA DE NASCIMENTO', CPF, TELEFONE, EMAIL, SALARIO, COMISSAO, HORARIO_ENTRADA as 'HORARIO DE ENTRADA', HORARIO_SAIDA as 'HORARIO DE SAIDA', CEP, ESTADO, CIDADE, BAIRRO, RUA, NUMERO, COMPLEMENTO, USUARIO, SENHA, TIPO from funcionario order by id");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable Procurar(DTO_Funcionarios funcionarios)
        {
            try
            {
                sql = string.Format("select ID, NOME, DATA_NASC as 'DATA DE NASCIMENTO', CPF, TELEFONE, EMAIL, SALARIO, COMISSAO, HORARIO_ENTRADA as 'HORARIO DE ENTRADA', HORARIO_SAIDA as 'HORARIO DE SAIDA', CEP, ESTADO, CIDADE, BAIRRO, RUA, NUMERO, COMPLEMENTO, USUARIO, SENHA, TIPO from funcionario where {0} like '%{1}%'",
                      funcionarios.Pesquisar_campo, funcionarios.Pesquisar_valor);
                return bd.ConsultarTabelas(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}