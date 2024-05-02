using System;
using System.Globalization;
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
    public partial class frmCadProdutos : Form
    {
        public frmCadProdutos()
        {
            InitializeComponent();
        }

        BLL_Produtos obj_bllProdutos = new BLL_Produtos();
        DTO_Produtos obj_dtoProdutos = new DTO_Produtos();

        private void Limpar()
        {
            txt_id.Clear();
            txt_nome.Clear();
            txt_marca.Clear();
            txt_fornecedor.Clear();
            txt_preco.Clear();
            txt_quantidade.Clear();
            txt_desc.Clear();
        }

        private void frmCadProdutos_Load(object sender, EventArgs e)
        {
            if (obj_dtoProdutos.ClickBotao)
            {
                Limpar();
            }
            else
            {
                txt_id.Text = obj_dtoProdutos.Id.ToString();
                txt_nome.Text = obj_dtoProdutos.Nome;
                txt_marca.Text = obj_dtoProdutos.Marca;
                txt_fornecedor.Text = obj_dtoProdutos.Fornecedor;
                txt_preco.Text = obj_dtoProdutos.Preco.ToString().Replace(".",",");
                txt_quantidade.Text = obj_dtoProdutos.Quantidade.ToString();
                txt_desc.Text = obj_dtoProdutos.Descricao;
            }
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            try
            {
                obj_dtoProdutos.Nome = txt_nome.Text;
                obj_dtoProdutos.Marca = txt_marca.Text;
                obj_dtoProdutos.Fornecedor = txt_fornecedor.Text;
                obj_dtoProdutos.Preco = double.Parse(txt_preco.Text.Replace(".", ","));
                obj_dtoProdutos.Quantidade = int.Parse(txt_quantidade.Text);
                obj_dtoProdutos.Descricao = txt_desc.Text;

                obj_bllProdutos.Cadastrar(obj_dtoProdutos);
                MessageBox.Show("Produto cadastrado com sucesso!", "Inserir Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro: Preencha os campos corretamente.", "Erro ao Inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao Inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_dtoProdutos.Nome = txt_nome.Text;
                obj_dtoProdutos.Marca = txt_marca.Text;
                obj_dtoProdutos.Fornecedor = txt_fornecedor.Text;
                obj_dtoProdutos.Preco = double.Parse(txt_preco.Text.Replace(".", ","));
                obj_dtoProdutos.Quantidade = int.Parse(txt_quantidade.Text);
                obj_dtoProdutos.Descricao = txt_desc.Text;
                obj_dtoProdutos.Id = int.Parse(txt_id.Text);

                obj_bllProdutos.Alterar(obj_dtoProdutos);
                MessageBox.Show("Produto alterado com sucesso!", "Alterar Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro: Preencha os campos corretamente.", "Erro ao Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                obj_dtoProdutos.Id = int.Parse(txt_id.Text);

                obj_bllProdutos.Excluir(obj_dtoProdutos);
                MessageBox.Show("Produto excluido com sucesso!", "Excluir Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_preco_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txt_preco, "R$");
        }
    }
}