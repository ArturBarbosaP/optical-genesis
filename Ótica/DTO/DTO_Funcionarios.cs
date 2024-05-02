using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ótica.DTO
{
    class DTO_Funcionarios
    {
        private static int id, numero;
        private static double salario, comissao;
        private static string nome, cpf, telefone, email, cep, estado, cidade, bairro, rua, complemento, usuario, senha, tipo, pesquisar_campo, pesquisar_valor;
        private static bool clickBotao;
        private static DateTime data_nasc, horario_entrada, horario_saida;
        private Regex rgxTelefone = new Regex(@"^\((?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$");
        private Regex rgxEmail = new Regex("^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$");

        public int Id { get => id; set => id = value; }
        public bool ClickBotao { get => clickBotao; set => clickBotao = value; }
        public DateTime Data_nasc { get => data_nasc; set => data_nasc = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public DateTime Horario_entrada { get => horario_entrada; set => horario_entrada = value; }
        public DateTime Horario_saida { get => horario_saida; set => horario_saida = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public int Numero 
        { 
            get => numero; 
            set
            {
                if (value >= 0)
                {
                    numero = value;
                }
                else
                {
                    throw new Exception("Preencha o campo Número corretamente!");
                }
            }
        }

        public double Salario 
        {
            get => salario; 
            set
            {
                if (value >= 1)
                {
                    salario = value;
                }
                else
                {
                    throw new Exception("O Salário não pode ser zero ou negativo!");
                }
            }
        }

        public double Comissao 
        { 
            get => comissao;
            set
            {
                if (value >= 0)
                {
                    comissao = value;
                }
                else
                {
                    throw new Exception("A Comissão não pode ser negativa!");
                }
            }
        }

        public string Nome 
        { 
            get => nome;
            set
            {
                if (value.Trim() != string.Empty)
                {
                    nome = value;
                }
                else
                {
                    throw new Exception("Preencha o campo Nome corretamente!");
                }
            }
        }

        public string Email 
        {
            get => email;
            set
            {
                if (value.Trim() == string.Empty)
                {
                    throw new Exception("Preencha o campo Email corretamente!");
                }
                else if (!rgxEmail.IsMatch(value))
                {
                    throw new Exception("Email inválido!");
                }
                else
                {
                    email = value;
                }
            }
        }

        public string Telefone
        {
            get => telefone;
            set
            {
                if (value.Trim() == string.Empty)
                {
                    throw new Exception("Preencha o campo Telefone corretamente!");
                }
                else if (!rgxTelefone.IsMatch(value))
                {
                    throw new Exception("Telefone Inválido!");
                }
                else
                {
                    telefone = value;
                }
            }
        }

        public string Usuario 
        { 
            get => usuario;
            set
            {
                if (value.Trim() == string.Empty)
                {
                    throw new Exception("Preencha o campo Usuário corretamente!");
                }
                else if (value.Length < 4)
                {
                    throw new Exception("Usuário deve ter no mínimo 5 caracteres");
                }
                else
                {
                    usuario = value;
                }
            }
        }

        public string Senha 
        { 
            get => senha;
            set
            {
                if (value.Trim() == string.Empty)
                {
                    throw new Exception("Preencha o campo Senha corretamente!");
                }
                else if (value.Length < 4)
                {
                    throw new Exception("Senha deve ter no mínimo 5 caracteres");
                }
                else
                {
                    senha = value;
                }
            }
        }

        public string Pesquisar_campo
        {
            get => pesquisar_campo;
            set
            {
                if (value.Trim() != string.Empty)
                {
                    pesquisar_campo = value;
                }
                else
                {
                    throw new Exception("Preencha sua pesquisa corretamente!");
                }
            }
        }

        public string Pesquisar_valor
        {
            get => pesquisar_valor;
            set
            {
                if (value.Trim() != string.Empty)
                {
                    pesquisar_valor = value;
                }
                else
                {
                    throw new Exception("Preencha sua pesquisa corretamente!");
                }
            }
        }

        public string Estado
        {
            get => estado;
            set
            {
                if (value.Trim() != string.Empty)
                {
                    estado = value;
                }
                else
                {
                    throw new Exception("Preencha o campo Estado corretamente!");
                }
            }
        }

        public string Cidade
        {
            get => cidade;
            set
            {
                if (value.Trim() != string.Empty)
                {
                    cidade = value;
                }
                else
                {
                    throw new Exception("Preencha o campo Cidade corretamente!");
                }
            }
        }

        public string Bairro
        {
            get => bairro;
            set
            {
                if (value.Trim() != string.Empty)
                {
                    bairro = value;
                }
                else
                {
                    throw new Exception("Preencha o campo Bairro corretamente!");
                }
            }
        }

        public string Rua
        {
            get => rua;
            set
            {
                if (value.Trim() != string.Empty)
                {
                    rua = value;
                }
                else
                {
                    throw new Exception("Preencha o campo Rua corretamente!");
                }
            }
        }
    }
}