using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ótica.DTO
{
    class DTO_Vendas
    {
        private static int id, funcionario_id, cliente_id;
        private static DateTime data_venda, pesquisar_data1, pesquisar_data2;
        private static string forma_pagamento, observacao, pesquisar_campo, pesquisar_valor;
        private static bool pesquisaCampo;

        public DateTime Pesquisar_dataI { get => pesquisar_data1; set => pesquisar_data1 = value; }
        public DateTime Pesquisar_dataF { get => pesquisar_data2; set => pesquisar_data2 = value; }
        public int Id { get => id; set => id = value; }
        public bool PesquisaCampo { get => pesquisaCampo; set => pesquisaCampo = value; }
        public DateTime Data_venda { get => data_venda; set => data_venda = value; }
        public string Observacao { get => observacao; set => observacao = value; }

        public int Funcionario_id 
        { 
            get => funcionario_id;
            set
            {
                if (value >= 1)
                {
                    funcionario_id = value;
                }
                else
                {
                    throw new Exception("O Id do Funcionário não pode ser zero ou negativo!");
                }
            }
        }

        public int Cliente_id 
        { 
            get => cliente_id;
            set
            {
                if (value >= 0)
                {
                    cliente_id = value;
                }
                else
                {
                    throw new Exception("O Id do Cliente não pode ser negativo!");
                }
            }
        }

        public string Forma_pagamento
        {
            get => forma_pagamento;
            set
            {
                if (value.Trim() != string.Empty || value.Trim() != null)
                {
                    forma_pagamento = value;
                }
                else
                {
                    throw new Exception("Preencha o campo Forma de Pagamento corretamente!");
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