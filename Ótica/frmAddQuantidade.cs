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
    public partial class frmAddQuantidade : Form
    {
        public frmAddQuantidade()
        {
            InitializeComponent();
        }

        DTO_Lista obj_dtoLista = new DTO_Lista();
        BLL_Lista obj_bllLista = new BLL_Lista();

        private void Limpar()
        {
            txt_quantidade.Clear();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_dtoLista.Quantidade = int.Parse(txt_quantidade.Text);

                if (obj_dtoLista.Edit)
                {
                    obj_bllLista.Alterar(obj_dtoLista);
                    MessageBox.Show("Quantidade alterada com sucesso!", "Editar Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (obj_dtoLista.Cad)
                    {
                        obj_bllLista.Cadastrar(obj_dtoLista);
                        MessageBox.Show("Produto adicionado com sucesso!", "Inserir Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                obj_dtoLista.BtnVoltar = false;
                Limpar();
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro: Preencha os campos corretamente.", "Erro ao Inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            obj_dtoLista.BtnVoltar = false;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            obj_dtoLista.BtnVoltar = true;
            Close();
            Limpar();
        }

        private void frmAddQuantidade_Load(object sender, EventArgs e)
        {
            if (obj_dtoLista.Edit)
            {
                btn_adicionar.Text = "Editar";
                this.Text = "Editar Quantidade";
                toolTip1.SetToolTip(btn_adicionar, "Editar");
            }
            else
            {
                btn_adicionar.Text = "Adicionar";
                this.Text = "Adicionar Quantidade";
                toolTip1.SetToolTip(btn_adicionar, "Adicionar");
            }

            Limpar();
            txt_quantidade.Focus();
        }
    }
}