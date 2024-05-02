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
    public partial class frmListaFuncionarios : Form
    {
        public frmListaFuncionarios()
        {
            InitializeComponent();
        }

        frmCadFuncionario funcionario = new frmCadFuncionario();
        BLL_Funcionarios obj_bllFuncionarios = new BLL_Funcionarios();
        DTO_Funcionarios obj_dtoFuncionarios = new DTO_Funcionarios();
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
                dtg_funcionarios.CurrentCell = dtg_funcionarios[0, cRow];
            }
            catch (ArgumentOutOfRangeException)
            {
                if (dtg_funcionarios.RowCount != 0)
                {
                    dtg_funcionarios.CurrentCell = dtg_funcionarios[0, 0];
                }
            }
        }

        private void Listar()
        {
            dtg_funcionarios.DataSource = obj_bllFuncionarios.Listar();
            SelecionarRow();
        }

        private void Pesquisar()
        {
            switch (cbx_pesquisar.SelectedIndex)
            {
                case 7:
                    obj_dtoFuncionarios.Pesquisar_campo = "horario_entrada";
                    break;
                case 8:
                    obj_dtoFuncionarios.Pesquisar_campo = "horario_saida";
                    break;
                default:
                    obj_dtoFuncionarios.Pesquisar_campo = cbx_pesquisar.Texts.ToLower();
                    break;
            }

            obj_dtoFuncionarios.Pesquisar_valor = txt_pesquisar.Text.Replace(",", ".");
            dtg_funcionarios.DataSource = obj_bllFuncionarios.Procurar(obj_dtoFuncionarios);
            SelecionarRow();
        }


        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            cRow = dtg_funcionarios.RowCount - 1;
            obj_dtoFuncionarios.ClickBotao = true;
            Limpar();
            funcionario.ShowDialog();
        }

        private void frmListaFuncionarios_Load(object sender, EventArgs e)
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

        private void dtg_funcionarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dtg_funcionarios.Rows[e.RowIndex].Cells[0].Value = Properties.Resources.pencil_solid_white;
            dtg_funcionarios.Rows[e.RowIndex].Cells[0].ToolTipText = "Clique duas vezes para editar";
        }

        private void dtg_funcionarios_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dtg_funcionarios.Rows[e.RowIndex].Cells[0].Value = Properties.Resources.pencil_solid_dark;
        }

        private void dtg_funcionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                obj_dtoFuncionarios.Id = int.Parse(dtg_funcionarios.Rows[e.RowIndex].Cells[1].Value.ToString());
                obj_dtoFuncionarios.Nome = dtg_funcionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                obj_dtoFuncionarios.Data_nasc = DateTime.Parse(dtg_funcionarios.Rows[e.RowIndex].Cells[3].Value.ToString());
                obj_dtoFuncionarios.Cpf = dtg_funcionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                obj_dtoFuncionarios.Telefone = dtg_funcionarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                obj_dtoFuncionarios.Email = dtg_funcionarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                obj_dtoFuncionarios.Salario = double.Parse(dtg_funcionarios.Rows[e.RowIndex].Cells[7].Value.ToString());
                obj_dtoFuncionarios.Comissao = double.Parse(dtg_funcionarios.Rows[e.RowIndex].Cells[8].Value.ToString());
                obj_dtoFuncionarios.Horario_entrada = DateTime.Parse(dtg_funcionarios.Rows[e.RowIndex].Cells[9].Value.ToString());
                obj_dtoFuncionarios.Horario_saida = DateTime.Parse(dtg_funcionarios.Rows[e.RowIndex].Cells[10].Value.ToString());
                obj_dtoFuncionarios.Cep = dtg_funcionarios.Rows[e.RowIndex].Cells[11].Value.ToString();
                obj_dtoFuncionarios.Estado = dtg_funcionarios.Rows[e.RowIndex].Cells[12].Value.ToString();
                obj_dtoFuncionarios.Cidade = dtg_funcionarios.Rows[e.RowIndex].Cells[13].Value.ToString();
                obj_dtoFuncionarios.Bairro = dtg_funcionarios.Rows[e.RowIndex].Cells[14].Value.ToString();
                obj_dtoFuncionarios.Rua = dtg_funcionarios.Rows[e.RowIndex].Cells[15].Value.ToString();
                obj_dtoFuncionarios.Numero = int.Parse(dtg_funcionarios.Rows[e.RowIndex].Cells[16].Value.ToString());
                obj_dtoFuncionarios.Complemento = dtg_funcionarios.Rows[e.RowIndex].Cells[17].Value.ToString();
                obj_dtoFuncionarios.Usuario = dtg_funcionarios.Rows[e.RowIndex].Cells[18].Value.ToString();
                obj_dtoFuncionarios.Senha = dtg_funcionarios.Rows[e.RowIndex].Cells[19].Value.ToString();
                obj_dtoFuncionarios.Tipo = dtg_funcionarios.Rows[e.RowIndex].Cells[20].Value.ToString();

                cRow = dtg_funcionarios.CurrentCell.RowIndex;

                obj_dtoFuncionarios.ClickBotao = false;
                funcionario.ShowDialog();
            }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmListaFuncionarios_Activated(object sender, EventArgs e)
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