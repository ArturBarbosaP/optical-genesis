
namespace Ótica
{
    partial class frmAddQuantidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddQuantidade));
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.btn_voltar = new CustomControls.CustomButton();
            this.btn_adicionar = new CustomControls.CustomButton();
            this.txt_quantidade = new CustomControls.CustomTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Poppins", 9F);
            this.lbl_quantidade.Location = new System.Drawing.Point(32, 45);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(84, 22);
            this.lbl_quantidade.TabIndex = 3;
            this.lbl_quantidade.Text = "Quantidade:";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_voltar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_voltar.BorderRadius = 25;
            this.btn_voltar.BorderSize = 0;
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_voltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_voltar.Location = new System.Drawing.Point(240, 109);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(145, 40);
            this.btn_voltar.TabIndex = 2;
            this.btn_voltar.Text = "Voltar";
            this.toolTip1.SetToolTip(this.btn_voltar, "Voltar");
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.btn_adicionar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_adicionar.BorderRadius = 25;
            this.btn_adicionar.BorderSize = 0;
            this.btn_adicionar.FlatAppearance.BorderSize = 0;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Poppins", 9F);
            this.btn_adicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.btn_adicionar.Location = new System.Drawing.Point(36, 109);
            this.btn_adicionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(145, 40);
            this.btn_adicionar.TabIndex = 1;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_quantidade.BackColor = System.Drawing.Color.White;
            this.txt_quantidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.txt_quantidade.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(117)))));
            this.txt_quantidade.BorderSize = 2;
            this.txt_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txt_quantidade.Location = new System.Drawing.Point(138, 44);
            this.txt_quantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_quantidade.Multiline = false;
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_quantidade.PasswordChar = false;
            this.txt_quantidade.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_quantidade.PlaceholderText = "";
            this.txt_quantidade.ReadOnly = false;
            this.txt_quantidade.Size = new System.Drawing.Size(247, 25);
            this.txt_quantidade.TabIndex = 0;
            this.txt_quantidade.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_quantidade.UnderlinedStyle = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            // 
            // frmAddQuantidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 193);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_quantidade);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(432, 232);
            this.Name = "frmAddQuantidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Quantidade";
            this.Load += new System.EventHandler(this.frmAddQuantidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_quantidade;
        private CustomControls.CustomButton btn_voltar;
        private CustomControls.CustomButton btn_adicionar;
        private CustomControls.CustomTextBox txt_quantidade;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}