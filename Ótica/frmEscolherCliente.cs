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
    public partial class frmEscolherCliente : Form
    {
        public frmEscolherCliente()
        {
            InitializeComponent();
        }

        frmAddProdutosVenda terminarVenda = new frmAddProdutosVenda();
        BLL_Clientes obj_bllClientes = new BLL_Clientes();
        DTO_Clientes obj_dtoClientes = new DTO_Clientes();
        DTO_Vendas obj_dtoVendas = new DTO_Vendas();
        bool pesquisou = false, txtC = false;

        private void Limpar()
        {
            txt_pesquisar.Clear();
            cbx_pesquisar.SelectedIndex = -1;
        }

        private void Listar()
        {
            dtg_clientes.DataSource = obj_bllClientes.Listar();
        }

        private void Pesquisar()
        {
            obj_dtoClientes.Pesquisar_campo = cbx_pesquisar.Texts.ToLower();
            obj_dtoClientes.Pesquisar_valor = txt_pesquisar.Text.Replace(",", ".");
            dtg_clientes.DataSource = obj_bllClientes.Procurar(obj_dtoClientes);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEscolherCliente_Load(object sender, EventArgs e)
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

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            obj_dtoVendas.Cliente_id = 0;
            this.Visible = false;
            terminarVenda.ShowDialog();
            Close();
        }

        private void btn_selecCliente_Click(object sender, EventArgs e)
        {
            try
            {
                obj_dtoVendas.Cliente_id = int.Parse(dtg_clientes.SelectedCells[0].Value.ToString());
                this.Visible = false;
                terminarVenda.ShowDialog();
                Close();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Erro: Nenhum cliente selecionado!", "Erro ao Selecionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao Selecionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtg_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            obj_dtoVendas.Cliente_id = int.Parse(dtg_clientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.Visible = false;
            terminarVenda.ShowDialog();
            Close();
        }
    }
}