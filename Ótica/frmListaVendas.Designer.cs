
namespace Ótica
{
    partial class frmListaVendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaVendas));
            this.dtg_vendas = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbl_pesquisar = new System.Windows.Forms.Label();
            this.cbx_pesquisar = new CustomControls.Custom_Controls.CustomComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_pesquisar = new CustomControls.CustomTextBox();
            this.btn_pesquisar = new CustomControls.CustomButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_voltar = new CustomControls.CustomButton();
            this.dtp_fim = new CustomControls.CustomDatePicker();
            this.dtp_inicio = new CustomControls.CustomDatePicker();
            this.lbl_dataPesq = new System.Windows.Forms.Label();
            this.lbl_dataA = new System.Windows.Forms.Label();
            this.btn_cadVenda = new CustomControls.CustomButton();
            this.btn_visuCliente = new CustomControls.CustomButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_cadCliente = new CustomControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_vendas
            // 
            this.dtg_vendas.AllowUserToAddRows = false;
            this.dtg_vendas.AllowUserToDeleteRows = false;
            this.dtg_vendas.AllowUserToOrderColumns = true;
            this.dtg_vendas.AllowUserToResizeRows = false;
            this.dtg_vendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_vendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_vendas.BackgroundColor = System.Drawing.Color.White;
            this.dtg_vendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_vendas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_vendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.dtg_vendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_vendas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_vendas.EnableHeadersVisualStyles = false;
            this.dtg_vendas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.dtg_vendas.Location = new System.Drawing.Point(10, 8);
            this.dtg_vendas.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtg_vendas.MultiSelect = false;
            this.dtg_vendas.Name = "dtg_vendas";
            this.dtg_vendas.ReadOnly = true;
            this.dtg_vendas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtg_vendas.RowHeadersVisible = false;
            this.dtg_vendas.RowTemplate.Height = 30;
            this.dtg_vendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_vendas.ShowEditingIcon = false;
            this.dtg_vendas.Size = new System.Drawing.Size(907, 576);
            this.dtg_vendas.TabIndex = 13;
            this.dtg_vendas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_vendas_CellDoubleClick);
            this.dtg_vendas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_vendas_CellEnter);
            this.dtg_vendas.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_vendas_CellLeave);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "EDITAR";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.ToolTipText = "Clique duas vezes para editar";
            this.Editar.Width = 75;
            // 
            // lbl_pesquisar
            // 
            this.lbl_pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pesquisar.AutoSize = true;
            this.lbl_pesquisar.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_pesquisar.Location = new System.Drawing.Point(930, 174);
            this.lbl_pesquisar.Name = "lbl_pesquisar";
            this.lbl_pesquisar.Size = new System.Drawing.Size(90, 22);
            this.lbl_pesquisar.TabIndex = 11;
            this.lbl_pesquisar.Text = "Pesquisar por";
            // 
            // cbx_pesquisar
            // 
            this.cbx_pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_pesquisar.BackColor = System.Drawing.Color.White;
            this.cbx_pesquisar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.cbx_pesquisar.BorderSize = 2;
            this.cbx_pesquisar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_pesquisar.Font = new System.Drawing.Font("Poppins", 9F);
            this.cbx_pesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.cbx_pesquisar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.cbx_pesquisar.Items.AddRange(new object[] {
            "Id",
            "Forma de Pagamento",
            "Observacao",
            "Id do Funcionário",
            "Id do Cliente"});
            this.cbx_pesquisar.ListBackColor = System.Drawing.Color.White;
            this.cbx_pesquisar.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.cbx_pesquisar.Location = new System.Drawing.Point(934, 199);
            this.cbx_pesquisar.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbx_pesquisar.Name = "cbx_pesquisar";
            this.cbx_pesquisar.Padding = new System.Windows.Forms.Padding(2);
            this.cbx_pesquisar.Size = new System.Drawing.Size(200, 30);
            this.cbx_pesquisar.TabIndex = 2;
            this.cbx_pesquisar.Texts = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.panel1.Location = new System.Drawing.Point(935, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 2);
            this.panel1.TabIndex = 12;
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pesquisar.BackColor = System.Drawing.SystemColors.Window;
            this.txt_pesquisar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_pesquisar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_pesquisar.BorderSize = 2;
            this.txt_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_pesquisar.Location = new System.Drawing.Point(934, 241);
            this.txt_pesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pesquisar.Multiline = false;
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Padding = new System.Windows.Forms.Padding(7);
            this.txt_pesquisar.PasswordChar = false;
            this.txt_pesquisar.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(161)))));
            this.txt_pesquisar.PlaceholderText = "";
            this.txt_pesquisar.ReadOnly = false;
            this.txt_pesquisar.Size = new System.Drawing.Size(200, 31);
            this.txt_pesquisar.TabIndex = 3;
            this.txt_pesquisar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_pesquisar.UnderlinedStyle = false;
            this.txt_pesquisar._TextChanged += new System.EventHandler(this.txt_pesquisar__TextChanged);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_pesquisar.BorderColor = System.Drawing.Color.White;
            this.btn_pesquisar.BorderRadius = 37;
            this.btn_pesquisar.BorderSize = 0;
            this.btn_pesquisar.FlatAppearance.BorderSize = 0;
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_pesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_pesquisar.Location = new System.Drawing.Point(934, 279);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(200, 45);
            this.btn_pesquisar.TabIndex = 4;
            this.btn_pesquisar.Text = "Pesquisar";
            this.toolTip1.SetToolTip(this.btn_pesquisar, "Pesquisar");
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(1088, 287);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 12;
            this.iconPictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.iconPictureBox1, "Pesquisar");
            // 
            // btn_voltar
            // 
            this.btn_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_voltar.BorderColor = System.Drawing.Color.White;
            this.btn_voltar.BorderRadius = 37;
            this.btn_voltar.BorderSize = 0;
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_voltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_voltar.Location = new System.Drawing.Point(934, 535);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(200, 45);
            this.btn_voltar.TabIndex = 8;
            this.btn_voltar.Text = "Voltar";
            this.toolTip1.SetToolTip(this.btn_voltar, "Voltar");
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // dtp_fim
            // 
            this.dtp_fim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fim.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtp_fim.BorderSize = 0;
            this.dtp_fim.CalendarFont = new System.Drawing.Font("Poppins", 9F);
            this.dtp_fim.DarkerIcon = true;
            this.dtp_fim.Font = new System.Drawing.Font("Poppins", 9F);
            this.dtp_fim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fim.Location = new System.Drawing.Point(934, 131);
            this.dtp_fim.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtp_fim.Name = "dtp_fim";
            this.dtp_fim.Size = new System.Drawing.Size(200, 35);
            this.dtp_fim.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.dtp_fim.TabIndex = 1;
            this.dtp_fim.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.dtp_fim.ValueChanged += new System.EventHandler(this.dtp_fim_ValueChanged);
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_inicio.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtp_inicio.BorderSize = 0;
            this.dtp_inicio.CalendarFont = new System.Drawing.Font("Poppins", 9F);
            this.dtp_inicio.DarkerIcon = true;
            this.dtp_inicio.Font = new System.Drawing.Font("Poppins", 9F);
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicio.Location = new System.Drawing.Point(934, 68);
            this.dtp_inicio.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(200, 35);
            this.dtp_inicio.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.dtp_inicio.TabIndex = 0;
            this.dtp_inicio.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.dtp_inicio.ValueChanged += new System.EventHandler(this.dtp_inicio_ValueChanged);
            // 
            // lbl_dataPesq
            // 
            this.lbl_dataPesq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dataPesq.AutoSize = true;
            this.lbl_dataPesq.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_dataPesq.Location = new System.Drawing.Point(930, 21);
            this.lbl_dataPesq.Name = "lbl_dataPesq";
            this.lbl_dataPesq.Size = new System.Drawing.Size(121, 44);
            this.lbl_dataPesq.TabIndex = 9;
            this.lbl_dataPesq.Text = "Pesquisar por data\r\nDe:\r\n";
            // 
            // lbl_dataA
            // 
            this.lbl_dataA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dataA.AutoSize = true;
            this.lbl_dataA.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_dataA.Location = new System.Drawing.Point(930, 106);
            this.lbl_dataA.Name = "lbl_dataA";
            this.lbl_dataA.Size = new System.Drawing.Size(18, 22);
            this.lbl_dataA.TabIndex = 10;
            this.lbl_dataA.Text = "A";
            // 
            // btn_cadVenda
            // 
            this.btn_cadVenda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_cadVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_cadVenda.BorderColor = System.Drawing.Color.White;
            this.btn_cadVenda.BorderRadius = 37;
            this.btn_cadVenda.BorderSize = 0;
            this.btn_cadVenda.FlatAppearance.BorderSize = 0;
            this.btn_cadVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadVenda.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_cadVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_cadVenda.Location = new System.Drawing.Point(934, 473);
            this.btn_cadVenda.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_cadVenda.Name = "btn_cadVenda";
            this.btn_cadVenda.Size = new System.Drawing.Size(200, 45);
            this.btn_cadVenda.TabIndex = 7;
            this.btn_cadVenda.Text = "Cadastrar Nova Venda";
            this.toolTip1.SetToolTip(this.btn_cadVenda, "Cadastrar Nova Venda");
            this.btn_cadVenda.UseVisualStyleBackColor = false;
            this.btn_cadVenda.Click += new System.EventHandler(this.btn_cadVenda_Click);
            // 
            // btn_visuCliente
            // 
            this.btn_visuCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_visuCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_visuCliente.BorderColor = System.Drawing.Color.White;
            this.btn_visuCliente.BorderRadius = 37;
            this.btn_visuCliente.BorderSize = 0;
            this.btn_visuCliente.FlatAppearance.BorderSize = 0;
            this.btn_visuCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visuCliente.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_visuCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_visuCliente.Location = new System.Drawing.Point(934, 349);
            this.btn_visuCliente.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_visuCliente.Name = "btn_visuCliente";
            this.btn_visuCliente.Size = new System.Drawing.Size(200, 45);
            this.btn_visuCliente.TabIndex = 5;
            this.btn_visuCliente.Text = "Visualizar Clientes";
            this.toolTip1.SetToolTip(this.btn_visuCliente, "Visualizar Clientes");
            this.btn_visuCliente.UseVisualStyleBackColor = false;
            this.btn_visuCliente.Click += new System.EventHandler(this.btn_visuCliente_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            // 
            // btn_cadCliente
            // 
            this.btn_cadCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_cadCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_cadCliente.BorderColor = System.Drawing.Color.White;
            this.btn_cadCliente.BorderRadius = 37;
            this.btn_cadCliente.BorderSize = 0;
            this.btn_cadCliente.FlatAppearance.BorderSize = 0;
            this.btn_cadCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadCliente.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_cadCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_cadCliente.Location = new System.Drawing.Point(934, 411);
            this.btn_cadCliente.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_cadCliente.Name = "btn_cadCliente";
            this.btn_cadCliente.Size = new System.Drawing.Size(200, 45);
            this.btn_cadCliente.TabIndex = 6;
            this.btn_cadCliente.Text = "Cadastrar Novo Cliente";
            this.toolTip1.SetToolTip(this.btn_cadCliente, "Cadastrar Novo Cliente");
            this.btn_cadCliente.UseVisualStyleBackColor = false;
            this.btn_cadCliente.Click += new System.EventHandler(this.btn_cadCliente_Click);
            // 
            // frmListaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 590);
            this.Controls.Add(this.btn_cadCliente);
            this.Controls.Add(this.btn_visuCliente);
            this.Controls.Add(this.btn_cadVenda);
            this.Controls.Add(this.lbl_dataA);
            this.Controls.Add(this.lbl_dataPesq);
            this.Controls.Add(this.dtp_inicio);
            this.Controls.Add(this.dtp_fim);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbx_pesquisar);
            this.Controls.Add(this.lbl_pesquisar);
            this.Controls.Add(this.dtg_vendas);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1172, 554);
            this.Name = "frmListaVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Vendas";
            this.Activated += new System.EventHandler(this.frmListaVendas_Activated);
            this.Load += new System.EventHandler(this.frmListaVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_vendas;
        private System.Windows.Forms.Label lbl_pesquisar;
        private CustomControls.Custom_Controls.CustomComboBox cbx_pesquisar;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.CustomTextBox txt_pesquisar;
        private CustomControls.CustomButton btn_pesquisar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private CustomControls.CustomButton btn_voltar;
        private CustomControls.CustomDatePicker dtp_fim;
        private CustomControls.CustomDatePicker dtp_inicio;
        private System.Windows.Forms.Label lbl_dataPesq;
        private System.Windows.Forms.Label lbl_dataA;
        private CustomControls.CustomButton btn_cadVenda;
        private CustomControls.CustomButton btn_visuCliente;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private CustomControls.CustomButton btn_cadCliente;
    }
}