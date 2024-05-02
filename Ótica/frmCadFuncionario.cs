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
using Ótica.API;

namespace Ótica
{
    public partial class frmCadFuncionario : Form
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        BLL_Funcionarios obj_bllFuncionarios = new BLL_Funcionarios();
        BLL_Login obj_bllLogin = new BLL_Login();
        DTO_Funcionarios obj_dtoFuncionarios = new DTO_Funcionarios();
        ValidarCPF obj_ValidarCPF = new ValidarCPF();
        AutoCEP obj_autoCEP = new AutoCEP();
        private bool fromPL;

        private void VerificarMtxt()
        {
            if (!(txt_cpf.MaskCompleted))
            {
                throw new Exception("Preencha o campo CPF corretamente!");
            }

            if (!(txt_telefone.MaskCompleted))
            {
                throw new Exception("Preencha o campo Telefone corretamente!");
            }

            if (!(txt_hrIn.MaskCompleted))
            {
                throw new Exception("Preencha o campo Horário de Entrada corretamente!");
            }

            if (!(txt_hrOut.MaskCompleted))
            {
                throw new Exception("Preencha o campo Horário de Saída corretamente!");
            }

            if (!(txt_cep.MaskCompleted))
            {
                throw new Exception("Preencha o campo CEP corretamente!");
            }

            if (obj_ValidarCPF.ValidaCPF(txt_cpf.Text) == false)
            {
                throw new Exception("CPF inválido!");
            }
        }

