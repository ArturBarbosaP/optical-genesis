using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ótica.DTO
{
    class DTO_Produtos
    {
        private static int id, quantidade;
        private static string nome, marca, fornecedor, descricao, pesquisar_campo, pesquisar_valor;
        private static double preco;
        private static bool clickBotao;

        public bool ClickBotao { get => clickBotao; set => clickBotao = value; }
        public int Id { get => id; set => id = value; }
        public int Quantidade 
        {
            get => quantidade;
            set
            {
                if (value >= 0)
                {
                    quantidade = value;
                }
                else
                {
                    throw new Exception("A quantidade não pode ser negativa!");
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

        public string Marca 
        { 
            get => marca;
            set
            {
                if (value.Trim() != string.Empty)
                {
                    marca = value;
                }
                else
                {
                    throw new Exception("Preencha o campo Marca corretamente!");
                }
            }
        }

        public string Fornecedor 
        { 
            get => fornecedor;
            set
            {
                if (value.Trim() != string.Empty)
                {
                    fornecedor = value;
                }
                else
                {
                    throw new Exception("Preencha o campo Fornecedor corretamente!");
                }
            }

        }

        public string Descricao 
        { 
            get => descricao;
            set
            {
                if (value.Trim() != string.Empty)
                {
                    descricao = value;
                }
                else
                {
                    throw new Exception("Preencha o campo Descrição corretamente!");
                }
            }
        }

        public double Preco 
        { 
            get => preco;
            set
            {
                if (value >= 0)
                {
                    preco = value;
                }
                else
                {
                    throw new Exception("O preço não pode ser negativo!");
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
    }
}