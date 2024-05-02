using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ótica.BLL;
using Ótica.DTO;

namespace Ótica
{
    public partial class frmListaProdutos : Form
    {
        public frmListaProdutos()
        {
            InitializeComponent();
        }

        frmCadProdutos produtos = new frmCadProdutos();
        BLL_Produtos obj_bllProdutos = new BLL_Produtos();
        DTO_Produtos obj_dtoProdutos = new DTO_Produtos();
        bool pesquisou = false, txtC = false;
        int cRow;

        private void Limpar()
        {
            txt_pesquisar.Clear();
            cbx_pesquisar.SelectedIndex = -1;
        }

        private void SelecionarRow()
        {
            try
            {
                dtg_produtos.CurrentCell = dtg_produtos[0, cRow];
            }
            catch (ArgumentOutOfRangeException)
            {
                if (dtg_produtos.RowCount != 0)
                {
                    dtg_produtos.CurrentCell = dtg_produtos[0, 0];
                }
            }
        }

        private void Listar()
        {
            dtg_produtos.DataSource = obj_bllProdutos.Listar();
            SelecionarRow();
        }

        private void Pesquisar()
        {
            obj_dtoProdutos.Pesquisar_campo = cbx_pesquisar.Texts.ToLower();
            obj_dtoProdutos.Pesquisar_valor = txt_pesquisar.Text.Replace(",", ".");
            dtg_produtos.DataSource = obj_bllProdutos.Procurar(obj_dtoProdutos);
            SelecionarRow();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            cRow = dtg_produtos.RowCount - 1;
            obj_dtoProdutos.ClickBotao = true;
            Limpar();
            produtos.ShowDialog();
        }

        private void frmListaProdutos_Load(object sender, EventArgs e)
        {
            Limpar();
            Listar();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (pesquisou == false || txtC)
                {
                    Pesquisar();
                    pesquisou = true;
                    txtC = false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro: Preencha os campos corretamente.", "Erro ao Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_pesquisar__TextChanged(object sender, EventArgs e)
        {

            if (txt_pesquisar.Text.Trim() == "" && pesquisou)
            {
                pesquisou = false;
                Listar();
            }
            else
            {
                txtC = true;
            }
        }

        private void dtg_produtos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dtg_produtos.Rows[e.RowIndex].Cells[0].Value = Properties.Resources.pencil_solid_white;
            dtg_produtos.Rows[e.RowIndex].Cells[0].ToolTipText = "Clique duas vezes para editar";
        }

        private void dtg_produtos_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dtg_produtos.Rows[e.RowIndex].Cells[0].Value = Properties.Resources.pencil_solid_dark;
        }

        private void dtg_produtos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                obj_dtoProdutos.Id = int.Parse(dtg_produtos.Rows[e.RowIndex].Cells[1].Value.ToString());
                obj_dtoProdutos.Nome = dtg_produtos.Rows[e.RowIndex].Cells[2].Value.ToString();
                obj_dtoProdutos.Marca = dtg_produtos.Rows[e.RowIndex].Cells[3].Value.ToString();
                obj_dtoProdutos.Fornecedor = dtg_produtos.Rows[e.RowIndex].Cells[4].Value.ToString();
                obj_dtoProdutos.Preco = double.Parse(dtg_produtos.Rows[e.RowIndex].Cells[5].Value.ToString());
                obj_dtoProdutos.Quantidade = int.Parse(dtg_produtos.Rows[e.RowIndex].Cells[6].Value.ToString());
                obj_dtoProdutos.Descricao = dtg_produtos.Rows[e.RowIndex].Cells[7].Value.ToString();

                cRow = dtg_produtos.CurrentCell.RowIndex;

                obj_dtoProdutos.ClickBotao = false;
                produtos.ShowDialog();
            }
            catch (ArgumentOutOfRangeException){}
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmListaProdutos_Activated(object sender, EventArgs e)
        {
            if (pesquisou)
            {
                Pesquisar();
            }
            else
            {
                Listar();
            }
        }
    }
}