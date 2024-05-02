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
using Ótica.PDF;

namespace Ótica
{
    public partial class frmGerente : Form
    {
        public frmGerente()
        {
            InitializeComponent();
        }

        BLL_Funcionarios obj_bllFuncionario = new BLL_Funcionarios();
        BLL_Clientes obj_bllClientes = new BLL_Clientes();
        BLL_Produtos obj_bllProdutos = new BLL_Produtos();
        BLL_Vendas obj_bllVendas = new BLL_Vendas();

        GerarPDFtabela pdf = new GerarPDFtabela();
        frmListaProdutos produtos = new frmListaProdutos();
        frmListaVendas vendas = new frmListaVendas();
        frmListaFuncionarios funcionarios = new frmListaFuncionarios();
        frmListaLog log = new frmListaLog();

        private void AbrirProdutos()
        {
            this.Visible = false;
            produtos.ShowDialog();
            this.Visible = true;
        }

        private void AbrirVendas()
        {
            this.Visible = false;
            vendas.ShowDialog();
            this.Visible = true;
        }

        private void AbrirFuncionarios()
        {
            this.Visible = false;
            funcionarios.ShowDialog();
            this.Visible = true;
        }

        private void lbl_produtos_Click(object sender, EventArgs e)
        {
            AbrirProdutos();
        }

        private void img_produtos_Click(object sender, EventArgs e)
        {
            AbrirProdutos();
        }

        private void lbl_vendas_Click(object sender, EventArgs e)
        {
            AbrirVendas();
        }

        private void img_vendas_Click(object sender, EventArgs e)
        {
            AbrirVendas();
        }

        private void lbl_funcionario_Click(object sender, EventArgs e)
        {
            AbrirFuncionarios();
        }

        private void img_funcionario_Click(object sender, EventArgs e)
        {
            AbrirFuncionarios();
        }

        private void img_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbl_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imi_log_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            log.ShowDialog();
            this.Visible = true;
        }

