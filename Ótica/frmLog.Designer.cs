
namespace Ótica
{
    partial class frmLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLog));
            this.txt_id = new CustomControls.CustomTextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.dtp_data = new CustomControls.CustomDatePicker();
            this.lbl_data = new System.Windows.Forms.Label();
            this.txt_tabela = new CustomControls.CustomTextBox();
            this.lbl_tabela = new System.Windows.Forms.Label();
            this.txt_tipo = new CustomControls.CustomTextBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.txt_desc = new CustomControls.CustomTextBox();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.btn_voltar = new CustomControls.CustomButton();
            this.btn_relatorio = new CustomControls.CustomButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fbdCaminhoPdf = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
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
            this.txt_id.Location = new System.Drawing.Point(67, 38);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            this.txt_id.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_id.PasswordChar = false;
            this.txt_id.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_id.PlaceholderText = "";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(29, 25);
            this.txt_id.TabIndex = 6;
            this.txt_id.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_id.UnderlinedStyle = false;
            // 
            // lbl_id
            // 
            this.lbl_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_id.Location = new System.Drawing.Point(25, 39);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(24, 22);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "ID:";
            // 
            // dtp_data
            // 
            this.dtp_data.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_data.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.dtp_data.BorderSize = 2;
            this.dtp_data.CalendarFont = new System.Drawing.Font("Poppins", 9F);
            this.dtp_data.DarkerIcon = true;
            this.dtp_data.Enabled = false;
            this.dtp_data.Font = new System.Drawing.Font("Poppins", 9F);
            this.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data.Location = new System.Drawing.Point(173, 33);
            this.dtp_data.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(139, 35);
            this.dtp_data.SkinColor = System.Drawing.Color.White;
            this.dtp_data.TabIndex = 7;
            this.dtp_data.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            // 
            // lbl_data
            // 
            this.lbl_data.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_data.Location = new System.Drawing.Point(114, 39);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(41, 22);
            this.lbl_data.TabIndex = 2;
            this.lbl_data.Text = "Data:";
            // 
            // txt_tabela
            // 
            this.txt_tabela.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_tabela.BackColor = System.Drawing.Color.White;
            this.txt_tabela.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_tabela.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_tabela.BorderSize = 2;
            this.txt_tabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tabela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_tabela.Location = new System.Drawing.Point(401, 38);
            this.txt_tabela.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tabela.Multiline = false;
            this.txt_tabela.Name = "txt_tabela";
            this.txt_tabela.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_tabela.PasswordChar = false;
            this.txt_tabela.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_tabela.PlaceholderText = "";
            this.txt_tabela.ReadOnly = true;
            this.txt_tabela.Size = new System.Drawing.Size(191, 25);
            this.txt_tabela.TabIndex = 8;
            this.txt_tabela.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_tabela.UnderlinedStyle = false;
            // 
            // lbl_tabela
            // 
            this.lbl_tabela.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_tabela.AutoSize = true;
            this.lbl_tabela.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_tabela.Location = new System.Drawing.Point(330, 39);
            this.lbl_tabela.Name = "lbl_tabela";
            this.lbl_tabela.Size = new System.Drawing.Size(53, 22);
            this.lbl_tabela.TabIndex = 3;
            this.lbl_tabela.Text = "Tabela:";
            // 
            // txt_tipo
            // 
            this.txt_tipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_tipo.BackColor = System.Drawing.Color.White;
            this.txt_tipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_tipo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_tipo.BorderSize = 2;
            this.txt_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_tipo.Location = new System.Drawing.Point(666, 38);
            this.txt_tipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tipo.Multiline = false;
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_tipo.PasswordChar = false;
            this.txt_tipo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_tipo.PlaceholderText = "";
            this.txt_tipo.ReadOnly = true;
            this.txt_tipo.Size = new System.Drawing.Size(196, 25);
            this.txt_tipo.TabIndex = 9;
            this.txt_tipo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_tipo.UnderlinedStyle = false;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_tipo.Location = new System.Drawing.Point(610, 39);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(38, 22);
            this.lbl_tipo.TabIndex = 4;
            this.lbl_tipo.Text = "Tipo:";
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
            this.txt_desc.Location = new System.Drawing.Point(125, 101);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_desc.PasswordChar = false;
            this.txt_desc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_desc.PlaceholderText = "";
            this.txt_desc.ReadOnly = true;
            this.txt_desc.Size = new System.Drawing.Size(570, 178);
            this.txt_desc.TabIndex = 10;
            this.txt_desc.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_desc.UnderlinedStyle = false;
            // 
            // lbl_desc
            // 
            this.lbl_desc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_desc.Location = new System.Drawing.Point(25, 101);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(71, 22);
            this.lbl_desc.TabIndex = 5;
            this.lbl_desc.Text = "Descrição:";
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
            this.btn_voltar.Location = new System.Drawing.Point(717, 239);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(145, 40);
            this.btn_voltar.TabIndex = 0;
            this.btn_voltar.Text = "Voltar";
            this.toolTip1.SetToolTip(this.btn_voltar, "Voltar");
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_relatorio
            // 
            this.btn_relatorio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_relatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_relatorio.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_relatorio.BorderRadius = 25;
            this.btn_relatorio.BorderSize = 0;
            this.btn_relatorio.FlatAppearance.BorderSize = 0;
            this.btn_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_relatorio.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_relatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_relatorio.Location = new System.Drawing.Point(717, 185);
            this.btn_relatorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_relatorio.Name = "btn_relatorio";
            this.btn_relatorio.Size = new System.Drawing.Size(145, 40);
            this.btn_relatorio.TabIndex = 25;
            this.btn_relatorio.Text = "Gerar Relatório";
            this.toolTip1.SetToolTip(this.btn_relatorio, "Gerar Relatório");
            this.btn_relatorio.UseVisualStyleBackColor = false;
            this.btn_relatorio.Click += new System.EventHandler(this.btn_relatorio_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 316);
            this.Controls.Add(this.btn_relatorio);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.txt_tabela);
            this.Controls.Add(this.lbl_tabela);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(890, 355);
            this.Name = "frmLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Evento";
            this.Load += new System.EventHandler(this.frmLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CustomTextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private CustomControls.CustomDatePicker dtp_data;
        private System.Windows.Forms.Label lbl_data;
        private CustomControls.CustomTextBox txt_tabela;
        private System.Windows.Forms.Label lbl_tabela;
        private CustomControls.CustomTextBox txt_tipo;
        private System.Windows.Forms.Label lbl_tipo;
        private CustomControls.CustomTextBox txt_desc;
        private System.Windows.Forms.Label lbl_desc;
        private CustomControls.CustomButton btn_voltar;
        private CustomControls.CustomButton btn_relatorio;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FolderBrowserDialog fbdCaminhoPdf;
    }
}