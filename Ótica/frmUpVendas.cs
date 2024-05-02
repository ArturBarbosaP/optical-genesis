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
    public partial class frmUpVendas : Form
    {
        public frmUpVendas()
        {
            InitializeComponent();
        }

        frmEditarProdutos editarProdutos = new frmEditarProdutos();
        BLL_Vendas obj_bllVendas = new BLL_Vendas();
        DTO_Vendas obj_dtoVendas = new DTO_Vendas();

        BLL_Lista obj_bllLista = new BLL_Lista();
        DTO_Lista obj_dtoLista = new DTO_Lista();
        int cRow;
        double precoFinal;

        private void Limpar()
        {
            txt_idCliente.Clear();
            txt_idFuncionario.Clear();
            txt_idVenda.Clear();
            txt_obs.Clear();
            txt_preco.Clear();
            cbx_pagamento.SelectedIndex = -1;
            dtp_dataVenda.Value = DateTime.Today;
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

        private void VerificarCBX()
        {
            if (cbx_pagamento.SelectedIndex == -1 || cbx_pagamento.SelectedItem == null)
            {
                throw new Exception("Preencha o campo Forma de Pagamento corretamente!");
            }
        }

        private void CalcularPrecoFinal()
        {
            precoFinal = 0;
            try
            {
                for (int i = 0; i < dtg_produtos.RowCount; i++)
                {
                    precoFinal += (int.Parse(dtg_produtos.Rows[i].Cells[2].Value.ToString()) * double.Parse(dtg_produtos.Rows[i].Cells[3].Value.ToString()));
                }
                txt_preco.Text = precoFinal.ToString("C");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Listar()
        {
            dtg_produtos.DataSource = obj_bllVendas.ProdutosVenda(obj_dtoVendas);
            SelecionarRow();
        }

        private void frmCadVendas_Load(object sender, EventArgs e)
        {
            Listar();
            txt_idCliente.Text = obj_dtoVendas.Cliente_id.ToString();
            txt_idFuncionario.Text = obj_dtoVendas.Funcionario_id.ToString();
            txt_idVenda.Text = obj_dtoVendas.Id.ToString();
            txt_obs.Text = obj_dtoVendas.Observacao;
            cbx_pagamento.SelectedItem = obj_dtoVendas.Forma_pagamento.ToString();
            dtp_dataVenda.Value = obj_dtoVendas.Data_venda;
            CalcularPrecoFinal();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarCBX();
                obj_dtoVendas.Data_venda = dtp_dataVenda.Value;
                obj_dtoVendas.Forma_pagamento = cbx_pagamento.SelectedItem.ToString();
                obj_dtoVendas.Observacao = txt_obs.Text;
                obj_dtoVendas.Funcionario_id = int.Parse(txt_idFuncionario.Text);
                obj_dtoVendas.Cliente_id = int.Parse(txt_idCliente.Text);
                obj_dtoVendas.Id = int.Parse(txt_idVenda.Text);

                obj_bllVendas.Alterar(obj_dtoVendas);
                MessageBox.Show("Venda alterada com sucesso!", "Alterar Cadastro de Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro: Preencha os campos corretamente.", "Erro ao Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
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
                obj_dtoVendas.Id = int.Parse(txt_idVenda.Text);
                obj_dtoLista.Venda_id = obj_dtoVendas.Id;

                obj_bllVendas.Excuir(obj_dtoVendas);
                obj_bllLista.Excluir(obj_dtoLista);
                MessageBox.Show("Venda excluida com sucesso!", "Excluir Cadastro de Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro: Preencha os campos corretamente.", "Erro ao Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtg_produtos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cRow = dtg_produtos.CurrentCell.RowIndex;
                editarProdutos.ShowDialog();
            }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_produtos_Click(object sender, EventArgs e)
        {
            editarProdutos.ShowDialog();
        }

        private void frmUpVendas_Activated(object sender, EventArgs e)
        {
            Listar();
            CalcularPrecoFinal();
        }
    }
}