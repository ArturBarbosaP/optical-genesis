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
using Ótica.PDF;

namespace Ótica
{
    public partial class frmListaLog : Form
    {
        public frmListaLog()
        {
            InitializeComponent();
        }

        frmLog log = new frmLog();
        DTO_Log obj_dtoLog = new DTO_Log();
        BLL_Log obj_bllLog = new BLL_Log();
        GerarPDFtabela pdf = new GerarPDFtabela();
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
                dtg_log.CurrentCell = dtg_log[0, cRow];
            }
            catch (ArgumentOutOfRangeException)
            {
                if (dtg_log.RowCount != 0)
                {
                    dtg_log.CurrentCell = dtg_log[0, 0];
                }
            }
        }

        private void Listar()
        {
            dtg_log.DataSource = obj_bllLog.Listar();
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
                    obj_dtoLog.PesquisaCampo = false;
                    obj_dtoLog.Pesquisar_dataI = dtp_inicio.Value;
                    obj_dtoLog.Pesquisar_dataF = dtp_fim.Value;
                }
            }
            else
            {
                if (dtp_inicio.Value == DateTime.Today && dtp_fim.Value == DateTime.Today)
                {
                    obj_dtoLog.Pesquisar_dataI = DateTime.MinValue;
                    obj_dtoLog.Pesquisar_dataF = DateTime.MaxValue;
                }
                else
                {
                    obj_dtoLog.Pesquisar_dataI = dtp_inicio.Value;
                    obj_dtoLog.Pesquisar_dataF = dtp_fim.Value;
                }

                obj_dtoLog.PesquisaCampo = true;
                obj_dtoLog.Pesquisar_campo = cbx_pesquisar.Texts.ToLower();
                obj_dtoLog.Pesquisar_valor = txt_pesquisar.Text.Replace(",", ".");
            }

            dtg_log.DataSource = obj_bllLog.Procurar(obj_dtoLog);
            SelecionarRow();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_visu_Click(object sender, EventArgs e)
        {
            try
            {
                cRow = dtg_log.CurrentCell.RowIndex;

                obj_dtoLog.Id = int.Parse(dtg_log.SelectedCells[0].Value.ToString());
                obj_dtoLog.Data = DateTime.Parse(dtg_log.SelectedCells[1].Value.ToString());
                obj_dtoLog.Tabela = dtg_log.SelectedCells[2].Value.ToString();
                obj_dtoLog.Tipo = dtg_log.SelectedCells[3].Value.ToString();
                obj_dtoLog.Descricao = dtg_log.SelectedCells[4].Value.ToString();

                log.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmListaLog_Load(object sender, EventArgs e)
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

        private void dtg_log_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cRow = dtg_log.CurrentCell.RowIndex;

                obj_dtoLog.Id = int.Parse(dtg_log.Rows[e.RowIndex].Cells[0].Value.ToString());
                obj_dtoLog.Data = DateTime.Parse(dtg_log.Rows[e.RowIndex].Cells[1].Value.ToString());
                obj_dtoLog.Tabela = dtg_log.Rows[e.RowIndex].Cells[2].Value.ToString();
                obj_dtoLog.Tipo = dtg_log.Rows[e.RowIndex].Cells[3].Value.ToString();
                obj_dtoLog.Descricao = dtg_log.Rows[e.RowIndex].Cells[4].Value.ToString();

                log.ShowDialog();
            }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmListaLog_Activated(object sender, EventArgs e)
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

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Excluir todos os Registros de Eventos? \n(IRREVERSÍVEL)", "Excluir Registro de Eventos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    obj_bllLog.Excluir();
                    MessageBox.Show("Registros de Eventos excluidos com sucesso!", "Excluir Registro de Eventos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_relatorio_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_log.RowCount > 0)
                {
                    if (fbdCaminhoPdf.ShowDialog() != DialogResult.OK || string.IsNullOrEmpty(fbdCaminhoPdf.SelectedPath))
                    {
                        throw new Exception("Selecione uma pasta para salvar o PDF!");
                    }

                    string caminhoPasta = fbdCaminhoPdf.SelectedPath;
                    caminhoPasta += @"\";

                    float[] larguraColunas = { 0.8f, 2.5f, 2f, 2f };

                    DataTable dataPDF = new DataTable();
                    dataPDF.Columns.Add("ID");
                    dataPDF.Columns.Add("DATA");
                    dataPDF.Columns.Add("TABELA");
                    dataPDF.Columns.Add("TIPO");
                    for (int i = 0; i < dtg_log.RowCount; i++)
                    {
                        dataPDF.Rows.Add(dtg_log.Rows[i].Cells[0].Value, dtg_log.Rows[i].Cells[1].Value, dtg_log.Rows[i].Cells[2].Value, dtg_log.Rows[i].Cells[3].Value);
                    }

                    pdf.GerarRelatorioPDF(caminhoPasta, "Relatório de Eventos", "Relatório de Eventos", dataPDF, larguraColunas);
                    MessageBox.Show("Relatório gerado com sucesso!", "Gerar Relatório de Eventos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Não há dados para gerar o relatório!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}