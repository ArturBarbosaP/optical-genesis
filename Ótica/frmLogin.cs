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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        BLL_Login obj_bllLogin = new BLL_Login();
        DTO_Login obj_dtoLogin = new DTO_Login();

        frmListaVendas vendas = new frmListaVendas();
        frmListaProdutos produtos = new frmListaProdutos();
        frmGerente gerente = new frmGerente();
        frmCadFuncionario funcionario = new frmCadFuncionario();

        private void Limpar()
        {
            txt_senha.Clear();
            txt_usuario.Clear();
            lbl_erro.Visible = false;
            lbl_erro.Text = "";
            tgb_senha.CheckState = CheckState.Unchecked;
        }

        private void MostrarSenha()
        {
            if (txt_senha.Text != "")
            {
                if (tgb_senha.Checked)
                {
                    txt_senha.PasswordChar = false;
                }
                else
                {
                    txt_senha.PasswordChar = true;
                }
            }
            else
            {
                txt_senha.PasswordChar = false;
            }
        }

        private void Erro(string erro)
        {
            lbl_erro.Text = erro;
            lbl_erro.Visible = true;
            System.Media.SystemSounds.Hand.Play();
            toolTip1.SetToolTip(lbl_erro, erro);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Limpar();
        }

        private void tgb_senha_CheckedChanged(object sender, EventArgs e)
        {
            MostrarSenha();
            if (tgb_senha.Checked)
            {
                toolTip1.SetToolTip(tgb_senha, "Esconder Senha");
            }
            else
            {
                toolTip1.SetToolTip(tgb_senha, "Mostrar Senha");
            }
        }

        private void txt_senha__TextChanged(object sender, EventArgs e)
        {
            MostrarSenha();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_dtoLogin.Usuario = txt_usuario.Text.Trim();
                obj_dtoLogin.Senha = txt_senha.Text.Trim();

                if (obj_bllLogin.ValidarLogin(obj_dtoLogin))
                {
                    switch (obj_bllLogin.TipoUsuario())
                    {
                        case "Gerente":
                            Limpar();
                            this.Visible = false;
                            gerente.ShowDialog();
                            this.Visible = true;
                            break;

                        case "cadProdutos":
                            Limpar();
                            this.Visible = false;
                            produtos.ShowDialog();
                            this.Visible = true;
                            break;

                        case "cadVendas":
                            Limpar();
                            this.Visible = false;
                            vendas.ShowDialog();
                            this.Visible = true;
                            break;
                    }
                }
                else
                {
                    Erro("Usuário ou Senha incorreto!");
                }
            }
            catch (Exception ex)
            {
                Erro(ex.Message);
            }
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            try
            {
                if (obj_bllLogin.PrimeiroLogin())
                {
                    MessageBox.Show("Primeiro Login! Cadastre um Gerente", "Primeiro Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Visible = false;
                    funcionario.ShowDialog();
                    this.Visible = true;
                }
            }
            catch (Exception ex)
            {

                Erro(ex.Message);
            }
        }
    }
}