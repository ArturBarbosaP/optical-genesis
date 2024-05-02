using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ótica.DTO
{
    class DTO_Lista
    {
        private static int produto_id, venda_id, quantidade, index;
        private static bool edit, cad, btnVoltar;
        private static DataTable dataGV;

        public DataTable DataGV { get => dataGV; set => dataGV = value; }
        public int Produto_id { get => produto_id; set => produto_id = value; }
        public int Venda_id { get => venda_id; set => venda_id = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public int Index { get => index; set => index = value; }
        public bool Edit { get => edit; set => edit = value; }
        public bool Cad { get => cad; set => cad = value; }
        public bool BtnVoltar { get => btnVoltar; set => btnVoltar = value; }
    }
}