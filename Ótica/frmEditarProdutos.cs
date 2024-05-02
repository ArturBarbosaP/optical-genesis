using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ótica.DTO;
using Ótica.BLL;

namespace Ótica
{
    public partial class frmEditarProdutos : Form
    {
        public frmEditarProdutos()
        {
            InitializeComponent();
        }

        frmAddProdutos addProdutos = new frmAddProdutos();
        frmAddQuantidade addQuantidade = new frmAddQuantidade();

        DTO_Lista obj_dtoLista = new DTO_Lista();
        BLL_Lista obj_bllLista = new BLL_Lista();
        DTO_Vendas obj_dtoVendas = new DTO_Vendas();
        BLL_Vendas obj_bllVendas = new BLL_Vendas();
        int cRow;

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
            dtg_produtos.DataSource = obj_bllVendas.ProdutosVenda(obj_dtoVendas);
            SelecionarRow();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                obj_dtoLista.Venda_id = obj_dtoVendas.Id;
                obj_dtoLista.Produto_id = int.Parse(dtg_produtos.SelectedCells[1].Value.ToString());

                obj_bllLista.ExcluirProduto(obj_dtoLista);
                Listar();
                MessageBox.Show("Produto excluido com sucesso!", "Excluir Produto da Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Erro: Nenhum produto selecionado!", "Erro ao Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro: Preencha os campos corretamente.", "Erro ao Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEditarProdutos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            addProdutos.ShowDialog();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEditarProdutos_Activated(object sender, EventArgs e)
        {
            Listar();
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
                cRow = dtg_produtos.CurrentCell.RowIndex;
                obj_dtoLista.Edit = true;
                obj_dtoLista.Cad = true;
                obj_dtoLista.Venda_id = obj_dtoVendas.Id;
                obj_dtoLista.Produto_id = int.Parse(dtg_produtos.Rows[e.RowIndex].Cells[1].Value.ToString());
                addQuantidade.ShowDialog();

            }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}