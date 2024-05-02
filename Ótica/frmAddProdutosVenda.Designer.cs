
namespace Ótica
{
    partial class frmAddProdutosVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProdutosVenda));
            this.lbl_pesquisar = new System.Windows.Forms.Label();
            this.cbx_pesquisar = new CustomControls.Custom_Controls.CustomComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_pesquisar = new CustomControls.CustomButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_voltar = new CustomControls.CustomButton();
            this.ipb_adicionar = new FontAwesome.Sharp.IconPictureBox();
            this.ipb_remover = new FontAwesome.Sharp.IconPictureBox();
            this.btn_finz = new CustomControls.CustomButton();
            this.lbl_adicionar = new System.Windows.Forms.Label();
            this.lbl_remover = new System.Windows.Forms.Label();
            this.txt_pesquisar = new CustomControls.CustomTextBox();
            this.dtg_produtos = new System.Windows.Forms.DataGridView();
            this.dtg_lista = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipb_adicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipb_remover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pesquisar
            // 
            this.lbl_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pesquisar.AutoSize = true;
            this.lbl_pesquisar.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_pesquisar.Location = new System.Drawing.Point(792, 17);
            this.lbl_pesquisar.Name = "lbl_pesquisar";
            this.lbl_pesquisar.Size = new System.Drawing.Size(90, 22);
            this.lbl_pesquisar.TabIndex = 7;
            this.lbl_pesquisar.Text = "Pesquisar por";
            // 
            // cbx_pesquisar
            // 
            this.cbx_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx_pesquisar.BackColor = System.Drawing.Color.White;
            this.cbx_pesquisar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.cbx_pesquisar.BorderSize = 2;
            this.cbx_pesquisar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_pesquisar.Font = new System.Drawing.Font("Poppins", 9F);
            this.cbx_pesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.cbx_pesquisar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.cbx_pesquisar.Items.AddRange(new object[] {
            "Id",
            "Nome",
            "Marca",
            "Fornecedor",
            "Preco",
            "Quantidade",
            "Descricao"});
            this.cbx_pesquisar.ListBackColor = System.Drawing.Color.White;
            this.cbx_pesquisar.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.cbx_pesquisar.Location = new System.Drawing.Point(795, 42);
            this.cbx_pesquisar.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbx_pesquisar.Name = "cbx_pesquisar";
            this.cbx_pesquisar.Padding = new System.Windows.Forms.Padding(2);
            this.cbx_pesquisar.Size = new System.Drawing.Size(200, 30);
            this.cbx_pesquisar.TabIndex = 8;
            this.cbx_pesquisar.Texts = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.panel1.Location = new System.Drawing.Point(796, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 2);
            this.panel1.TabIndex = 9;
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_pesquisar.BorderColor = System.Drawing.Color.White;
            this.btn_pesquisar.BorderRadius = 37;
            this.btn_pesquisar.BorderSize = 0;
            this.btn_pesquisar.FlatAppearance.BorderSize = 0;
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_pesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_pesquisar.Location = new System.Drawing.Point(795, 122);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(200, 45);
            this.btn_pesquisar.TabIndex = 11;
            this.btn_pesquisar.Text = "Pesquisar";
            this.toolTip1.SetToolTip(this.btn_pesquisar, "Pesquisar");
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(949, 130);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 14;
            this.iconPictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.iconPictureBox1, "Pesquisar");
            // 
            // btn_voltar
            // 
            this.btn_voltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_voltar.BorderColor = System.Drawing.Color.White;
            this.btn_voltar.BorderRadius = 37;
            this.btn_voltar.BorderSize = 0;
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_voltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_voltar.Location = new System.Drawing.Point(796, 627);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(199, 45);
            this.btn_voltar.TabIndex = 15;
            this.btn_voltar.Text = "Cancelar";
            this.toolTip1.SetToolTip(this.btn_voltar, "Cancelar");
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // ipb_adicionar
            // 
            this.ipb_adicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ipb_adicionar.BackColor = System.Drawing.Color.White;
            this.ipb_adicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.ipb_adicionar.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.ipb_adicionar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.ipb_adicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipb_adicionar.IconSize = 102;
            this.ipb_adicionar.Location = new System.Drawing.Point(844, 216);
            this.ipb_adicionar.Name = "ipb_adicionar";
            this.ipb_adicionar.Size = new System.Drawing.Size(102, 102);
            this.ipb_adicionar.TabIndex = 18;
            this.ipb_adicionar.TabStop = false;
            this.toolTip1.SetToolTip(this.ipb_adicionar, "Adicionar");
            this.ipb_adicionar.Click += new System.EventHandler(this.ipb_adicionar_Click);
            // 
            // ipb_remover
            // 
            this.ipb_remover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ipb_remover.BackColor = System.Drawing.Color.White;
            this.ipb_remover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.ipb_remover.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.ipb_remover.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.ipb_remover.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipb_remover.IconSize = 102;
            this.ipb_remover.Location = new System.Drawing.Point(844, 336);
            this.ipb_remover.Name = "ipb_remover";
            this.ipb_remover.Size = new System.Drawing.Size(102, 102);
            this.ipb_remover.TabIndex = 19;
            this.ipb_remover.TabStop = false;
            this.toolTip1.SetToolTip(this.ipb_remover, "Remover");
            this.ipb_remover.Click += new System.EventHandler(this.ipb_remover_Click);
            // 
            // btn_finz
            // 
            this.btn_finz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_finz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_finz.BorderColor = System.Drawing.Color.White;
            this.btn_finz.BorderRadius = 37;
            this.btn_finz.BorderSize = 0;
            this.btn_finz.FlatAppearance.BorderSize = 0;
            this.btn_finz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finz.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_finz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_finz.Location = new System.Drawing.Point(796, 489);
            this.btn_finz.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_finz.Name = "btn_finz";
            this.btn_finz.Size = new System.Drawing.Size(199, 45);
            this.btn_finz.TabIndex = 20;
            this.btn_finz.Text = "Finalizar";
            this.toolTip1.SetToolTip(this.btn_finz, "Finalizar");
            this.btn_finz.UseVisualStyleBackColor = false;
            this.btn_finz.Click += new System.EventHandler(this.btn_finz_Click);
            // 
            // lbl_adicionar
            // 
            this.lbl_adicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_adicionar.AutoSize = true;
            this.lbl_adicionar.Font = new System.Drawing.Font("Poppins Light", 14F);
            this.lbl_adicionar.Location = new System.Drawing.Point(843, 179);
            this.lbl_adicionar.Name = "lbl_adicionar";
            this.lbl_adicionar.Size = new System.Drawing.Size(104, 34);
            this.lbl_adicionar.TabIndex = 21;
            this.lbl_adicionar.Text = "Adicionar";
            this.toolTip1.SetToolTip(this.lbl_adicionar, "Adicionar");
            this.lbl_adicionar.Click += new System.EventHandler(this.lbl_adicionar_Click);
            // 
            // lbl_remover
            // 
            this.lbl_remover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_remover.AutoSize = true;
            this.lbl_remover.Font = new System.Drawing.Font("Poppins Light", 14F);
            this.lbl_remover.Location = new System.Drawing.Point(846, 441);
            this.lbl_remover.Name = "lbl_remover";
            this.lbl_remover.Size = new System.Drawing.Size(98, 34);
            this.lbl_remover.TabIndex = 22;
            this.lbl_remover.Text = "Remover";
            this.toolTip1.SetToolTip(this.lbl_remover, "Remover");
            this.lbl_remover.Click += new System.EventHandler(this.lbl_remover_Click);
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_pesquisar.BackColor = System.Drawing.SystemColors.Window;
            this.txt_pesquisar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_pesquisar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_pesquisar.BorderSize = 2;
            this.txt_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_pesquisar.Location = new System.Drawing.Point(795, 84);
            this.txt_pesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pesquisar.Multiline = false;
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Padding = new System.Windows.Forms.Padding(7);
            this.txt_pesquisar.PasswordChar = false;
            this.txt_pesquisar.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(161)))));
            this.txt_pesquisar.PlaceholderText = "";
            this.txt_pesquisar.ReadOnly = false;
            this.txt_pesquisar.Size = new System.Drawing.Size(200, 31);
            this.txt_pesquisar.TabIndex = 10;
            this.txt_pesquisar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_pesquisar.UnderlinedStyle = false;
            this.txt_pesquisar._TextChanged += new System.EventHandler(this.txt_pesquisar__TextChanged);
            // 
            // dtg_produtos
            // 
            this.dtg_produtos.AllowUserToAddRows = false;
            this.dtg_produtos.AllowUserToDeleteRows = false;
            this.dtg_produtos.AllowUserToOrderColumns = true;
            this.dtg_produtos.AllowUserToResizeRows = false;
            this.dtg_produtos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtg_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_produtos.BackgroundColor = System.Drawing.Color.White;
            this.dtg_produtos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_produtos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_produtos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.dtg_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_produtos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_produtos.EnableHeadersVisualStyles = false;
            this.dtg_produtos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.dtg_produtos.Location = new System.Drawing.Point(10, 8);
            this.dtg_produtos.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtg_produtos.MultiSelect = false;
            this.dtg_produtos.Name = "dtg_produtos";
            this.dtg_produtos.ReadOnly = true;
            this.dtg_produtos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtg_produtos.RowHeadersVisible = false;
            this.dtg_produtos.RowTemplate.Height = 30;
            this.dtg_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_produtos.ShowEditingIcon = false;
            this.dtg_produtos.Size = new System.Drawing.Size(763, 664);
            this.dtg_produtos.TabIndex = 16;
            this.dtg_produtos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_produtos_CellDoubleClick);
            // 
            // dtg_lista
            // 
            this.dtg_lista.AllowUserToAddRows = false;
            this.dtg_lista.AllowUserToDeleteRows = false;
            this.dtg_lista.AllowUserToOrderColumns = true;
            this.dtg_lista.AllowUserToResizeRows = false;
            this.dtg_lista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_lista.BackgroundColor = System.Drawing.Color.White;
            this.dtg_lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_lista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_lista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.dtg_lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PRODUTO,
            this.Column1,
            this.PRECO});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_lista.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_lista.EnableHeadersVisualStyles = false;
            this.dtg_lista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.dtg_lista.Location = new System.Drawing.Point(1031, 8);
            this.dtg_lista.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtg_lista.MultiSelect = false;
            this.dtg_lista.Name = "dtg_lista";
            this.dtg_lista.ReadOnly = true;
            this.dtg_lista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtg_lista.RowHeadersVisible = false;
            this.dtg_lista.RowTemplate.Height = 30;
            this.dtg_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_lista.ShowEditingIcon = false;
            this.dtg_lista.Size = new System.Drawing.Size(491, 664);
            this.dtg_lista.TabIndex = 17;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 59;
            // 
            // PRODUTO
            // 
            this.PRODUTO.HeaderText = "PRODUTO";
            this.PRODUTO.Name = "PRODUTO";
            this.PRODUTO.ReadOnly = true;
            this.PRODUTO.Width = 113;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "QUANTIDADE";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 137;
            // 
            // PRECO
            // 
            this.PRECO.HeaderText = "PRECO";
            this.PRECO.Name = "PRECO";
            this.PRECO.ReadOnly = true;
            this.PRECO.Width = 93;
            // 
            // frmAddProdutosVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1534, 682);
            this.Controls.Add(this.lbl_remover);
            this.Controls.Add(this.lbl_adicionar);
            this.Controls.Add(this.btn_finz);
            this.Controls.Add(this.ipb_remover);
            this.Controls.Add(this.ipb_adicionar);
            this.Controls.Add(this.dtg_lista);
            this.Controls.Add(this.dtg_produtos);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbx_pesquisar);
            this.Controls.Add(this.lbl_pesquisar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1172, 554);
            this.Name = "frmAddProdutosVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Produtos";
            this.Activated += new System.EventHandler(this.frmAddProdutosVenda_Activated);
            this.Load += new System.EventHandler(this.frmAddProdutosVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipb_adicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipb_remover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pesquisar;
        private CustomControls.Custom_Controls.CustomComboBox cbx_pesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private CustomControls.CustomTextBox txt_pesquisar;
        private CustomControls.CustomButton btn_pesquisar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private CustomControls.CustomButton btn_voltar;
        private System.Windows.Forms.DataGridView dtg_produtos;
        private System.Windows.Forms.DataGridView dtg_lista;
        private FontAwesome.Sharp.IconPictureBox ipb_adicionar;
        private FontAwesome.Sharp.IconPictureBox ipb_remover;
        private CustomControls.CustomButton btn_finz;
        private System.Windows.Forms.Label lbl_adicionar;
        private System.Windows.Forms.Label lbl_remover;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECO;
    }
}