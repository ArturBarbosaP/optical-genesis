
namespace Ótica
{
    partial class frmListaLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaLog));
            this.btn_voltar = new CustomControls.CustomButton();
            this.btn_visu = new CustomControls.CustomButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_pesquisar = new CustomControls.CustomButton();
            this.txt_pesquisar = new CustomControls.CustomTextBox();
            this.cbx_pesquisar = new CustomControls.Custom_Controls.CustomComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_pesquisar = new System.Windows.Forms.Label();
            this.dtp_fim = new CustomControls.CustomDatePicker();
            this.lbl_dataA = new System.Windows.Forms.Label();
            this.dtp_inicio = new CustomControls.CustomDatePicker();
            this.lbl_dataPesq = new System.Windows.Forms.Label();
            this.dtg_log = new System.Windows.Forms.DataGridView();
            this.btn_relatorio = new CustomControls.CustomButton();
            this.btn_excluir = new CustomControls.CustomButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fbdCaminhoPdf = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.btn_voltar.Location = new System.Drawing.Point(934, 554);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(200, 45);
            this.btn_voltar.TabIndex = 8;
            this.btn_voltar.Text = "Voltar";
            this.toolTip1.SetToolTip(this.btn_voltar, "Voltar");
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_visu
            // 
            this.btn_visu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_visu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_visu.BorderColor = System.Drawing.Color.White;
            this.btn_visu.BorderRadius = 37;
            this.btn_visu.BorderSize = 0;
            this.btn_visu.FlatAppearance.BorderSize = 0;
            this.btn_visu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visu.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_visu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_visu.Location = new System.Drawing.Point(934, 344);
            this.btn_visu.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_visu.Name = "btn_visu";
            this.btn_visu.Size = new System.Drawing.Size(200, 45);
            this.btn_visu.TabIndex = 9;
            this.btn_visu.Text = "Visualizar Evento Selecionado";
            this.toolTip1.SetToolTip(this.btn_visu, "Visualizar Evento Selecionado");
            this.btn_visu.UseVisualStyleBackColor = false;
            this.btn_visu.Click += new System.EventHandler(this.btn_visu_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(1088, 287);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 14;
            this.iconPictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.iconPictureBox1, "Pesquisar");
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.btn_pesquisar.TabIndex = 13;
            this.btn_pesquisar.Text = "Pesquisar";
            this.toolTip1.SetToolTip(this.btn_pesquisar, "Pesquisar");
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.txt_pesquisar.TabIndex = 15;
            this.txt_pesquisar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_pesquisar.UnderlinedStyle = false;
            this.txt_pesquisar._TextChanged += new System.EventHandler(this.txt_pesquisar__TextChanged);
            // 
            // cbx_pesquisar
            // 
            this.cbx_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbx_pesquisar.BackColor = System.Drawing.Color.White;
            this.cbx_pesquisar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.cbx_pesquisar.BorderSize = 2;
            this.cbx_pesquisar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_pesquisar.Font = new System.Drawing.Font("Poppins", 9F);
            this.cbx_pesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.cbx_pesquisar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.cbx_pesquisar.Items.AddRange(new object[] {
            "Id",
            "Tabela",
            "Tipo"});
            this.cbx_pesquisar.ListBackColor = System.Drawing.Color.White;
            this.cbx_pesquisar.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.cbx_pesquisar.Location = new System.Drawing.Point(934, 199);
            this.cbx_pesquisar.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbx_pesquisar.Name = "cbx_pesquisar";
            this.cbx_pesquisar.Padding = new System.Windows.Forms.Padding(2);
            this.cbx_pesquisar.Size = new System.Drawing.Size(200, 30);
            this.cbx_pesquisar.TabIndex = 16;
            this.cbx_pesquisar.Texts = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.panel1.Location = new System.Drawing.Point(935, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 2);
            this.panel1.TabIndex = 17;
            // 
            // lbl_pesquisar
            // 
            this.lbl_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_pesquisar.AutoSize = true;
            this.lbl_pesquisar.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_pesquisar.Location = new System.Drawing.Point(930, 174);
            this.lbl_pesquisar.Name = "lbl_pesquisar";
            this.lbl_pesquisar.Size = new System.Drawing.Size(90, 22);
            this.lbl_pesquisar.TabIndex = 12;
            this.lbl_pesquisar.Text = "Pesquisar por";
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
            this.dtp_fim.TabIndex = 18;
            this.dtp_fim.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.dtp_fim.ValueChanged += new System.EventHandler(this.dtp_fim_ValueChanged);
            // 
            // lbl_dataA
            // 
            this.lbl_dataA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dataA.AutoSize = true;
            this.lbl_dataA.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_dataA.Location = new System.Drawing.Point(930, 106);
            this.lbl_dataA.Name = "lbl_dataA";
            this.lbl_dataA.Size = new System.Drawing.Size(18, 22);
            this.lbl_dataA.TabIndex = 19;
            this.lbl_dataA.Text = "A";
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
            this.dtp_inicio.TabIndex = 20;
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
            this.lbl_dataPesq.TabIndex = 21;
            this.lbl_dataPesq.Text = "Pesquisar por data\r\nDe:\r\n";
            // 
            // dtg_log
            // 
            this.dtg_log.AllowUserToAddRows = false;
            this.dtg_log.AllowUserToDeleteRows = false;
            this.dtg_log.AllowUserToOrderColumns = true;
            this.dtg_log.AllowUserToResizeRows = false;
            this.dtg_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_log.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_log.BackgroundColor = System.Drawing.Color.White;
            this.dtg_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_log.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_log.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.dtg_log.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_log.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_log.EnableHeadersVisualStyles = false;
            this.dtg_log.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.dtg_log.Location = new System.Drawing.Point(10, 8);
            this.dtg_log.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtg_log.MultiSelect = false;
            this.dtg_log.Name = "dtg_log";
            this.dtg_log.ReadOnly = true;
            this.dtg_log.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtg_log.RowHeadersVisible = false;
            this.dtg_log.RowTemplate.Height = 30;
            this.dtg_log.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_log.ShowEditingIcon = false;
            this.dtg_log.Size = new System.Drawing.Size(907, 591);
            this.dtg_log.TabIndex = 22;
            this.dtg_log.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_log_CellDoubleClick);
            // 
            // btn_relatorio
            // 
            this.btn_relatorio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_relatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_relatorio.BorderColor = System.Drawing.Color.White;
            this.btn_relatorio.BorderRadius = 37;
            this.btn_relatorio.BorderSize = 0;
            this.btn_relatorio.FlatAppearance.BorderSize = 0;
            this.btn_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_relatorio.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_relatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_relatorio.Location = new System.Drawing.Point(934, 401);
            this.btn_relatorio.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_relatorio.Name = "btn_relatorio";
            this.btn_relatorio.Size = new System.Drawing.Size(200, 45);
            this.btn_relatorio.TabIndex = 23;
            this.btn_relatorio.Text = "Gerar Relatório";
            this.toolTip1.SetToolTip(this.btn_relatorio, "Gerar Relatório");
            this.btn_relatorio.UseVisualStyleBackColor = false;
            this.btn_relatorio.Click += new System.EventHandler(this.btn_relatorio_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_excluir.BorderColor = System.Drawing.Color.White;
            this.btn_excluir.BorderRadius = 37;
            this.btn_excluir.BorderSize = 0;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_excluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_excluir.Location = new System.Drawing.Point(934, 492);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(200, 45);
            this.btn_excluir.TabIndex = 24;
            this.btn_excluir.Text = "Excluir";
            this.toolTip1.SetToolTip(this.btn_excluir, "Excluir");
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.iconPictureBox2.Location = new System.Drawing.Point(1088, 407);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 25;
            this.iconPictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.iconPictureBox2, "Gerar Relatório");
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            // 
            // frmListaLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 609);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_relatorio);
            this.Controls.Add(this.dtg_log);
            this.Controls.Add(this.lbl_dataPesq);
            this.Controls.Add(this.dtp_inicio);
            this.Controls.Add(this.lbl_dataA);
            this.Controls.Add(this.dtp_fim);
            this.Controls.Add(this.lbl_pesquisar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbx_pesquisar);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.btn_visu);
            this.Controls.Add(this.btn_voltar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1172, 554);
            this.Name = "frmListaLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Eventos";
            this.Activated += new System.EventHandler(this.frmListaLog_Activated);
            this.Load += new System.EventHandler(this.frmListaLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CustomButton btn_voltar;
        private CustomControls.CustomButton btn_visu;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private CustomControls.CustomButton btn_pesquisar;
        private CustomControls.CustomTextBox txt_pesquisar;
        private CustomControls.Custom_Controls.CustomComboBox cbx_pesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_pesquisar;
        private CustomControls.CustomDatePicker dtp_fim;
        private System.Windows.Forms.Label lbl_dataA;
        private CustomControls.CustomDatePicker dtp_inicio;
        private System.Windows.Forms.Label lbl_dataPesq;
        private System.Windows.Forms.DataGridView dtg_log;
        private CustomControls.CustomButton btn_relatorio;
        private CustomControls.CustomButton btn_excluir;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FolderBrowserDialog fbdCaminhoPdf;
    }
}