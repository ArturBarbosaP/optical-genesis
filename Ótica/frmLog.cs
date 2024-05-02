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
using Ótica.PDF;

namespace Ótica
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        DTO_Log obj_dtoLog = new DTO_Log();
        //GerarPDFtabela pdf = new GerarPDFtabela();
        GerarPDFunico pdf = new GerarPDFunico();

        private void Limpar()
        {
            txt_id.Clear();
            txt_tabela.Clear();
            txt_tipo.Clear();
            txt_desc.Clear();
            dtp_data.Value = DateTime.Today;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Limpar();
            Close();
        }

        private void frmLog_Load(object sender, EventArgs e)
        {
            Limpar();

            txt_id.Text = obj_dtoLog.Id.ToString();
            txt_tabela.Text = obj_dtoLog.Tabela;
            txt_tipo.Text = obj_dtoLog.Tipo;
            txt_desc.Text = obj_dtoLog.Descricao;
            dtp_data.Value = obj_dtoLog.Data;
        }

        private void btn_relatorio_Click(object sender, EventArgs e)
        {
            try
            {
                if (fbdCaminhoPdf.ShowDialog() != DialogResult.OK || string.IsNullOrEmpty(fbdCaminhoPdf.SelectedPath))
                {
                    throw new Exception("Selecione uma pasta para salvar o PDF!");
                }

                string caminhoPasta = fbdCaminhoPdf.SelectedPath;
                caminhoPasta += @"\";

                float[] larguraColunas = { 0.8f, 2.5f, 2f, 2f };

                DataTable dataPDF = new DataTable();
                dataPDF.Columns.Add("ID:");
                dataPDF.Columns.Add("DATA:");
                dataPDF.Columns.Add("TABELA:");
                dataPDF.Columns.Add("TIPO:");
                dataPDF.Rows.Add(txt_id.Text, dtp_data.Value.ToShortDateString(), txt_tabela.Text, txt_tipo.Text);

                pdf.GerarRelatorioPDF(caminhoPasta, "Registro de Evento", "Registro de Evento", dataPDF, larguraColunas, txt_desc.Text);
                MessageBox.Show("Relatório gerado com sucesso!", "Gerar Registro de Evento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}