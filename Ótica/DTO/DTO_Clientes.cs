using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ótica.DTO
{
    class DTO_Clientes
    {
        private static int id, numero;
        private static string nome, cpf, telefone, email, cep, estado, cidade, bairro, rua, complemento, pesquisar_campo, pesquisar_valor;
        private static DateTime data_nasc;
        private static bool clickBotao;
        private Regex rgxTelefone = new Regex(@"^\((?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$");
        private Regex rgxEmail = new Regex("^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$");

        public int Id { get => id; set => id = value; }
        public bool ClickBotao { get => clickBotao; set => clickBotao = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public DateTime Data_nasc { get => data_nasc; set => data_nasc = value; }

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
                    throw new Exception("O Número não pode ser negativo!");
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