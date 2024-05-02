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
    public partial class frmFinalizarVenda : Form
    {
        public frmFinalizarVenda()
        {
            InitializeComponent();
        }

        DTO_Lista obj_dtoLista = new DTO_Lista();
        BLL_Lista obj_bllLista = new BLL_Lista();
        DTO_Vendas obj_dtoVendas = new DTO_Vendas();
        BLL_Vendas obj_bllVendas = new BLL_Vendas();
        double precoFinal;

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

        private void frmFinalizarVenda_Load(object sender, EventArgs e)
        {
            txt_idCliente.Text = obj_dtoVendas.Cliente_id.ToString();
            txt_idFuncionario.Text = obj_dtoVendas.Funcionario_id.ToString();
            dtp_dataVenda.Value = DateTime.Today;
            dtg_produtos.DataSource = obj_dtoLista.DataGV;
            cbx_pagamento.SelectedIndex = -1;
            txt_obs.Clear();
            CalcularPrecoFinal();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbx_pagamento.SelectedItem == null)
                {
                    throw new Exception("Selecione uma forma de pagamento!");
                }
                obj_dtoVendas.Data_venda = dtp_dataVenda.Value;
                obj_dtoVendas.Forma_pagamento = cbx_pagamento.SelectedItem.ToString();
                obj_dtoVendas.Observacao = txt_obs.Text;

                obj_bllVendas.Cadastrar(obj_dtoVendas);

                obj_dtoLista.Venda_id = int.Parse(obj_bllVendas.UltimoIdInserido().Rows[0][0].ToString());
                
                for (int i = 0; i < dtg_produtos.RowCount; i++)
                {
                    obj_dtoLista.Produto_id = int.Parse(dtg_produtos.Rows[i].Cells[0].Value.ToString());
                    obj_dtoLista.Quantidade = int.Parse(dtg_produtos.Rows[i].Cells[2].Value.ToString());

                    obj_bllLista.Cadastrar(obj_dtoLista);
                }

                MessageBox.Show("Venda cadastrada com sucesso!", "Cadastro de Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
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
    }
}