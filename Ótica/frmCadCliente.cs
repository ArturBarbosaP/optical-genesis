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
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        BLL_Clientes obj_bllClientes = new BLL_Clientes();
        DTO_Clientes obj_dtoClientes = new DTO_Clientes();
        ValidarCPF obj_ValidarCPF = new ValidarCPF();
        AutoCEP obj_autoCEP = new AutoCEP();

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
            txt_complemento.Clear();
            txt_cpf.Clear();
            txt_email.Clear();
            txt_id.Clear();
            txt_nome.Clear();
            txt_numero.Clear();
            txt_telefone.Clear();
            txt_cidade.Clear();
            txt_estado.Clear();
            txt_rua.Clear();
            txt_bairro.Clear();
            dtp_dataNasc.Value = DateTime.Today;
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            if (obj_dtoClientes.ClickBotao)
            {
                Limpar();
            }
            else
            {
                txt_id.Text = obj_dtoClientes.Id.ToString();
                txt_nome.Text = obj_dtoClientes.Nome;
                dtp_dataNasc.Value = obj_dtoClientes.Data_nasc;
                txt_cpf.Text = obj_dtoClientes.Cpf;
                txt_telefone.Text = obj_dtoClientes.Telefone;
                txt_email.Text = obj_dtoClientes.Email;
                txt_cep.Text = obj_dtoClientes.Cep;
                txt_estado.Text = obj_dtoClientes.Estado;
                txt_cidade.Text = obj_dtoClientes.Cidade;
                txt_bairro.Text = obj_dtoClientes.Bairro;
                txt_rua.Text = obj_dtoClientes.Rua;
                txt_numero.Text = obj_dtoClientes.Numero.ToString();
                txt_complemento.Text = obj_dtoClientes.Complemento;
            }
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarMtxt();

                obj_dtoClientes.Nome = txt_nome.Text;
                obj_dtoClientes.Data_nasc = dtp_dataNasc.Value;
                obj_dtoClientes.Cpf = txt_cpf.Text;
                obj_dtoClientes.Telefone = txt_telefone.Text;
                obj_dtoClientes.Email = txt_email.Text;
                obj_dtoClientes.Cep = txt_cep.Text;
                obj_dtoClientes.Estado = txt_estado.Text;
                obj_dtoClientes.Cidade = txt_cidade.Text;
                obj_dtoClientes.Bairro = txt_bairro.Text;
                obj_dtoClientes.Rua = txt_rua.Text;
                obj_dtoClientes.Numero = int.Parse(txt_numero.Text);
                obj_dtoClientes.Complemento = txt_complemento.Text;

                obj_bllClientes.Cadastrar(obj_dtoClientes);
                MessageBox.Show("Cliente cadastrado com sucesso!", "Inserir Cadastro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                VerificarMtxt();

                obj_dtoClientes.Nome = txt_nome.Text;
                obj_dtoClientes.Data_nasc = dtp_dataNasc.Value;
                obj_dtoClientes.Cpf = txt_cpf.Text;
                obj_dtoClientes.Telefone = txt_telefone.Text;
                obj_dtoClientes.Email = txt_email.Text;
                obj_dtoClientes.Cep = txt_cep.Text;
                obj_dtoClientes.Estado = txt_estado.Text;
                obj_dtoClientes.Cidade = txt_cidade.Text;
                obj_dtoClientes.Bairro = txt_bairro.Text;
                obj_dtoClientes.Rua = txt_rua.Text;
                obj_dtoClientes.Numero = int.Parse(txt_numero.Text);
                obj_dtoClientes.Complemento = txt_complemento.Text;
                obj_dtoClientes.Id = int.Parse(txt_id.Text);

                obj_bllClientes.Alterar(obj_dtoClientes);
                MessageBox.Show("Cliente alterado com sucesso!", "Alterar Cadastro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                obj_dtoClientes.Id = int.Parse(txt_id.Text);

                obj_bllClientes.Excluir(obj_dtoClientes);
                MessageBox.Show("Cliente excluido com sucesso!", "Excluir Cadastro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txt_cpf_Click(object sender, EventArgs e)
        {
            txt_cpf.SelectionStart = 0;
        }

        private void txt_telefone_Click(object sender, EventArgs e)
        {
            txt_telefone.SelectionStart = 0;
        }

        private void txt_cep_Click(object sender, EventArgs e)
        {
            txt_cep.SelectionStart = 0;
        }
    }
}