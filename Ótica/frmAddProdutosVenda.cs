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
    public partial class frmAddProdutosVenda : Form
    {
        public frmAddProdutosVenda()
        {
            InitializeComponent();
        }

        frmAddQuantidade quantidade = new frmAddQuantidade();
        frmFinalizarVenda finalizar = new frmFinalizarVenda();
        BLL_Produtos obj_bllProdutos = new BLL_Produtos();
        DTO_Produtos obj_dtoProdutos = new DTO_Produtos();
        DTO_Lista obj_dtoLista = new DTO_Lista();
        bool pesquisou = false, txtC = false;
        int cRow;

        private void Limpar()
        {
            txt_pesquisar.Clear();
            cbx_pesquisar.SelectedIndex = -1;
            dtg_lista.Rows.Clear();
            cRow = 0;
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

        private void VerificarExistente()
        {
            for (int i = 0; i < dtg_lista.RowCount; i++)
            {
                if (int.Parse(dtg_produtos.SelectedCells[0].Value.ToString()) == int.Parse(dtg_lista.Rows[i].Cells[0].Value.ToString()))
                {
                    throw new Exception("Produto já inserido!");
                }
            }
        }

        private void VerificarQuantidade()
        {
            if (int.Parse(dtg_produtos.SelectedCells[5].Value.ToString()) == 0)
            {
                throw new Exception("Produto sem estoque!");
            }
            else if (obj_dtoLista.Quantidade > int.Parse(dtg_produtos.SelectedCells[5].Value.ToString()))
            {
                throw new Exception("Estoque insuficiente!");
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
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddProdutosVenda_Load(object sender, EventArgs e)
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

        private void frmAddProdutosVenda_Activated(object sender, EventArgs e)
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

        private void ipb_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_produtos.CurrentCell != null)
                {
                    cRow = dtg_produtos.CurrentCell.RowIndex;
                }
                else
                {
                    throw new Exception("Nenhum produto selecionado!");
                }
                VerificarExistente();
                obj_dtoLista.Quantidade = 0;
                VerificarQuantidade();
                obj_dtoLista.Cad = false;
                obj_dtoLista.Edit = false;
                quantidade.ShowDialog();
                VerificarQuantidade();
                if (!obj_dtoLista.BtnVoltar)
                {
                    dtg_lista.Rows.Add(dtg_produtos.SelectedCells[0].Value, dtg_produtos.SelectedCells[1].Value, obj_dtoLista.Quantidade, dtg_produtos.SelectedCells[4].Value);
                    MessageBox.Show("Produto adicionado com sucesso!", "Inserir Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Erro: Nenhum produto selecionado!", "Erro ao Adicionar Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao Inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtg_produtos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cRow = dtg_produtos.CurrentCell.RowIndex;
                VerificarExistente();
                VerificarQuantidade();
                obj_dtoLista.Cad = false;
                obj_dtoLista.Edit = false;
                quantidade.ShowDialog();
                VerificarQuantidade();
                if (!obj_dtoLista.BtnVoltar)
                {
                    dtg_lista.Rows.Add(dtg_produtos.SelectedCells[0].Value, dtg_produtos.SelectedCells[1].Value, obj_dtoLista.Quantidade, dtg_produtos.SelectedCells[4].Value);
                    MessageBox.Show("Produto adicionado com sucesso!", "Inserir Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao Inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ipb_remover_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_lista.CurrentCell != null)
                {
                    dtg_lista.Rows.RemoveAt(dtg_lista.CurrentCell.RowIndex);
                }
                else
                {
                    throw new Exception("Nenhum produto selecionado!");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Erro: Nenhum produto selecionado!", "Erro ao Remover Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_finz_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_lista.Rows.Count >= 1)
                {
                    DataTable data = new DataTable();
                    data.Columns.Add("ID");
                    data.Columns.Add("PRODUTO");
                    data.Columns.Add("QTD");
                    data.Columns.Add("PRECO");
                    for (int i = 0; i < dtg_lista.RowCount; i++)
                    {
                        data.Rows.Add(dtg_lista.Rows[i].Cells[0].Value, dtg_lista.Rows[i].Cells[1].Value, dtg_lista.Rows[i].Cells[2].Value, dtg_lista.Rows[i].Cells[3].Value);
                    }
                    obj_dtoLista.DataGV = data;
                    this.Visible = false;
                    finalizar.ShowDialog();
                    Limpar();
                    Close();
                }
                else
                {
                    throw new Exception("Nenhum produto inserido na venda!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_produtos.CurrentCell != null)
                {
                    cRow = dtg_produtos.CurrentCell.RowIndex;
                }
                else
                {
                    throw new Exception("Nenhum produto selecionado!");
                }
                VerificarExistente();
                VerificarQuantidade();
                obj_dtoLista.Cad = false;
                quantidade.ShowDialog();
                VerificarQuantidade();
                if (!obj_dtoLista.BtnVoltar)
                {
                    dtg_lista.Rows.Add(dtg_produtos.SelectedCells[0].Value, dtg_produtos.SelectedCells[1].Value, obj_dtoLista.Quantidade);
                    MessageBox.Show("Produto adicionado com sucesso!", "Inserir Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Erro: Nenhum produto selecionado!", "Erro ao Adicionar Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao Inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_remover_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_lista.CurrentCell != null)
                {
                    dtg_lista.Rows.RemoveAt(dtg_lista.CurrentCell.RowIndex);
                }
                else
                {
                    throw new Exception("Nenhum produto selecionado!");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Erro: Nenhum produto selecionado!", "Erro ao Remover Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}