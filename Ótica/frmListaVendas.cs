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
    public partial class frmListaVendas : Form
    {
        public frmListaVendas()
        {
            InitializeComponent();
        }

        frmUpVendas vendas = new frmUpVendas();
        frmListaClientes clientes = new frmListaClientes();
        frmEscolherCliente escCliente = new frmEscolherCliente();
        frmCadCliente cadCliente = new frmCadCliente();
        BLL_Vendas obj_bllVendas = new BLL_Vendas();
        DTO_Vendas obj_dtoVendas = new DTO_Vendas();
        BLL_Login obj_bllLogin = new BLL_Login();
        DTO_Clientes obj_dtoClientes = new DTO_Clientes();
        bool pesquisou = false, txtC = false;
        int cRow;

        private void Limpar()
        {
            txt_pesquisar.Clear();
            cbx_pesquisar.SelectedIndex = -1;
            dtp_inicio.Value = DateTime.Today;
            dtp_fim.Value = DateTime.Today;
        }

        private void SelecionarRow()
        {
            try
            {
                dtg_vendas.CurrentCell = dtg_vendas[0, cRow];
            }
            catch (ArgumentOutOfRangeException)
            {
                if (dtg_vendas.RowCount != 0)
                {
                    dtg_vendas.CurrentCell = dtg_vendas[0, 0];
                }
            }
        }

        private void Listar()
        {
            dtg_vendas.DataSource = obj_bllVendas.Listar();
            SelecionarRow();
        }

        private void Pesquisar()
        {

            if (txt_pesquisar.Text.Trim() == "" || cbx_pesquisar.SelectedIndex == -1)
            {
                if (dtp_inicio.Value == DateTime.Today && dtp_fim.Value == DateTime.Today)
                {
                    throw new Exception("Preencha os campos corretamente.");
                }
                else
                {
                    obj_dtoVendas.PesquisaCampo = false;
                    obj_dtoVendas.Pesquisar_dataI = dtp_inicio.Value;
                    obj_dtoVendas.Pesquisar_dataF = dtp_fim.Value;
                }
            }
            else
            {
                if (dtp_inicio.Value == DateTime.Today && dtp_fim.Value == DateTime.Today)
                {
                    obj_dtoVendas.Pesquisar_dataI = DateTime.MinValue;
                    obj_dtoVendas.Pesquisar_dataF = DateTime.MaxValue;
                }
                else
                {
                    obj_dtoVendas.Pesquisar_dataI = dtp_inicio.Value;
                    obj_dtoVendas.Pesquisar_dataF = dtp_fim.Value;
                }

                obj_dtoVendas.PesquisaCampo = true;

                switch (cbx_pesquisar.SelectedIndex)
                {
                    case 1:
                        obj_dtoVendas.Pesquisar_campo = "forma_pagamento";
                        break;
                    case 3:
                        obj_dtoVendas.Pesquisar_campo = "funcionario_id_fk";
                        break;
                    case 4:
                        obj_dtoVendas.Pesquisar_campo = "cliente_id_fk";
                        break;
                    default:
                        obj_dtoVendas.Pesquisar_campo = cbx_pesquisar.Texts.ToLower();
                        break;
                }

                obj_dtoVendas.Pesquisar_valor = txt_pesquisar.Text.Replace(",", ".");
            }

            dtg_vendas.DataSource = obj_bllVendas.Procurar(obj_dtoVendas);
            SelecionarRow();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cadVenda_Click(object sender, EventArgs e)
        {
            obj_dtoVendas.Funcionario_id = obj_bllLogin.UsuarioLogado();
            this.Visible = false;
            escCliente.ShowDialog();
            this.Visible = true;
            cRow = dtg_vendas.RowCount - 1;
            Limpar();
        }

        private void btn_visuCliente_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            clientes.ShowDialog();
            this.Visible = true;
        }

        private void frmListaVendas_Load(object sender, EventArgs e)
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

        private void dtg_vendas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dtg_vendas.Rows[e.RowIndex].Cells[0].Value = Properties.Resources.pencil_solid_white;
            dtg_vendas.Rows[e.RowIndex].Cells[0].ToolTipText = "Clique duas vezes para editar";
        }

        private void dtg_vendas_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dtg_vendas.Rows[e.RowIndex].Cells[0].Value = Properties.Resources.pencil_solid_dark;
        }

        private void dtg_vendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cRow = dtg_vendas.CurrentCell.RowIndex;
                dtg_vendas.DataSource = obj_bllVendas.ClicarDTG();

                obj_dtoVendas.Id = int.Parse(dtg_vendas.Rows[e.RowIndex].Cells[1].Value.ToString());
                obj_dtoVendas.Data_venda = DateTime.Parse(dtg_vendas.Rows[e.RowIndex].Cells[2].Value.ToString());
                obj_dtoVendas.Forma_pagamento = dtg_vendas.Rows[e.RowIndex].Cells[3].Value.ToString();
                obj_dtoVendas.Observacao = dtg_vendas.Rows[e.RowIndex].Cells[4].Value.ToString();
                obj_dtoVendas.Funcionario_id = int.Parse(dtg_vendas.Rows[e.RowIndex].Cells[5].Value.ToString());
                obj_dtoVendas.Cliente_id = int.Parse(dtg_vendas.Rows[e.RowIndex].Cells[6].Value.ToString());

                vendas.ShowDialog();
            }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmListaVendas_Activated(object sender, EventArgs e)
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

        private void dtp_inicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_inicio.Value == DateTime.Today && pesquisou)
            {
                Listar();
                pesquisou = false;
            }
            else
            {
                pesquisou = false;
            }
        }

        private void dtp_fim_ValueChanged(object sender, EventArgs e)
        {
            pesquisou = false;
        }

        private void btn_cadCliente_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            obj_dtoClientes.ClickBotao = true;
            cadCliente.ShowDialog();
            clientes.ShowDialog();
            this.Visible = true;
        }
    }
}