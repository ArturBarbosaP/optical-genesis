
namespace Ótica
{
    partial class frmFinalizarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinalizarVenda));
            this.lbl_idFuncionario = new System.Windows.Forms.Label();
            this.txt_idFuncionario = new CustomControls.CustomTextBox();
            this.lbl_dataVenda = new System.Windows.Forms.Label();
            this.dtp_dataVenda = new CustomControls.CustomDatePicker();
            this.lbl_idCliente = new System.Windows.Forms.Label();
            this.txt_idCliente = new CustomControls.CustomTextBox();
            this.lbl_pagamento = new System.Windows.Forms.Label();
            this.cbx_pagamento = new CustomControls.Custom_Controls.CustomComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_voltar = new CustomControls.CustomButton();
            this.btn_inserir = new CustomControls.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_obs = new System.Windows.Forms.Label();
            this.txt_obs = new CustomControls.CustomTextBox();
            this.dtg_produtos = new System.Windows.Forms.DataGridView();
            this.txt_preco = new CustomControls.CustomTextBox();
            this.lbl_preco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_idFuncionario
            // 
            this.lbl_idFuncionario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_idFuncionario.AutoSize = true;
            this.lbl_idFuncionario.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_idFuncionario.Location = new System.Drawing.Point(173, 25);
            this.lbl_idFuncionario.Name = "lbl_idFuncionario";
            this.lbl_idFuncionario.Size = new System.Drawing.Size(117, 22);
            this.lbl_idFuncionario.TabIndex = 20;
            this.lbl_idFuncionario.Text = "ID do Funcionário:";
            // 
            // txt_idFuncionario
            // 
            this.txt_idFuncionario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_idFuncionario.BackColor = System.Drawing.Color.White;
            this.txt_idFuncionario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_idFuncionario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_idFuncionario.BorderSize = 2;
            this.txt_idFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_idFuncionario.Location = new System.Drawing.Point(307, 24);
            this.txt_idFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idFuncionario.Multiline = false;
            this.txt_idFuncionario.Name = "txt_idFuncionario";
            this.txt_idFuncionario.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_idFuncionario.PasswordChar = false;
            this.txt_idFuncionario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_idFuncionario.PlaceholderText = "";
            this.txt_idFuncionario.ReadOnly = false;
            this.txt_idFuncionario.Size = new System.Drawing.Size(29, 25);
            this.txt_idFuncionario.TabIndex = 21;
            this.txt_idFuncionario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_idFuncionario.UnderlinedStyle = false;
            // 
            // lbl_dataVenda
            // 
            this.lbl_dataVenda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_dataVenda.AutoSize = true;
            this.lbl_dataVenda.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_dataVenda.Location = new System.Drawing.Point(365, 25);
            this.lbl_dataVenda.Name = "lbl_dataVenda";
            this.lbl_dataVenda.Size = new System.Drawing.Size(102, 22);
            this.lbl_dataVenda.TabIndex = 22;
            this.lbl_dataVenda.Text = "Data da Venda:";
            // 
            // dtp_dataVenda
            // 
            this.dtp_dataVenda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_dataVenda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.dtp_dataVenda.BorderSize = 2;
            this.dtp_dataVenda.CalendarFont = new System.Drawing.Font("Poppins", 9F);
            this.dtp_dataVenda.DarkerIcon = true;
            this.dtp_dataVenda.Font = new System.Drawing.Font("Poppins", 9F);
            this.dtp_dataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataVenda.Location = new System.Drawing.Point(482, 19);
            this.dtp_dataVenda.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtp_dataVenda.Name = "dtp_dataVenda";
            this.dtp_dataVenda.Size = new System.Drawing.Size(139, 35);
            this.dtp_dataVenda.SkinColor = System.Drawing.Color.White;
            this.dtp_dataVenda.TabIndex = 23;
            this.dtp_dataVenda.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            // 
            // lbl_idCliente
            // 
            this.lbl_idCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_idCliente.AutoSize = true;
            this.lbl_idCliente.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_idCliente.Location = new System.Drawing.Point(23, 25);
            this.lbl_idCliente.Name = "lbl_idCliente";
            this.lbl_idCliente.Size = new System.Drawing.Size(87, 22);
            this.lbl_idCliente.TabIndex = 24;
            this.lbl_idCliente.Text = "ID do Cliente:";
            // 
            // txt_idCliente
            // 
            this.txt_idCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_idCliente.BackColor = System.Drawing.Color.White;
            this.txt_idCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_idCliente.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_idCliente.BorderSize = 2;
            this.txt_idCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_idCliente.Location = new System.Drawing.Point(128, 24);
            this.txt_idCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idCliente.Multiline = false;
            this.txt_idCliente.Name = "txt_idCliente";
            this.txt_idCliente.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_idCliente.PasswordChar = false;
            this.txt_idCliente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_idCliente.PlaceholderText = "";
            this.txt_idCliente.ReadOnly = false;
            this.txt_idCliente.Size = new System.Drawing.Size(29, 25);
            this.txt_idCliente.TabIndex = 25;
            this.txt_idCliente.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_idCliente.UnderlinedStyle = false;
            // 
            // lbl_pagamento
            // 
            this.lbl_pagamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pagamento.AutoSize = true;
            this.lbl_pagamento.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_pagamento.Location = new System.Drawing.Point(226, 77);
            this.lbl_pagamento.Name = "lbl_pagamento";
            this.lbl_pagamento.Size = new System.Drawing.Size(142, 22);
            this.lbl_pagamento.TabIndex = 26;
            this.lbl_pagamento.Text = "Forma de Pagamento:";
            // 
            // cbx_pagamento
            // 
            this.cbx_pagamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx_pagamento.BackColor = System.Drawing.Color.White;
            this.cbx_pagamento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.cbx_pagamento.BorderSize = 2;
            this.cbx_pagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_pagamento.Font = new System.Drawing.Font("Poppins", 9F);
            this.cbx_pagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.cbx_pagamento.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.cbx_pagamento.Items.AddRange(new object[] {
            "Cartão de Crédito",
            "Cartão de Débito",
            "Dinheiro",
            "PIX"});
            this.cbx_pagamento.ListBackColor = System.Drawing.Color.White;
            this.cbx_pagamento.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.cbx_pagamento.Location = new System.Drawing.Point(374, 73);
            this.cbx_pagamento.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbx_pagamento.Name = "cbx_pagamento";
            this.cbx_pagamento.Padding = new System.Windows.Forms.Padding(2);
            this.cbx_pagamento.Size = new System.Drawing.Size(247, 30);
            this.cbx_pagamento.TabIndex = 27;
            this.cbx_pagamento.Texts = "";
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
            this.btn_voltar.Location = new System.Drawing.Point(476, 343);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(145, 40);
            this.btn_voltar.TabIndex = 35;
            this.btn_voltar.Text = "Cancelar";
            this.toolTip1.SetToolTip(this.btn_voltar, "Cancelar");
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
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
            this.btn_inserir.Location = new System.Drawing.Point(27, 343);
            this.btn_inserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(145, 40);
            this.btn_inserir.TabIndex = 31;
            this.btn_inserir.Text = "Inserir";
            this.toolTip1.SetToolTip(this.btn_inserir, "Inserir");
            this.btn_inserir.UseVisualStyleBackColor = false;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.panel1.Location = new System.Drawing.Point(374, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 2);
            this.panel1.TabIndex = 28;
            // 
            // lbl_obs
            // 
            this.lbl_obs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_obs.AutoSize = true;
            this.lbl_obs.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_obs.Location = new System.Drawing.Point(23, 131);
            this.lbl_obs.Name = "lbl_obs";
            this.lbl_obs.Size = new System.Drawing.Size(85, 22);
            this.lbl_obs.TabIndex = 18;
            this.lbl_obs.Text = "Observação:";
            // 
            // txt_obs
            // 
            this.txt_obs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_obs.BackColor = System.Drawing.Color.White;
            this.txt_obs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_obs.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_obs.BorderSize = 2;
            this.txt_obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_obs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_obs.Location = new System.Drawing.Point(130, 131);
            this.txt_obs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_obs.PasswordChar = false;
            this.txt_obs.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_obs.PlaceholderText = "";
            this.txt_obs.ReadOnly = false;
            this.txt_obs.Size = new System.Drawing.Size(491, 174);
            this.txt_obs.TabIndex = 29;
            this.txt_obs.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_obs.UnderlinedStyle = false;
            // 
            // dtg_produtos
            // 
            this.dtg_produtos.AllowUserToAddRows = false;
            this.dtg_produtos.AllowUserToDeleteRows = false;
            this.dtg_produtos.AllowUserToOrderColumns = true;
            this.dtg_produtos.AllowUserToResizeRows = false;
            this.dtg_produtos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.dtg_produtos.Location = new System.Drawing.Point(636, 19);
            this.dtg_produtos.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtg_produtos.MultiSelect = false;
            this.dtg_produtos.Name = "dtg_produtos";
            this.dtg_produtos.ReadOnly = true;
            this.dtg_produtos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtg_produtos.RowHeadersVisible = false;
            this.dtg_produtos.RowTemplate.Height = 30;
            this.dtg_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_produtos.ShowEditingIcon = false;
            this.dtg_produtos.Size = new System.Drawing.Size(348, 364);
            this.dtg_produtos.TabIndex = 30;
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
            this.txt_preco.Location = new System.Drawing.Point(118, 76);
            this.txt_preco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_preco.Multiline = false;
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_preco.PasswordChar = false;
            this.txt_preco.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(161)))));
            this.txt_preco.PlaceholderText = "";
            this.txt_preco.ReadOnly = true;
            this.txt_preco.Size = new System.Drawing.Size(82, 25);
            this.txt_preco.TabIndex = 36;
            this.txt_preco.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_preco.UnderlinedStyle = false;
            // 
            // lbl_preco
            // 
            this.lbl_preco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_preco.Location = new System.Drawing.Point(23, 77);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(77, 22);
            this.lbl_preco.TabIndex = 37;
            this.lbl_preco.Text = "Preço Final:";
            this.toolTip1.SetToolTip(this.lbl_preco, "R$");
            // 
            // frmFinalizarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 404);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.dtg_produtos);
            this.Controls.Add(this.txt_obs);
            this.Controls.Add(this.lbl_obs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbx_pagamento);
            this.Controls.Add(this.lbl_pagamento);
            this.Controls.Add(this.txt_idCliente);
            this.Controls.Add(this.lbl_idCliente);
            this.Controls.Add(this.dtp_dataVenda);
            this.Controls.Add(this.lbl_dataVenda);
            this.Controls.Add(this.txt_idFuncionario);
            this.Controls.Add(this.lbl_idFuncionario);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1027, 443);
            this.Name = "frmFinalizarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizar Venda";
            this.Load += new System.EventHandler(this.frmFinalizarVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_idFuncionario;
        private CustomControls.CustomTextBox txt_idFuncionario;
        private System.Windows.Forms.Label lbl_dataVenda;
        private CustomControls.CustomDatePicker dtp_dataVenda;
        private System.Windows.Forms.Label lbl_idCliente;
        private CustomControls.CustomTextBox txt_idCliente;
        private System.Windows.Forms.Label lbl_pagamento;
        private CustomControls.Custom_Controls.CustomComboBox cbx_pagamento;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_obs;
        private CustomControls.CustomTextBox txt_obs;
        private System.Windows.Forms.DataGridView dtg_produtos;
        private CustomControls.CustomButton btn_voltar;
        private CustomControls.CustomButton btn_inserir;
        private CustomControls.CustomTextBox txt_preco;
        private System.Windows.Forms.Label lbl_preco;
    }
}