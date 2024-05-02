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
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }

        frmCadCliente cliente = new frmCadCliente();
        BLL_Clientes obj_bllClientes = new BLL_Clientes();
        DTO_Clientes obj_dtoClientes = new DTO_Clientes();
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
                dtg_clientes.CurrentCell = dtg_clientes[0, cRow];
            }
            catch (ArgumentOutOfRangeException)
            {
                if (dtg_clientes.RowCount != 0)
                {
                    dtg_clientes.CurrentCell = dtg_clientes[0, 0];
                }
            }
        }

        private void Listar()
        {
            dtg_clientes.DataSource = obj_bllClientes.Listar();
            SelecionarRow();
        }

        private void Pesquisar()
        {
            obj_dtoClientes.Pesquisar_campo = cbx_pesquisar.Texts.ToLower();
            obj_dtoClientes.Pesquisar_valor = txt_pesquisar.Text.Replace(",", ".");
            dtg_clientes.DataSource = obj_bllClientes.Procurar(obj_dtoClientes);
            SelecionarRow();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            cRow = dtg_clientes.RowCount - 1;
            obj_dtoClientes.ClickBotao = true;
            Limpar();
            cliente.ShowDialog();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
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

        private void dtg_clientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dtg_clientes.Rows[e.RowIndex].Cells[0].Value = Properties.Resources.pencil_solid_white;
            dtg_clientes.Rows[e.RowIndex].Cells[0].ToolTipText = "Clique duas vezes para editar";
        }

        private void dtg_clientes_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dtg_clientes.Rows[e.RowIndex].Cells[0].Value = Properties.Resources.pencil_solid_dark;
        }

        private void dtg_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                obj_dtoClientes.Id = int.Parse(dtg_clientes.Rows[e.RowIndex].Cells[1].Value.ToString());
                obj_dtoClientes.Nome = dtg_clientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                obj_dtoClientes.Data_nasc = DateTime.Parse(dtg_clientes.Rows[e.RowIndex].Cells[3].Value.ToString());
                obj_dtoClientes.Cpf = dtg_clientes.Rows[e.RowIndex].Cells[4].Value.ToString();
                obj_dtoClientes.Telefone = dtg_clientes.Rows[e.RowIndex].Cells[5].Value.ToString();
                obj_dtoClientes.Email = dtg_clientes.Rows[e.RowIndex].Cells[6].Value.ToString();
                obj_dtoClientes.Cep = dtg_clientes.Rows[e.RowIndex].Cells[7].Value.ToString();
                obj_dtoClientes.Estado = dtg_clientes.Rows[e.RowIndex].Cells[8].Value.ToString();
                obj_dtoClientes.Cidade = dtg_clientes.Rows[e.RowIndex].Cells[9].Value.ToString();
                obj_dtoClientes.Bairro = dtg_clientes.Rows[e.RowIndex].Cells[10].Value.ToString();
                obj_dtoClientes.Rua = dtg_clientes.Rows[e.RowIndex].Cells[11].Value.ToString();
                obj_dtoClientes.Numero = int.Parse(dtg_clientes.Rows[e.RowIndex].Cells[12].Value.ToString());
                obj_dtoClientes.Complemento = dtg_clientes.Rows[e.RowIndex].Cells[13].Value.ToString();

                cRow = dtg_clientes.CurrentCell.RowIndex;

                obj_dtoClientes.ClickBotao = false;
                cliente.ShowDialog();
            }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmListaClientes_Activated(object sender, EventArgs e)
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