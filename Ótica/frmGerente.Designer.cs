
namespace Ótica
{
    partial class frmGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerente));
            this.lbl_produtos = new System.Windows.Forms.Label();
            this.lbl_vendas = new System.Windows.Forms.Label();
            this.lbl_funcionario = new System.Windows.Forms.Label();
            this.lbl_voltar = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.imi_log = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imi_funcionarios = new FontAwesome.Sharp.IconMenuItem();
            this.imi_clientes = new FontAwesome.Sharp.IconMenuItem();
            this.imi_produtos = new FontAwesome.Sharp.IconMenuItem();
            this.imi_vendas = new FontAwesome.Sharp.IconMenuItem();
            this.img_voltar = new FontAwesome.Sharp.IconPictureBox();
            this.img_funcionario = new FontAwesome.Sharp.IconPictureBox();
            this.img_vendas = new FontAwesome.Sharp.IconPictureBox();
            this.img_produtos = new FontAwesome.Sharp.IconPictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtg_listar = new System.Windows.Forms.DataGridView();
            this.fbdCaminhoPdf = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_funcionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_vendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_produtos
            // 
            this.lbl_produtos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_produtos.AutoSize = true;
            this.lbl_produtos.Font = new System.Drawing.Font("Poppins Light", 24.75F);
            this.lbl_produtos.Location = new System.Drawing.Point(113, 81);
            this.lbl_produtos.Name = "lbl_produtos";
            this.lbl_produtos.Size = new System.Drawing.Size(170, 58);
            this.lbl_produtos.TabIndex = 0;
            this.lbl_produtos.Text = "Produtos";
            this.toolTip1.SetToolTip(this.lbl_produtos, "Produtos");
            this.lbl_produtos.Click += new System.EventHandler(this.lbl_produtos_Click);
            // 
            // lbl_vendas
            // 
            this.lbl_vendas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_vendas.AutoSize = true;
            this.lbl_vendas.Font = new System.Drawing.Font("Poppins Light", 24.75F);
            this.lbl_vendas.Location = new System.Drawing.Point(393, 81);
            this.lbl_vendas.Name = "lbl_vendas";
            this.lbl_vendas.Size = new System.Drawing.Size(322, 58);
            this.lbl_vendas.TabIndex = 1;
            this.lbl_vendas.Text = "Vendas e Clientes";
            this.toolTip1.SetToolTip(this.lbl_vendas, "Vendas e Clientes");
            this.lbl_vendas.Click += new System.EventHandler(this.lbl_vendas_Click);
            // 
            // lbl_funcionario
            // 
            this.lbl_funcionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_funcionario.AutoSize = true;
            this.lbl_funcionario.Font = new System.Drawing.Font("Poppins Light", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_funcionario.Location = new System.Drawing.Point(794, 81);
            this.lbl_funcionario.Name = "lbl_funcionario";
            this.lbl_funcionario.Size = new System.Drawing.Size(233, 58);
            this.lbl_funcionario.TabIndex = 2;
            this.lbl_funcionario.Text = "Funcionários";
            this.toolTip1.SetToolTip(this.lbl_funcionario, "Funcionários");
            this.lbl_funcionario.Click += new System.EventHandler(this.lbl_funcionario_Click);
            // 
            // lbl_voltar
            // 
            this.lbl_voltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_voltar.AutoSize = true;
            this.lbl_voltar.Font = new System.Drawing.Font("Poppins Light", 15F);
            this.lbl_voltar.Location = new System.Drawing.Point(1023, 9);
            this.lbl_voltar.Name = "lbl_voltar";
            this.lbl_voltar.Size = new System.Drawing.Size(74, 36);
            this.lbl_voltar.TabIndex = 4;
            this.lbl_voltar.Text = "Voltar";
            this.toolTip1.SetToolTip(this.lbl_voltar, "Voltar");
            this.lbl_voltar.Click += new System.EventHandler(this.lbl_voltar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Poppins", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1109, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.AutoToolTip = true;
            this.iconMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imi_log,
            this.toolStripSeparator1,
            this.imi_funcionarios,
            this.imi_clientes,
            this.imi_produtos,
            this.imi_vendas});
            this.iconMenuItem1.Font = new System.Drawing.Font("Poppins", 10F);
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconMenuItem1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconMenuItem1.IconSize = 90;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(108, 29);
            this.iconMenuItem1.Text = "Relatórios";
            this.iconMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imi_log
            // 
            this.imi_log.AutoToolTip = true;
            this.imi_log.Font = new System.Drawing.Font("Poppins", 9.3F);
            this.imi_log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.imi_log.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.imi_log.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.imi_log.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.imi_log.Name = "imi_log";
            this.imi_log.Size = new System.Drawing.Size(244, 28);
            this.imi_log.Text = "Registro de Eventos";
            this.imi_log.Click += new System.EventHandler(this.imi_log_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(161)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(241, 6);
            // 
            // imi_funcionarios
            // 
            this.imi_funcionarios.AutoToolTip = true;
            this.imi_funcionarios.Font = new System.Drawing.Font("Poppins", 9.3F);
            this.imi_funcionarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.imi_funcionarios.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.imi_funcionarios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.imi_funcionarios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.imi_funcionarios.Name = "imi_funcionarios";
            this.imi_funcionarios.Size = new System.Drawing.Size(244, 28);
            this.imi_funcionarios.Text = "Relatório de Funcionários";
            this.imi_funcionarios.Click += new System.EventHandler(this.imi_funcionarios_Click);
            // 
            // imi_clientes
            // 
            this.imi_clientes.AutoToolTip = true;
            this.imi_clientes.Font = new System.Drawing.Font("Poppins", 9.3F);
            this.imi_clientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.imi_clientes.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.imi_clientes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.imi_clientes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.imi_clientes.Name = "imi_clientes";
            this.imi_clientes.Size = new System.Drawing.Size(244, 28);
            this.imi_clientes.Text = "Relatório de Clientes";
            this.imi_clientes.Click += new System.EventHandler(this.imi_clientes_Click);
            // 
            // imi_produtos
            // 
            this.imi_produtos.AutoToolTip = true;
            this.imi_produtos.Font = new System.Drawing.Font("Poppins", 9.3F);
            this.imi_produtos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.imi_produtos.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.imi_produtos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.imi_produtos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.imi_produtos.Name = "imi_produtos";
            this.imi_produtos.Size = new System.Drawing.Size(244, 28);
            this.imi_produtos.Text = "Relatório de Produtos";
            this.imi_produtos.Click += new System.EventHandler(this.imi_produtos_Click);
            // 
            // imi_vendas
            // 
            this.imi_vendas.AutoToolTip = true;
            this.imi_vendas.Font = new System.Drawing.Font("Poppins", 9.3F);
            this.imi_vendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.imi_vendas.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.imi_vendas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.imi_vendas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.imi_vendas.Name = "imi_vendas";
            this.imi_vendas.Size = new System.Drawing.Size(244, 28);
            this.imi_vendas.Text = "Relatório de Vendas";
            this.imi_vendas.Click += new System.EventHandler(this.imi_vendas_Click);
            // 
            // img_voltar
            // 
            this.img_voltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.img_voltar.BackColor = System.Drawing.Color.White;
            this.img_voltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.img_voltar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.img_voltar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.img_voltar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.img_voltar.IconSize = 33;
            this.img_voltar.Location = new System.Drawing.Point(994, 11);
            this.img_voltar.Name = "img_voltar";
            this.img_voltar.Size = new System.Drawing.Size(33, 33);
            this.img_voltar.TabIndex = 39;
            this.img_voltar.TabStop = false;
            this.toolTip1.SetToolTip(this.img_voltar, "Voltar");
            this.img_voltar.Click += new System.EventHandler(this.img_voltar_Click);
            // 
            // img_funcionario
            // 
            this.img_funcionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.img_funcionario.BackColor = System.Drawing.Color.White;
            this.img_funcionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.img_funcionario.IconChar = FontAwesome.Sharp.IconChar.User;
            this.img_funcionario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.img_funcionario.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.img_funcionario.IconSize = 278;
            this.img_funcionario.Location = new System.Drawing.Point(771, 142);
            this.img_funcionario.Name = "img_funcionario";
            this.img_funcionario.Size = new System.Drawing.Size(278, 278);
            this.img_funcionario.TabIndex = 2;
            this.img_funcionario.TabStop = false;
            this.toolTip1.SetToolTip(this.img_funcionario, "Funcionários");
            this.img_funcionario.Click += new System.EventHandler(this.img_funcionario_Click);
            // 
            // img_vendas
            // 
            this.img_vendas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.img_vendas.BackColor = System.Drawing.Color.White;
            this.img_vendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.img_vendas.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.img_vendas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.img_vendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.img_vendas.IconSize = 278;
            this.img_vendas.Location = new System.Drawing.Point(415, 142);
            this.img_vendas.Name = "img_vendas";
            this.img_vendas.Size = new System.Drawing.Size(278, 278);
            this.img_vendas.TabIndex = 1;
            this.img_vendas.TabStop = false;
            this.toolTip1.SetToolTip(this.img_vendas, "Vendas e Clientes");
            this.img_vendas.Click += new System.EventHandler(this.img_vendas_Click);
            // 
            // img_produtos
            // 
            this.img_produtos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.img_produtos.BackColor = System.Drawing.Color.White;
            this.img_produtos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.img_produtos.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.img_produtos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.img_produtos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.img_produtos.IconSize = 278;
            this.img_produtos.Location = new System.Drawing.Point(59, 142);
            this.img_produtos.Name = "img_produtos";
            this.img_produtos.Size = new System.Drawing.Size(278, 278);
            this.img_produtos.TabIndex = 0;
            this.img_produtos.TabStop = false;
            this.toolTip1.SetToolTip(this.img_produtos, "Produtos");
            this.img_produtos.Click += new System.EventHandler(this.img_produtos_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            // 
            // dtg_listar
            // 
            this.dtg_listar.AllowUserToAddRows = false;
            this.dtg_listar.AllowUserToDeleteRows = false;
            this.dtg_listar.AllowUserToOrderColumns = true;
            this.dtg_listar.AllowUserToResizeRows = false;
            this.dtg_listar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_listar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_listar.BackgroundColor = System.Drawing.Color.White;
            this.dtg_listar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_listar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_listar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.dtg_listar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_listar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_listar.EnableHeadersVisualStyles = false;
            this.dtg_listar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.dtg_listar.Location = new System.Drawing.Point(979, 429);
            this.dtg_listar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtg_listar.MultiSelect = false;
            this.dtg_listar.Name = "dtg_listar";
            this.dtg_listar.ReadOnly = true;
            this.dtg_listar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtg_listar.RowHeadersVisible = false;
            this.dtg_listar.RowTemplate.Height = 30;
            this.dtg_listar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_listar.ShowEditingIcon = false;
            this.dtg_listar.Size = new System.Drawing.Size(118, 62);
            this.dtg_listar.TabIndex = 40;
            this.dtg_listar.Visible = false;
            // 
            // frmGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1109, 501);
            this.Controls.Add(this.dtg_listar);
            this.Controls.Add(this.img_voltar);
            this.Controls.Add(this.lbl_voltar);
            this.Controls.Add(this.lbl_funcionario);
            this.Controls.Add(this.lbl_vendas);
            this.Controls.Add(this.lbl_produtos);
            this.Controls.Add(this.img_funcionario);
            this.Controls.Add(this.img_vendas);
            this.Controls.Add(this.img_produtos);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1125, 540);
            this.Name = "frmGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_funcionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_vendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox img_produtos;
        private FontAwesome.Sharp.IconPictureBox img_vendas;
        private FontAwesome.Sharp.IconPictureBox img_funcionario;
        private System.Windows.Forms.Label lbl_produtos;
        private System.Windows.Forms.Label lbl_vendas;
        private System.Windows.Forms.Label lbl_funcionario;
        private System.Windows.Forms.Label lbl_voltar;
        private FontAwesome.Sharp.IconPictureBox img_voltar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem imi_log;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private FontAwesome.Sharp.IconMenuItem imi_funcionarios;
        private FontAwesome.Sharp.IconMenuItem imi_clientes;
        private FontAwesome.Sharp.IconMenuItem imi_produtos;
        private FontAwesome.Sharp.IconMenuItem imi_vendas;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dtg_listar;
        private System.Windows.Forms.FolderBrowserDialog fbdCaminhoPdf;
    }
}