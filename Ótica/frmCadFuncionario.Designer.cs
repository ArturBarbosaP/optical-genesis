
namespace Ótica
{
    partial class frmCadFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadFuncionario));
            this.lbl_complemento = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.lbl_dataNasc = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_salario = new System.Windows.Forms.Label();
            this.lbl_comissao = new System.Windows.Forms.Label();
            this.lbl_hrIn = new System.Windows.Forms.Label();
            this.lbl_hrOut = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_rua = new System.Windows.Forms.Label();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_voltar = new CustomControls.CustomButton();
            this.btn_limpar = new CustomControls.CustomButton();
            this.btn_excluir = new CustomControls.CustomButton();
            this.btn_alterar = new CustomControls.CustomButton();
            this.btn_inserir = new CustomControls.CustomButton();
            this.txt_rua = new CustomControls.CustomTextBox();
            this.txt_bairro = new CustomControls.CustomTextBox();
            this.txt_cidade = new CustomControls.CustomTextBox();
            this.txt_estado = new CustomControls.CustomTextBox();
            this.cbx_tipo = new CustomControls.Custom_Controls.CustomComboBox();
            this.txt_senha = new CustomControls.CustomTextBox();
            this.txt_usuario = new CustomControls.CustomTextBox();
            this.txt_hrOut = new CustomControls.CustomMaskedTextBox();
            this.txt_hrIn = new CustomControls.CustomMaskedTextBox();
            this.txt_comissao = new CustomControls.CustomTextBox();
            this.txt_salario = new CustomControls.CustomTextBox();
            this.txt_complemento = new CustomControls.CustomTextBox();
            this.txt_numero = new CustomControls.CustomTextBox();
            this.txt_cep = new CustomControls.CustomMaskedTextBox();
            this.txt_email = new CustomControls.CustomTextBox();
            this.txt_telefone = new CustomControls.CustomMaskedTextBox();
            this.txt_cpf = new CustomControls.CustomMaskedTextBox();
            this.dtp_dataNasc = new CustomControls.CustomDatePicker();
            this.txt_nome = new CustomControls.CustomTextBox();
            this.txt_id = new CustomControls.CustomTextBox();
            this.SuspendLayout();
            // 
            // lbl_complemento
            // 
            this.lbl_complemento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_complemento.AutoSize = true;
            this.lbl_complemento.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_complemento.Location = new System.Drawing.Point(39, 367);
            this.lbl_complemento.Name = "lbl_complemento";
            this.lbl_complemento.Size = new System.Drawing.Size(99, 22);
            this.lbl_complemento.TabIndex = 45;
            this.lbl_complemento.Text = "Complemento:";
            // 
            // lbl_numero
            // 
            this.lbl_numero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_numero.Location = new System.Drawing.Point(852, 309);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(60, 22);
            this.lbl_numero.TabIndex = 44;
            this.lbl_numero.Text = "Número:";
            // 
            // lbl_cep
            // 
            this.lbl_cep.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_cep.Location = new System.Drawing.Point(205, 251);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(35, 22);
            this.lbl_cep.TabIndex = 39;
            this.lbl_cep.Text = "CEP:";
            // 
            // lbl_dataNasc
            // 
            this.lbl_dataNasc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_dataNasc.AutoSize = true;
            this.lbl_dataNasc.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_dataNasc.Location = new System.Drawing.Point(693, 19);
            this.lbl_dataNasc.Name = "lbl_dataNasc";
            this.lbl_dataNasc.Size = new System.Drawing.Size(133, 22);
            this.lbl_dataNasc.TabIndex = 26;
            this.lbl_dataNasc.Text = "Data de Nascimento:";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_endereco.Location = new System.Drawing.Point(39, 251);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(161, 22);
            this.lbl_endereco.TabIndex = 38;
            this.lbl_endereco.Text = "Endereço do Funcionário:";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_telefone.Location = new System.Drawing.Point(289, 77);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(156, 22);
            this.lbl_telefone.TabIndex = 28;
            this.lbl_telefone.Text = "Telefone do Funcionário:";
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_email.Location = new System.Drawing.Point(578, 77);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(135, 22);
            this.lbl_email.TabIndex = 29;
            this.lbl_email.Text = "Email do Funcionário";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_cpf.Location = new System.Drawing.Point(39, 77);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(128, 22);
            this.lbl_cpf.TabIndex = 27;
            this.lbl_cpf.Text = "CPF do Funcionário:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_nome.Location = new System.Drawing.Point(197, 19);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(141, 22);
            this.lbl_nome.TabIndex = 25;
            this.lbl_nome.Text = "Nome do Funcionário:";
            // 
            // lbl_id
            // 
            this.lbl_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_id.Location = new System.Drawing.Point(39, 19);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(117, 22);
            this.lbl_id.TabIndex = 24;
            this.lbl_id.Text = "ID do Funcionário:";
            // 
            // lbl_salario
            // 
            this.lbl_salario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_salario.AutoSize = true;
            this.lbl_salario.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_salario.Location = new System.Drawing.Point(39, 135);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(147, 22);
            this.lbl_salario.TabIndex = 30;
            this.lbl_salario.Text = "Salário do Funcionário:";
            this.toolTip1.SetToolTip(this.lbl_salario, "R$");
            // 
            // lbl_comissao
            // 
            this.lbl_comissao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_comissao.AutoSize = true;
            this.lbl_comissao.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_comissao.Location = new System.Drawing.Point(305, 135);
            this.lbl_comissao.Name = "lbl_comissao";
            this.lbl_comissao.Size = new System.Drawing.Size(188, 22);
            this.lbl_comissao.TabIndex = 31;
            this.lbl_comissao.Text = "Comissão do Funcionário: (%)\r\n";
            // 
            // lbl_hrIn
            // 
            this.lbl_hrIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_hrIn.AutoSize = true;
            this.lbl_hrIn.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_hrIn.Location = new System.Drawing.Point(561, 135);
            this.lbl_hrIn.Name = "lbl_hrIn";
            this.lbl_hrIn.Size = new System.Drawing.Size(123, 22);
            this.lbl_hrIn.TabIndex = 32;
            this.lbl_hrIn.Text = "Horário de Entrada:";
            this.toolTip1.SetToolTip(this.lbl_hrIn, "Relógio de 24h");
            // 
            // lbl_hrOut
            // 
            this.lbl_hrOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_hrOut.AutoSize = true;
            this.lbl_hrOut.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_hrOut.Location = new System.Drawing.Point(782, 135);
            this.lbl_hrOut.Name = "lbl_hrOut";
            this.lbl_hrOut.Size = new System.Drawing.Size(111, 22);
            this.lbl_hrOut.TabIndex = 33;
            this.lbl_hrOut.Text = "Horário de Saída:";
            this.toolTip1.SetToolTip(this.lbl_hrOut, "Relógio de 24h");
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_usuario.Location = new System.Drawing.Point(39, 193);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(58, 22);
            this.lbl_usuario.TabIndex = 34;
            this.lbl_usuario.Text = "Usuário:";
            // 
            // lbl_senha
            // 
            this.lbl_senha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_senha.Location = new System.Drawing.Point(375, 193);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(51, 22);
            this.lbl_senha.TabIndex = 35;
            this.lbl_senha.Text = "Senha:";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_tipo.Location = new System.Drawing.Point(704, 193);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(38, 22);
            this.lbl_tipo.TabIndex = 36;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.panel1.Location = new System.Drawing.Point(772, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 2);
            this.panel1.TabIndex = 37;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_cidade.Location = new System.Drawing.Point(502, 251);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(56, 22);
            this.lbl_cidade.TabIndex = 41;
            this.lbl_cidade.Text = "Cidade:";
            // 
            // lbl_estado
            // 
            this.lbl_estado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_estado.Location = new System.Drawing.Point(355, 251);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(53, 22);
            this.lbl_estado.TabIndex = 40;
            this.lbl_estado.Text = "Estado:";
            // 
            // lbl_rua
            // 
            this.lbl_rua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_rua.AutoSize = true;
            this.lbl_rua.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_rua.Location = new System.Drawing.Point(347, 309);
            this.lbl_rua.Name = "lbl_rua";
            this.lbl_rua.Size = new System.Drawing.Size(36, 22);
            this.lbl_rua.TabIndex = 43;
            this.lbl_rua.Text = "Rua:";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_bairro.Location = new System.Drawing.Point(39, 309);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(47, 22);
            this.lbl_bairro.TabIndex = 42;
            this.lbl_bairro.Text = "Bairro:";
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            // 
            // btn_voltar
            // 
            this.btn_voltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_voltar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_voltar.BorderRadius = 25;
            this.btn_voltar.BorderSize = 0;
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_voltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_voltar.Location = new System.Drawing.Point(823, 436);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(145, 40);
            this.btn_voltar.TabIndex = 23;
            this.btn_voltar.Text = "Voltar";
            this.toolTip1.SetToolTip(this.btn_voltar, "Voltar");
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_limpar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_limpar.BorderRadius = 25;
            this.btn_limpar.BorderSize = 0;
            this.btn_limpar.FlatAppearance.BorderSize = 0;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_limpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_limpar.Location = new System.Drawing.Point(628, 436);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(145, 40);
            this.btn_limpar.TabIndex = 22;
            this.btn_limpar.Text = "Limpar";
            this.toolTip1.SetToolTip(this.btn_limpar, "Limpar");
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_excluir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_excluir.BorderRadius = 25;
            this.btn_excluir.BorderSize = 0;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_excluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_excluir.Location = new System.Drawing.Point(433, 436);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(145, 40);
            this.btn_excluir.TabIndex = 21;
            this.btn_excluir.Text = "Excluir";
            this.toolTip1.SetToolTip(this.btn_excluir, "Excluir");
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_alterar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_alterar.BorderRadius = 25;
            this.btn_alterar.BorderSize = 0;
            this.btn_alterar.FlatAppearance.BorderSize = 0;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_alterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_alterar.Location = new System.Drawing.Point(238, 436);
            this.btn_alterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(145, 40);
            this.btn_alterar.TabIndex = 20;
            this.btn_alterar.Text = "Alterar";
            this.toolTip1.SetToolTip(this.btn_alterar, "Alterar");
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_inserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_inserir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_inserir.BorderRadius = 25;
            this.btn_inserir.BorderSize = 0;
            this.btn_inserir.FlatAppearance.BorderSize = 0;
            this.btn_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserir.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_inserir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_inserir.Location = new System.Drawing.Point(43, 436);
            this.btn_inserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(145, 40);
            this.btn_inserir.TabIndex = 19;
            this.btn_inserir.Text = "Inserir";
            this.toolTip1.SetToolTip(this.btn_inserir, "Inserir");
            this.btn_inserir.UseVisualStyleBackColor = false;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // txt_rua
            // 
            this.txt_rua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_rua.BackColor = System.Drawing.Color.White;
            this.txt_rua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_rua.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_rua.BorderSize = 2;
            this.txt_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_rua.Location = new System.Drawing.Point(389, 308);
            this.txt_rua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_rua.Multiline = false;
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_rua.PasswordChar = false;
            this.txt_rua.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_rua.PlaceholderText = "";
            this.txt_rua.ReadOnly = true;
            this.txt_rua.Size = new System.Drawing.Size(446, 25);
            this.txt_rua.TabIndex = 16;
            this.txt_rua.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_rua.UnderlinedStyle = false;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_bairro.BackColor = System.Drawing.Color.White;
            this.txt_bairro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_bairro.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_bairro.BorderSize = 2;
            this.txt_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_bairro.Location = new System.Drawing.Point(92, 308);
            this.txt_bairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bairro.Multiline = false;
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_bairro.PasswordChar = false;
            this.txt_bairro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_bairro.PlaceholderText = "";
            this.txt_bairro.ReadOnly = true;
            this.txt_bairro.Size = new System.Drawing.Size(242, 25);
            this.txt_bairro.TabIndex = 15;
            this.txt_bairro.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_bairro.UnderlinedStyle = false;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_cidade.BackColor = System.Drawing.Color.White;
            this.txt_cidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_cidade.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_cidade.BorderSize = 2;
            this.txt_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_cidade.Location = new System.Drawing.Point(564, 250);
            this.txt_cidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cidade.Multiline = false;
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_cidade.PasswordChar = false;
            this.txt_cidade.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_cidade.PlaceholderText = "";
            this.txt_cidade.ReadOnly = true;
            this.txt_cidade.Size = new System.Drawing.Size(407, 25);
            this.txt_cidade.TabIndex = 14;
            this.txt_cidade.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_cidade.UnderlinedStyle = false;
            // 
            // txt_estado
            // 
            this.txt_estado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_estado.BackColor = System.Drawing.Color.White;
            this.txt_estado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_estado.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_estado.BorderSize = 2;
            this.txt_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_estado.Location = new System.Drawing.Point(421, 250);
            this.txt_estado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_estado.Multiline = false;
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_estado.PasswordChar = false;
            this.txt_estado.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_estado.PlaceholderText = "";
            this.txt_estado.ReadOnly = true;
            this.txt_estado.Size = new System.Drawing.Size(53, 25);
            this.txt_estado.TabIndex = 13;
            this.txt_estado.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_estado.UnderlinedStyle = false;
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx_tipo.BackColor = System.Drawing.Color.White;
            this.cbx_tipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.cbx_tipo.BorderSize = 2;
            this.cbx_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo.Font = new System.Drawing.Font("Poppins", 9F);
            this.cbx_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.cbx_tipo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.cbx_tipo.Items.AddRange(new object[] {
            "Gerente",
            "cadProdutos",
            "cadVendas"});
            this.cbx_tipo.ListBackColor = System.Drawing.Color.White;
            this.cbx_tipo.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.cbx_tipo.Location = new System.Drawing.Point(771, 189);
            this.cbx_tipo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Padding = new System.Windows.Forms.Padding(2);
            this.cbx_tipo.Size = new System.Drawing.Size(200, 30);
            this.cbx_tipo.TabIndex = 11;
            this.cbx_tipo.Texts = "";
            // 
            // txt_senha
            // 
            this.txt_senha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_senha.BackColor = System.Drawing.Color.White;
            this.txt_senha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_senha.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_senha.BorderSize = 2;
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_senha.Location = new System.Drawing.Point(455, 192);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_senha.Multiline = false;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_senha.PasswordChar = false;
            this.txt_senha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_senha.PlaceholderText = "";
            this.txt_senha.ReadOnly = false;
            this.txt_senha.Size = new System.Drawing.Size(220, 25);
            this.txt_senha.TabIndex = 10;
            this.txt_senha.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_senha.UnderlinedStyle = false;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_usuario.BackColor = System.Drawing.Color.White;
            this.txt_usuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_usuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_usuario.BorderSize = 2;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_usuario.Location = new System.Drawing.Point(126, 192);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_usuario.Multiline = false;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_usuario.PasswordChar = false;
            this.txt_usuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_usuario.PlaceholderText = "";
            this.txt_usuario.ReadOnly = false;
            this.txt_usuario.Size = new System.Drawing.Size(220, 25);
            this.txt_usuario.TabIndex = 9;
            this.txt_usuario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_usuario.UnderlinedStyle = false;
            // 
            // txt_hrOut
            // 
            this.txt_hrOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_hrOut.BackColor = System.Drawing.SystemColors.Window;
            this.txt_hrOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_hrOut.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_hrOut.BorderSize = 2;
            this.txt_hrOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hrOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_hrOut.Location = new System.Drawing.Point(923, 131);
            this.txt_hrOut.Margin = new System.Windows.Forms.Padding(4);
            this.txt_hrOut.Mask = "00:00";
            this.txt_hrOut.Name = "txt_hrOut";
            this.txt_hrOut.Padding = new System.Windows.Forms.Padding(7);
            this.txt_hrOut.ReadOnly = false;
            this.txt_hrOut.Size = new System.Drawing.Size(48, 30);
            this.txt_hrOut.TabIndex = 8;
            this.txt_hrOut.UnderlinedStyle = false;
            this.txt_hrOut.Click += new System.EventHandler(this.txt_hrOut_Click);
            this.txt_hrOut.MouseEnter += new System.EventHandler(this.txt_hrOut_MouseEnter);
            // 
            // txt_hrIn
            // 
            this.txt_hrIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_hrIn.BackColor = System.Drawing.SystemColors.Window;
            this.txt_hrIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_hrIn.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_hrIn.BorderSize = 2;
            this.txt_hrIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hrIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_hrIn.Location = new System.Drawing.Point(709, 131);
            this.txt_hrIn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_hrIn.Mask = "00:00";
            this.txt_hrIn.Name = "txt_hrIn";
            this.txt_hrIn.Padding = new System.Windows.Forms.Padding(7);
            this.txt_hrIn.ReadOnly = false;
            this.txt_hrIn.Size = new System.Drawing.Size(48, 30);
            this.txt_hrIn.TabIndex = 7;
            this.txt_hrIn.UnderlinedStyle = false;
            this.txt_hrIn.Click += new System.EventHandler(this.txt_hrIn_Click);
            this.txt_hrIn.MouseEnter += new System.EventHandler(this.txt_hrIn_MouseEnter);
            // 
            // txt_comissao
            // 
            this.txt_comissao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_comissao.BackColor = System.Drawing.Color.White;
            this.txt_comissao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_comissao.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_comissao.BorderSize = 2;
            this.txt_comissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_comissao.Location = new System.Drawing.Point(496, 134);
            this.txt_comissao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_comissao.Multiline = false;
            this.txt_comissao.Name = "txt_comissao";
            this.txt_comissao.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_comissao.PasswordChar = false;
            this.txt_comissao.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(161)))));
            this.txt_comissao.PlaceholderText = "";
            this.txt_comissao.ReadOnly = false;
            this.txt_comissao.Size = new System.Drawing.Size(40, 25);
            this.txt_comissao.TabIndex = 6;
            this.txt_comissao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_comissao.UnderlinedStyle = false;
            // 
            // txt_salario
            // 
            this.txt_salario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_salario.BackColor = System.Drawing.Color.White;
            this.txt_salario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_salario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_salario.BorderSize = 2;
            this.txt_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_salario.Location = new System.Drawing.Point(211, 134);
            this.txt_salario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_salario.Multiline = false;
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_salario.PasswordChar = false;
            this.txt_salario.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(161)))));
            this.txt_salario.PlaceholderText = "";
            this.txt_salario.ReadOnly = false;
            this.txt_salario.Size = new System.Drawing.Size(69, 25);
            this.txt_salario.TabIndex = 5;
            this.txt_salario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_salario.UnderlinedStyle = false;
            this.txt_salario.MouseEnter += new System.EventHandler(this.txt_salario_MouseEnter);
            // 
            // txt_complemento
            // 
            this.txt_complemento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_complemento.BackColor = System.Drawing.Color.White;
            this.txt_complemento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_complemento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_complemento.BorderSize = 2;
            this.txt_complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_complemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_complemento.Location = new System.Drawing.Point(140, 366);
            this.txt_complemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_complemento.Multiline = true;
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_complemento.PasswordChar = false;
            this.txt_complemento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_complemento.PlaceholderText = "";
            this.txt_complemento.ReadOnly = false;
            this.txt_complemento.Size = new System.Drawing.Size(831, 25);
            this.txt_complemento.TabIndex = 18;
            this.txt_complemento.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_complemento.UnderlinedStyle = false;
            // 
            // txt_numero
            // 
            this.txt_numero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_numero.BackColor = System.Drawing.Color.White;
            this.txt_numero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_numero.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_numero.BorderSize = 2;
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_numero.Location = new System.Drawing.Point(918, 308);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_numero.Multiline = false;
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_numero.PasswordChar = false;
            this.txt_numero.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_numero.PlaceholderText = "";
            this.txt_numero.ReadOnly = false;
            this.txt_numero.Size = new System.Drawing.Size(53, 25);
            this.txt_numero.TabIndex = 17;
            this.txt_numero.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_numero.UnderlinedStyle = false;
            // 
            // txt_cep
            // 
            this.txt_cep.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_cep.BackColor = System.Drawing.SystemColors.Window;
            this.txt_cep.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_cep.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_cep.BorderSize = 2;
            this.txt_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_cep.Location = new System.Drawing.Point(258, 247);
            this.txt_cep.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cep.Mask = "00000-000";
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Padding = new System.Windows.Forms.Padding(7);
            this.txt_cep.ReadOnly = false;
            this.txt_cep.Size = new System.Drawing.Size(76, 30);
            this.txt_cep.TabIndex = 12;
            this.txt_cep.UnderlinedStyle = false;
            this.txt_cep._TextChanged += new System.EventHandler(this.txt_cep__TextChanged);
            this.txt_cep.Click += new System.EventHandler(this.txt_cep_Click);
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_email.BackColor = System.Drawing.Color.White;
            this.txt_email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_email.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_email.BorderSize = 2;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_email.Location = new System.Drawing.Point(723, 76);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_email.PasswordChar = false;
            this.txt_email.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_email.PlaceholderText = "";
            this.txt_email.ReadOnly = false;
            this.txt_email.Size = new System.Drawing.Size(248, 25);
            this.txt_email.TabIndex = 4;
            this.txt_email.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_email.UnderlinedStyle = false;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_telefone.BackColor = System.Drawing.SystemColors.Window;
            this.txt_telefone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_telefone.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_telefone.BorderSize = 2;
            this.txt_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_telefone.Location = new System.Drawing.Point(455, 73);
            this.txt_telefone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefone.Mask = "(00) 00000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Padding = new System.Windows.Forms.Padding(7);
            this.txt_telefone.ReadOnly = false;
            this.txt_telefone.Size = new System.Drawing.Size(113, 30);
            this.txt_telefone.TabIndex = 3;
            this.txt_telefone.UnderlinedStyle = false;
            this.txt_telefone.Click += new System.EventHandler(this.txt_telefone_Click);
            // 
            // txt_cpf
            // 
            this.txt_cpf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_cpf.BackColor = System.Drawing.SystemColors.Window;
            this.txt_cpf.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_cpf.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_cpf.BorderSize = 2;
            this.txt_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_cpf.Location = new System.Drawing.Point(177, 73);
            this.txt_cpf.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cpf.Mask = "000,000,000-00";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Padding = new System.Windows.Forms.Padding(7);
            this.txt_cpf.ReadOnly = false;
            this.txt_cpf.Size = new System.Drawing.Size(102, 30);
            this.txt_cpf.TabIndex = 2;
            this.txt_cpf.UnderlinedStyle = false;
            this.txt_cpf.Click += new System.EventHandler(this.txt_cpf_Click);
            // 
            // dtp_dataNasc
            // 
            this.dtp_dataNasc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_dataNasc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.dtp_dataNasc.BorderSize = 2;
            this.dtp_dataNasc.CalendarFont = new System.Drawing.Font("Poppins", 9F);
            this.dtp_dataNasc.DarkerIcon = true;
            this.dtp_dataNasc.Font = new System.Drawing.Font("Poppins", 9F);
            this.dtp_dataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataNasc.Location = new System.Drawing.Point(832, 13);
            this.dtp_dataNasc.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtp_dataNasc.Name = "dtp_dataNasc";
            this.dtp_dataNasc.Size = new System.Drawing.Size(139, 35);
            this.dtp_dataNasc.SkinColor = System.Drawing.Color.White;
            this.dtp_dataNasc.TabIndex = 1;
            this.dtp_dataNasc.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            // 
            // txt_nome
            // 
            this.txt_nome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_nome.BackColor = System.Drawing.Color.White;
            this.txt_nome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_nome.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_nome.BorderSize = 2;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_nome.Location = new System.Drawing.Point(344, 18);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nome.Multiline = false;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_nome.PasswordChar = false;
            this.txt_nome.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_nome.PlaceholderText = "";
            this.txt_nome.ReadOnly = false;
            this.txt_nome.Size = new System.Drawing.Size(343, 25);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_nome.UnderlinedStyle = false;
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_id.BackColor = System.Drawing.Color.White;
            this.txt_id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_id.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_id.BorderSize = 2;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_id.Location = new System.Drawing.Point(162, 18);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            this.txt_id.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_id.PasswordChar = false;
            this.txt_id.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_id.PlaceholderText = "";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(29, 25);
            this.txt_id.TabIndex = 46;
            this.txt_id.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_id.UnderlinedStyle = false;
            // 
            // frmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 494);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.lbl_rua);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbx_tipo);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txt_hrOut);
            this.Controls.Add(this.txt_hrIn);
            this.Controls.Add(this.lbl_hrOut);
            this.Controls.Add(this.lbl_hrIn);
            this.Controls.Add(this.txt_comissao);
            this.Controls.Add(this.txt_salario);
            this.Controls.Add(this.lbl_comissao);
            this.Controls.Add(this.lbl_salario);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.txt_complemento);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.lbl_complemento);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.dtp_dataNasc);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_dataNasc);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_id);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1027, 533);
            this.Name = "frmCadFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionário";
            this.Load += new System.EventHandler(this.frmCadFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CustomButton btn_voltar;
        private CustomControls.CustomButton btn_limpar;
        private CustomControls.CustomButton btn_excluir;
        private CustomControls.CustomButton btn_alterar;
        private CustomControls.CustomButton btn_inserir;
        private CustomControls.CustomTextBox txt_complemento;
        private CustomControls.CustomTextBox txt_numero;
        private CustomControls.CustomMaskedTextBox txt_cep;
        private System.Windows.Forms.Label lbl_complemento;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_cep;
        private CustomControls.CustomTextBox txt_email;
        private CustomControls.CustomMaskedTextBox txt_telefone;
        private CustomControls.CustomMaskedTextBox txt_cpf;
        private CustomControls.CustomDatePicker dtp_dataNasc;
        private CustomControls.CustomTextBox txt_nome;
        private CustomControls.CustomTextBox txt_id;
        private System.Windows.Forms.Label lbl_dataNasc;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_salario;
        private System.Windows.Forms.Label lbl_comissao;
        private CustomControls.CustomTextBox txt_salario;
        private CustomControls.CustomTextBox txt_comissao;
        private System.Windows.Forms.Label lbl_hrIn;
        private System.Windows.Forms.Label lbl_hrOut;
        private CustomControls.CustomMaskedTextBox txt_hrIn;
        private CustomControls.CustomMaskedTextBox txt_hrOut;
        private System.Windows.Forms.Label lbl_usuario;
        private CustomControls.CustomTextBox txt_usuario;
        private System.Windows.Forms.Label lbl_senha;
        private CustomControls.CustomTextBox txt_senha;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.Custom_Controls.CustomComboBox cbx_tipo;
        private CustomControls.CustomTextBox txt_cidade;
        private System.Windows.Forms.Label lbl_cidade;
        private CustomControls.CustomTextBox txt_estado;
        private System.Windows.Forms.Label lbl_estado;
        private CustomControls.CustomTextBox txt_rua;
        private System.Windows.Forms.Label lbl_rua;
        private CustomControls.CustomTextBox txt_bairro;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}