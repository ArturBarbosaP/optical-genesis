
namespace Ótica
{
    partial class frmListaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaClientes));
            this.dtg_clientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_pesquisar = new CustomControls.Custom_Controls.CustomComboBox();
            this.btn_pesquisar = new CustomControls.CustomButton();
            this.lbl_pesquisar = new System.Windows.Forms.Label();
            this.btn_voltar = new CustomControls.CustomButton();
            this.btn_cadastrar = new CustomControls.CustomButton();
            this.txt_pesquisar = new CustomControls.CustomTextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_clientes
            // 
            this.dtg_clientes.AllowUserToAddRows = false;
            this.dtg_clientes.AllowUserToDeleteRows = false;
            this.dtg_clientes.AllowUserToOrderColumns = true;
            this.dtg_clientes.AllowUserToResizeRows = false;
            this.dtg_clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_clientes.BackgroundColor = System.Drawing.Color.White;
            this.dtg_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.dtg_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_clientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_clientes.EnableHeadersVisualStyles = false;
            this.dtg_clientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.dtg_clientes.Location = new System.Drawing.Point(10, 8);
            this.dtg_clientes.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtg_clientes.MultiSelect = false;
            this.dtg_clientes.Name = "dtg_clientes";
            this.dtg_clientes.ReadOnly = true;
            this.dtg_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtg_clientes.RowHeadersVisible = false;
            this.dtg_clientes.RowTemplate.Height = 30;
            this.dtg_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_clientes.ShowEditingIcon = false;
            this.dtg_clientes.Size = new System.Drawing.Size(907, 501);
            this.dtg_clientes.TabIndex = 5;
            this.dtg_clientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_clientes_CellDoubleClick);
            this.dtg_clientes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_clientes_CellEnter);
            this.dtg_clientes.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_clientes_CellLeave);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.panel1.Location = new System.Drawing.Point(935, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 2);
            this.panel1.TabIndex = 7;
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
            "Nome",
            "CPF",
            "Telefone",
            "Email",
            "CEP",
            "Estado",
            "Cidade",
            "Bairro",
            "Rua",
            "Numero",
            "Complemento"});
            this.cbx_pesquisar.ListBackColor = System.Drawing.Color.White;
            this.cbx_pesquisar.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.cbx_pesquisar.Location = new System.Drawing.Point(934, 207);
            this.cbx_pesquisar.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbx_pesquisar.Name = "cbx_pesquisar";
            this.cbx_pesquisar.Padding = new System.Windows.Forms.Padding(2);
            this.cbx_pesquisar.Size = new System.Drawing.Size(200, 30);
            this.cbx_pesquisar.TabIndex = 0;
            this.cbx_pesquisar.Texts = "";
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
            this.btn_pesquisar.Location = new System.Drawing.Point(934, 287);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(200, 45);
            this.btn_pesquisar.TabIndex = 2;
            this.btn_pesquisar.Text = "Pesquisar";
            this.toolTip1.SetToolTip(this.btn_pesquisar, "Pesquisar");
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // lbl_pesquisar
            // 
            this.lbl_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_pesquisar.AutoSize = true;
            this.lbl_pesquisar.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_pesquisar.Location = new System.Drawing.Point(931, 182);
            this.lbl_pesquisar.Name = "lbl_pesquisar";
            this.lbl_pesquisar.Size = new System.Drawing.Size(90, 22);
            this.lbl_pesquisar.TabIndex = 6;
            this.lbl_pesquisar.Text = "Pesquisar por";
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
            this.btn_voltar.Location = new System.Drawing.Point(935, 451);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(199, 45);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Voltar";
            this.toolTip1.SetToolTip(this.btn_voltar, "Voltar");
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_cadastrar.BorderColor = System.Drawing.Color.White;
            this.btn_cadastrar.BorderRadius = 37;
            this.btn_cadastrar.BorderSize = 0;
            this.btn_cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_cadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_cadastrar.Location = new System.Drawing.Point(934, 375);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(200, 45);
            this.btn_cadastrar.TabIndex = 3;
            this.btn_cadastrar.Text = "Cadastrar Novo Cliente";
            this.toolTip1.SetToolTip(this.btn_cadastrar, "Cadastrar Novo Cliente");
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
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
            this.txt_pesquisar.Location = new System.Drawing.Point(934, 249);
            this.txt_pesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pesquisar.Multiline = false;
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Padding = new System.Windows.Forms.Padding(7);
            this.txt_pesquisar.PasswordChar = false;
            this.txt_pesquisar.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(161)))));
            this.txt_pesquisar.PlaceholderText = "";
            this.txt_pesquisar.ReadOnly = false;
            this.txt_pesquisar.Size = new System.Drawing.Size(200, 31);
            this.txt_pesquisar.TabIndex = 1;
            this.txt_pesquisar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_pesquisar.UnderlinedStyle = false;
            this.txt_pesquisar._TextChanged += new System.EventHandler(this.txt_pesquisar__TextChanged);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(1088, 295);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 15;
            this.iconPictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.iconPictureBox1, "Pesquisar");
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
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
            // frmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 515);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbx_pesquisar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.lbl_pesquisar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.dtg_clientes);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1172, 554);
            this.Name = "frmListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Clientes";
            this.Activated += new System.EventHandler(this.frmListaClientes_Activated);
            this.Load += new System.EventHandler(this.frmListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_clientes;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.Custom_Controls.CustomComboBox cbx_pesquisar;
        private CustomControls.CustomButton btn_pesquisar;
        private System.Windows.Forms.Label lbl_pesquisar;
        private CustomControls.CustomButton btn_voltar;
        private CustomControls.CustomButton btn_cadastrar;
        private CustomControls.CustomTextBox txt_pesquisar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}