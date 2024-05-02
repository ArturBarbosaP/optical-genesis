
namespace Ótica
{
    partial class frmCadProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadProdutos));
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_fornecedor = new System.Windows.Forms.Label();
            this.txt_id = new CustomControls.CustomTextBox();
            this.txt_nome = new CustomControls.CustomTextBox();
            this.txt_marca = new CustomControls.CustomTextBox();
            this.txt_fornecedor = new CustomControls.CustomTextBox();
            this.txt_quantidade = new CustomControls.CustomTextBox();
            this.txt_desc = new CustomControls.CustomTextBox();
            this.btn_inserir = new CustomControls.CustomButton();
            this.btn_alterar = new CustomControls.CustomButton();
            this.btn_excluir = new CustomControls.CustomButton();
            this.btn_limpar = new CustomControls.CustomButton();
            this.btn_voltar = new CustomControls.CustomButton();
            this.txt_preco = new CustomControls.CustomTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_id.Location = new System.Drawing.Point(18, 25);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(93, 22);
            this.lbl_id.TabIndex = 11;
            this.lbl_id.Text = "ID do Produto:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_nome.Location = new System.Drawing.Point(161, 25);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(117, 22);
            this.lbl_nome.TabIndex = 12;
            this.lbl_nome.Text = "Nome do Produto:";
            // 
            // lbl_preco
            // 
            this.lbl_preco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_preco.Location = new System.Drawing.Point(516, 93);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(115, 22);
            this.lbl_preco.TabIndex = 15;
            this.lbl_preco.Text = "Preço do Produto:";
            this.toolTip1.SetToolTip(this.lbl_preco, "R$");
            // 
            // lbl_marca
            // 
            this.lbl_marca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_marca.Location = new System.Drawing.Point(621, 25);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(119, 22);
            this.lbl_marca.TabIndex = 13;
            this.lbl_marca.Text = "Marca do Produto:";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_quantidade.Location = new System.Drawing.Point(734, 93);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(153, 22);
            this.lbl_quantidade.TabIndex = 16;
            this.lbl_quantidade.Text = "Quantidade do Produto:";
            // 
            // lbl_desc
            // 
            this.lbl_desc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_desc.Location = new System.Drawing.Point(18, 161);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(140, 22);
            this.lbl_desc.TabIndex = 17;
            this.lbl_desc.Text = "Descrição do Produto:";
            // 
            // lbl_fornecedor
            // 
            this.lbl_fornecedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_fornecedor.AutoSize = true;
            this.lbl_fornecedor.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_fornecedor.Location = new System.Drawing.Point(18, 93);
            this.lbl_fornecedor.Name = "lbl_fornecedor";
            this.lbl_fornecedor.Size = new System.Drawing.Size(149, 22);
            this.lbl_fornecedor.TabIndex = 14;
            this.lbl_fornecedor.Text = "Fornecedor do Produto:";
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
            this.txt_id.Location = new System.Drawing.Point(117, 24);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            this.txt_id.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_id.PasswordChar = false;
            this.txt_id.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_id.PlaceholderText = "";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(29, 25);
            this.txt_id.TabIndex = 18;
            this.txt_id.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_id.UnderlinedStyle = false;
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
            this.txt_nome.Location = new System.Drawing.Point(284, 24);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nome.Multiline = false;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_nome.PasswordChar = false;
            this.txt_nome.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_nome.PlaceholderText = "";
            this.txt_nome.ReadOnly = false;
            this.txt_nome.Size = new System.Drawing.Size(322, 25);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_nome.UnderlinedStyle = false;
            // 
            // txt_marca
            // 
            this.txt_marca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_marca.BackColor = System.Drawing.Color.White;
            this.txt_marca.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_marca.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_marca.BorderSize = 2;
            this.txt_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_marca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_marca.Location = new System.Drawing.Point(746, 24);
            this.txt_marca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_marca.Multiline = false;
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_marca.PasswordChar = false;
            this.txt_marca.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_marca.PlaceholderText = "";
            this.txt_marca.ReadOnly = false;
            this.txt_marca.Size = new System.Drawing.Size(236, 25);
            this.txt_marca.TabIndex = 1;
            this.txt_marca.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_marca.UnderlinedStyle = false;
            // 
            // txt_fornecedor
            // 
            this.txt_fornecedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_fornecedor.BackColor = System.Drawing.Color.White;
            this.txt_fornecedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_fornecedor.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_fornecedor.BorderSize = 2;
            this.txt_fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_fornecedor.Location = new System.Drawing.Point(182, 92);
            this.txt_fornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_fornecedor.Multiline = false;
            this.txt_fornecedor.Name = "txt_fornecedor";
            this.txt_fornecedor.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_fornecedor.PasswordChar = false;
            this.txt_fornecedor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_fornecedor.PlaceholderText = "";
            this.txt_fornecedor.ReadOnly = false;
            this.txt_fornecedor.Size = new System.Drawing.Size(315, 25);
            this.txt_fornecedor.TabIndex = 2;
            this.txt_fornecedor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_fornecedor.UnderlinedStyle = false;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_quantidade.BackColor = System.Drawing.Color.White;
            this.txt_quantidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_quantidade.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_quantidade.BorderSize = 2;
            this.txt_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_quantidade.Location = new System.Drawing.Point(893, 92);
            this.txt_quantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_quantidade.Multiline = false;
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_quantidade.PasswordChar = false;
            this.txt_quantidade.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_quantidade.PlaceholderText = "";
            this.txt_quantidade.ReadOnly = false;
            this.txt_quantidade.Size = new System.Drawing.Size(89, 25);
            this.txt_quantidade.TabIndex = 4;
            this.txt_quantidade.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_quantidade.UnderlinedStyle = false;
            // 
            // txt_desc
            // 
            this.txt_desc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_desc.BackColor = System.Drawing.Color.White;
            this.txt_desc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_desc.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_desc.BorderSize = 2;
            this.txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_desc.Location = new System.Drawing.Point(182, 161);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_desc.PasswordChar = false;
            this.txt_desc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_desc.PlaceholderText = "";
            this.txt_desc.ReadOnly = false;
            this.txt_desc.Size = new System.Drawing.Size(800, 139);
            this.txt_desc.TabIndex = 5;
            this.txt_desc.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_desc.UnderlinedStyle = false;
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
            this.btn_inserir.Location = new System.Drawing.Point(27, 344);
            this.btn_inserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(145, 40);
            this.btn_inserir.TabIndex = 6;
            this.btn_inserir.Text = "Inserir";
            this.toolTip1.SetToolTip(this.btn_inserir, "Inserir");
            this.btn_inserir.UseVisualStyleBackColor = false;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
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
            this.btn_alterar.Location = new System.Drawing.Point(230, 344);
            this.btn_alterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(145, 40);
            this.btn_alterar.TabIndex = 7;
            this.btn_alterar.Text = "Alterar";
            this.toolTip1.SetToolTip(this.btn_alterar, "Alterar");
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
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
            this.btn_excluir.Location = new System.Drawing.Point(433, 344);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(145, 40);
            this.btn_excluir.TabIndex = 8;
            this.btn_excluir.Text = "Excluir";
            this.toolTip1.SetToolTip(this.btn_excluir, "Excluir");
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
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
            this.btn_limpar.Location = new System.Drawing.Point(636, 344);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(145, 40);
            this.btn_limpar.TabIndex = 9;
            this.btn_limpar.Text = "Limpar";
            this.toolTip1.SetToolTip(this.btn_limpar, "Limpar");
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
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
            this.btn_voltar.Location = new System.Drawing.Point(839, 344);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(145, 40);
            this.btn_voltar.TabIndex = 10;
            this.btn_voltar.Text = "Voltar";
            this.toolTip1.SetToolTip(this.btn_voltar, "Voltar");
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // txt_preco
            // 
            this.txt_preco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_preco.BackColor = System.Drawing.Color.White;
            this.txt_preco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_preco.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_preco.BorderSize = 2;
            this.txt_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_preco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_preco.Location = new System.Drawing.Point(637, 92);
            this.txt_preco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_preco.Multiline = false;
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_preco.PasswordChar = false;
            this.txt_preco.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(161)))));
            this.txt_preco.PlaceholderText = "";
            this.txt_preco.ReadOnly = false;
            this.txt_preco.Size = new System.Drawing.Size(82, 25);
            this.txt_preco.TabIndex = 3;
            this.txt_preco.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_preco.UnderlinedStyle = false;
            this.txt_preco.MouseEnter += new System.EventHandler(this.txt_preco_MouseEnter);
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            // 
            // frmCadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 404);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.txt_fornecedor);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_fornecedor);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_id);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1027, 443);
            this.Name = "frmCadProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmCadProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_fornecedor;
        private CustomControls.CustomTextBox txt_id;
        private CustomControls.CustomTextBox txt_nome;
        private CustomControls.CustomTextBox txt_marca;
        private CustomControls.CustomTextBox txt_fornecedor;
        private CustomControls.CustomTextBox txt_quantidade;
        private CustomControls.CustomTextBox txt_desc;
        private CustomControls.CustomButton btn_inserir;
        private CustomControls.CustomButton btn_alterar;
        private CustomControls.CustomButton btn_excluir;
        private CustomControls.CustomButton btn_limpar;
        private CustomControls.CustomButton btn_voltar;
        private CustomControls.CustomTextBox txt_preco;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}