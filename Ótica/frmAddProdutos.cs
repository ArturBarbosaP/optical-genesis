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
    public partial class frmAddProdutos : Form
    {
        public frmAddProdutos()
        {
            InitializeComponent();
        }

        frmAddQuantidade quantidade = new frmAddQuantidade();

        BLL_Produtos obj_bllProdutos = new BLL_Produtos();
        DTO_Produtos obj_dtoProdutos = new DTO_Produtos();

        DTO_Lista obj_dtoLista = new DTO_Lista();

        DTO_Vendas obj_dtoVendas = new DTO_Vendas();

        bool pesquisou = false;

        private void Limpar()
        {
            txt_pesquisar.Clear();
            cbx_pesquisar.SelectedIndex = -1;
        }

        private void Listar()
        {
            dtg_produtos.DataSource = obj_bllProdutos.Listar();
        }

        private void Pesquisar()
        {
            obj_dtoProdutos.Pesquisar_campo = cbx_pesquisar.Texts.ToLower();
            obj_dtoProdutos.Pesquisar_valor = txt_pesquisar.Text.Replace(",", ".");
            dtg_produtos.DataSource = obj_bllProdutos.Procurar(obj_dtoProdutos);
            pesquisou = true;
        }

        private void VerificarQuantidade()
        {
            if (int.Parse(dtg_produtos.SelectedCells[5].Value.ToString()) == 0)
            {
                throw new Exception("Produto sem estoque!");
            }
        }

        private void ApagarPesquisa()
        {
            if (txt_pesquisar.Text.Trim() == "" && pesquisou)
            {
                Listar();
                pesquisou = false;
                txt_pesquisar.Clear();
            }
            else
            {
                pesquisou = false;
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEditarProdutos_Load(object sender, EventArgs e)
        {
            Limpar();
            Listar();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (pesquisou == false)
                {
                    Pesquisar();
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
            ApagarPesquisa();
        }

        private void frmEditarProdutos_Activated(object sender, EventArgs e)
        {
            ApagarPesquisa();
            if (pesquisou)
            {
                Pesquisar();
            }
            else
            {
                Listar();
            }
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarQuantidade();
                obj_dtoLista.Edit = false;
                obj_dtoLista.Cad = true;
                obj_dtoLista.Produto_id = int.Parse(dtg_produtos.SelectedCells[0].Value.ToString());
                obj_dtoLista.Venda_id = obj_dtoVendas.Id;

                quantidade.ShowDialog();
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtg_produtos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                VerificarQuantidade();
                obj_dtoLista.Edit = false;
                obj_dtoLista.Cad = true;
                obj_dtoLista.Produto_id = int.Parse(dtg_produtos.Rows[e.RowIndex].Cells[0].Value.ToString());
                obj_dtoLista.Venda_id = obj_dtoVendas.Id;

                quantidade.ShowDialog();
                Close();
            }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}