using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ótica.DTO
{
    class DTO_Log
    {
        private static int id;
        private static string tabela, tipo, descricao, pesquisar_campo, pesquisar_valor;
        private static DateTime data, pesquisar_data1, pesquisar_data2;
        private static bool pesquisaCampo;

        public string Tabela { get => tabela; set => tabela = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Descricao { get => descricao; set => descricao = value; }

        public bool PesquisaCampo { get => pesquisaCampo; set => pesquisaCampo = value; }

        public DateTime Pesquisar_dataI { get => pesquisar_data1; set => pesquisar_data1 = value; }
        public DateTime Pesquisar_dataF { get => pesquisar_data2; set => pesquisar_data2 = value; }
        public DateTime Data { get => data; set => data = value; }

        public int Id { get => id; set => id = value; }

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