        private void Limpar()
        {
            txt_cep.Clear();
            txt_comissao.Clear();
            txt_complemento.Clear();
            txt_cpf.Clear();
            txt_email.Clear();
            txt_hrIn.Clear();
            txt_hrOut.Clear();
            txt_id.Clear();
            txt_nome.Clear();
            txt_numero.Clear();
            txt_salario.Clear();
            txt_senha.Clear();
            txt_telefone.Clear();
            txt_usuario.Clear();
            txt_estado.Clear();
            txt_cidade.Clear();
            txt_bairro.Clear();
            txt_rua.Clear();
            cbx_tipo.SelectedIndex = -1;
            dtp_dataNasc.Value = DateTime.Today;
        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            if (obj_bllLogin.PrimeiroLogin())
            {
                cbx_tipo.Items.Clear();
                cbx_tipo.Items.Add("Gerente");
                cbx_tipo.SelectedItem = "Gerente";
                btn_alterar.Visible = false;
                btn_excluir.Visible = false;
                btn_voltar.Visible = false;
                fromPL = true;
            }
            else if (obj_dtoFuncionarios.ClickBotao)
            {
                Limpar();
                fromPL = false;
            }
            else
            {
                txt_id.Text = obj_dtoFuncionarios.Id.ToString();
                txt_nome.Text = obj_dtoFuncionarios.Nome;
                dtp_dataNasc.Value = obj_dtoFuncionarios.Data_nasc;
                txt_cpf.Text = obj_dtoFuncionarios.Cpf;
                txt_telefone.Text = obj_dtoFuncionarios.Telefone;
                txt_email.Text = obj_dtoFuncionarios.Email;
                txt_salario.Text = obj_dtoFuncionarios.Salario.ToString();
                txt_comissao.Text = obj_dtoFuncionarios.Comissao.ToString();
                txt_hrIn.Text = obj_dtoFuncionarios.Horario_entrada.ToString("HH:mm");
                txt_hrOut.Text = obj_dtoFuncionarios.Horario_saida.ToString("HH:mm");
                txt_usuario.Text = obj_dtoFuncionarios.Usuario;
                txt_senha.Text = obj_dtoFuncionarios.Senha;
                cbx_tipo.SelectedItem = obj_dtoFuncionarios.Tipo;
                txt_cep.Text = obj_dtoFuncionarios.Cep;
                txt_estado.Text = obj_dtoFuncionarios.Estado;
                txt_cidade.Text = obj_dtoFuncionarios.Cidade;
                txt_bairro.Text = obj_dtoFuncionarios.Bairro;
                txt_rua.Text = obj_dtoFuncionarios.Rua;
                txt_numero.Text = obj_dtoFuncionarios.Numero.ToString();
                txt_complemento.Text = obj_dtoFuncionarios.Complemento;
                fromPL = false;
            }
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarMtxt();

                obj_dtoFuncionarios.Nome = txt_nome.Text;
                obj_dtoFuncionarios.Data_nasc = dtp_dataNasc.Value;
                obj_dtoFuncionarios.Cpf = txt_cpf.Text;
                obj_dtoFuncionarios.Telefone = txt_telefone.Text;
                obj_dtoFuncionarios.Email = txt_email.Text;
                obj_dtoFuncionarios.Salario = double.Parse(txt_salario.Text.Replace(".", ","));
                obj_dtoFuncionarios.Comissao = double.Parse(txt_comissao.Text.Replace(".", ","));
                obj_dtoFuncionarios.Horario_entrada = DateTime.Parse(txt_hrIn.Text);
                obj_dtoFuncionarios.Horario_saida = DateTime.Parse(txt_hrOut.Text);
                obj_dtoFuncionarios.Usuario = txt_usuario.Text;
                obj_dtoFuncionarios.Senha = txt_senha.Text;
                obj_dtoFuncionarios.Tipo = cbx_tipo.SelectedItem.ToString();
                obj_dtoFuncionarios.Cep = txt_cep.Text;
                obj_dtoFuncionarios.Estado = txt_estado.Text;
                obj_dtoFuncionarios.Cidade = txt_cidade.Text;
                obj_dtoFuncionarios.Bairro = txt_bairro.Text;
                obj_dtoFuncionarios.Rua = txt_rua.Text;
                obj_dtoFuncionarios.Numero = int.Parse(txt_numero.Text);
                obj_dtoFuncionarios.Complemento = txt_complemento.Text;

                obj_bllFuncionarios.Cadastrar(obj_dtoFuncionarios);
                MessageBox.Show("Funcionário cadastrado com sucesso!", "Inserir Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                if (fromPL)
                {
                    Close();
                }
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
                VerificarMtxt();

                obj_dtoFuncionarios.Nome = txt_nome.Text;
                obj_dtoFuncionarios.Data_nasc = dtp_dataNasc.Value;
                obj_dtoFuncionarios.Cpf = txt_cpf.Text;
                obj_dtoFuncionarios.Telefone = txt_telefone.Text;
                obj_dtoFuncionarios.Email = txt_email.Text;
                obj_dtoFuncionarios.Salario = double.Parse(txt_salario.Text.Replace(".", ","));
                obj_dtoFuncionarios.Comissao = double.Parse(txt_comissao.Text.Replace(".", ","));
                obj_dtoFuncionarios.Horario_entrada = DateTime.Parse(txt_hrIn.Text);
                obj_dtoFuncionarios.Horario_saida = DateTime.Parse(txt_hrOut.Text);
                obj_dtoFuncionarios.Usuario = txt_usuario.Text;
                obj_dtoFuncionarios.Senha = txt_senha.Text;
                obj_dtoFuncionarios.Tipo = cbx_tipo.SelectedItem.ToString();
                obj_dtoFuncionarios.Cep = txt_cep.Text;
                obj_dtoFuncionarios.Estado = txt_estado.Text;
                obj_dtoFuncionarios.Cidade = txt_cidade.Text;
                obj_dtoFuncionarios.Bairro = txt_bairro.Text;
                obj_dtoFuncionarios.Rua = txt_rua.Text;
                obj_dtoFuncionarios.Numero = int.Parse(txt_numero.Text);
                obj_dtoFuncionarios.Complemento = txt_complemento.Text;
                obj_dtoFuncionarios.Id = int.Parse(txt_id.Text);


                obj_bllFuncionarios.Alterar(obj_dtoFuncionarios);
                MessageBox.Show("Funcionário alterado com sucesso!", "Alterar Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                obj_dtoFuncionarios.Id = int.Parse(txt_id.Text);

                obj_bllFuncionarios.Excluir(obj_dtoFuncionarios);
                MessageBox.Show("Funcionário excluido com sucesso!", "Excluir Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txt_cep__TextChanged(object sender, EventArgs e)
        {
            if (txt_cep.MaskFull)
            {
                try
                {
                    obj_autoCEP.PesquisarCEP(txt_cep.Text);
                    txt_estado.Text = obj_autoCEP.estado.Trim();
                    txt_cidade.Text = obj_autoCEP.cidade.Trim();
                    txt_bairro.Text = obj_autoCEP.bairro.Trim();
                    txt_rua.Text = obj_autoCEP.rua.Trim();
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Erro: Preencha um CEP válido!", "Erro ao Pesquisar CEP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro: " + ex.Message, "Erro ao Pesquisar CEP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_hrIn_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txt_hrIn, "Relógio de 24h");
        }

        private void txt_hrOut_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txt_hrOut, "Relógio de 24h");
        }

        private void txt_salario_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txt_salario, "R$");
        }

        private void txt_cpf_Click(object sender, EventArgs e)
        {
            txt_cpf.SelectionStart = 0;
        }

        private void txt_telefone_Click(object sender, EventArgs e)
        {
            txt_telefone.SelectionStart = 0;
        }

        private void txt_hrIn_Click(object sender, EventArgs e)
        {
            txt_hrIn.SelectionStart = 0;
        }

        private void txt_hrOut_Click(object sender, EventArgs e)
        {
            txt_hrOut.SelectionStart = 0;
        }

        private void txt_cep_Click(object sender, EventArgs e)
        {
            txt_cep.SelectionStart = 0;
        }
    }
}