        private void imi_funcionarios_Click(object sender, EventArgs e)
        {
            try
            {
                dtg_listar.DataSource = obj_bllFuncionario.Listar();

                if (dtg_listar.RowCount > 0)
                {
                    if (fbdCaminhoPdf.ShowDialog() != DialogResult.OK || string.IsNullOrEmpty(fbdCaminhoPdf.SelectedPath))
                    {
                        throw new Exception("Selecione uma pasta para salvar o PDF!");
                    }

                    string caminhoPasta = fbdCaminhoPdf.SelectedPath;
                    caminhoPasta += @"\";

                    float[] larguraColunas = { 0.5f, 3f, 2f, 3f };

                    DataTable dataPDF = new DataTable();
                    dataPDF.Columns.Add("ID");
                    dataPDF.Columns.Add("NOME");
                    dataPDF.Columns.Add("CPF");
                    dataPDF.Columns.Add("TELEFONE");

                    for (int i = 0; i < dtg_listar.RowCount; i++)
                    {
                        dataPDF.Rows.Add(dtg_listar.Rows[i].Cells[0].Value, dtg_listar.Rows[i].Cells[1].Value, dtg_listar.Rows[i].Cells[3].Value, dtg_listar.Rows[i].Cells[4].Value);
                    }

                    pdf.GerarRelatorioPDF(caminhoPasta, "Relatório de Funcionários", "Relatório de Funcionários", dataPDF, larguraColunas);
                    MessageBox.Show("Relatório gerado com sucesso!", "Gerar Relatório de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Não há dados para gerar o relatório!");
                }

                dtg_listar.DataSource = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imi_clientes_Click(object sender, EventArgs e)
        {
            try
            {
                dtg_listar.DataSource = obj_bllClientes.Listar();

                if (dtg_listar.RowCount > 0)
                {
                    if (fbdCaminhoPdf.ShowDialog() != DialogResult.OK || string.IsNullOrEmpty(fbdCaminhoPdf.SelectedPath))
                    {
                        throw new Exception("Selecione uma pasta para salvar o PDF!");
                    }

                    string caminhoPasta = fbdCaminhoPdf.SelectedPath;
                    caminhoPasta += @"\";

                    float[] larguraColunas = { 0.5f, 3f, 2f, 3f };

                    DataTable dataPDF = new DataTable();
                    dataPDF.Columns.Add("ID");
                    dataPDF.Columns.Add("NOME");
                    dataPDF.Columns.Add("CPF");
                    dataPDF.Columns.Add("TELEFONE");

                    for (int i = 0; i < dtg_listar.RowCount; i++)
                    {
                        dataPDF.Rows.Add(dtg_listar.Rows[i].Cells[0].Value, dtg_listar.Rows[i].Cells[1].Value, dtg_listar.Rows[i].Cells[3].Value, dtg_listar.Rows[i].Cells[4].Value);
                    }

                    pdf.GerarRelatorioPDF(caminhoPasta, "Relatório de Clientes", "Relatório de Clientes", dataPDF, larguraColunas);
                    MessageBox.Show("Relatório gerado com sucesso!", "Gerar Relatório de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Não há dados para gerar o relatório!");
                }

                dtg_listar.DataSource = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imi_produtos_Click(object sender, EventArgs e)
        {
            try
            {
                dtg_listar.DataSource = obj_bllProdutos.Listar();

                if (dtg_listar.RowCount > 0)
                {
                    if (fbdCaminhoPdf.ShowDialog() != DialogResult.OK || string.IsNullOrEmpty(fbdCaminhoPdf.SelectedPath))
                    {
                        throw new Exception("Selecione uma pasta para salvar o PDF!");
                    }

                    string caminhoPasta = fbdCaminhoPdf.SelectedPath;
                    caminhoPasta += @"\";

                    float[] larguraColunas = { 0.5f, 2.5f, 2f, 1f, 0.5f };

                    DataTable dataPDF = new DataTable();
                    dataPDF.Columns.Add("ID");
                    dataPDF.Columns.Add("NOME");
                    dataPDF.Columns.Add("MARCA");
                    dataPDF.Columns.Add("R$");
                    dataPDF.Columns.Add("QTD");

                    for (int i = 0; i < dtg_listar.RowCount; i++)
                    {
                        dataPDF.Rows.Add(dtg_listar.Rows[i].Cells[0].Value, dtg_listar.Rows[i].Cells[1].Value, dtg_listar.Rows[i].Cells[2].Value, dtg_listar.Rows[i].Cells[4].Value, dtg_listar.Rows[i].Cells[5].Value);
                    }

                    pdf.GerarRelatorioPDF(caminhoPasta, "Relatório de Produtos", "Relatório de Produtos", dataPDF, larguraColunas);
                    MessageBox.Show("Relatório gerado com sucesso!", "Gerar Relatório de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Não há dados para gerar o relatório!");
                }

                dtg_listar.DataSource = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imi_vendas_Click(object sender, EventArgs e)
        {
            try
            {
                dtg_listar.DataSource = obj_bllVendas.Listar();

                if (dtg_listar.RowCount > 0)
                {
                    if (fbdCaminhoPdf.ShowDialog() != DialogResult.OK || string.IsNullOrEmpty(fbdCaminhoPdf.SelectedPath))
                    {
                        throw new Exception("Selecione uma pasta para salvar o PDF!");
                    }

                    string caminhoPasta = fbdCaminhoPdf.SelectedPath;
                    caminhoPasta += @"\";

                    float[] larguraColunas = { 0.5f, 2.5f, 2.5f, 2.5f };

                    DataTable dataPDF = new DataTable();
                    dataPDF.Columns.Add("ID");
                    dataPDF.Columns.Add("FORMA DE PAGAMENTO");
                    dataPDF.Columns.Add("FUNCIONARIO");
                    dataPDF.Columns.Add("CLIENTE");

                    for (int i = 0; i < dtg_listar.RowCount; i++)
                    {
                        dataPDF.Rows.Add(dtg_listar.Rows[i].Cells[0].Value, dtg_listar.Rows[i].Cells[2].Value, dtg_listar.Rows[i].Cells[4].Value, dtg_listar.Rows[i].Cells[5].Value);
                    }

                    pdf.GerarRelatorioPDF(caminhoPasta, "Relatório de Vendas", "Relatório de Vendas", dataPDF, larguraColunas);
                    MessageBox.Show("Relatório gerado com sucesso!", "Gerar Relatório de Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Não há dados para gerar o relatório!");
                }

                dtg_listar.DataSource = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}