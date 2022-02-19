namespace Componentes
{
    partial class F_MaskedTextBox
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
            this.mtb_senha = new System.Windows.Forms.MaskedTextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.mtb_CPF = new System.Windows.Forms.MaskedTextBox();
            this.btn_mostrarCPF = new System.Windows.Forms.Button();
            this.cb_somenteTexto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mtb_senha
            // 
            this.mtb_senha.Location = new System.Drawing.Point(12, 35);
            this.mtb_senha.Name = "mtb_senha";
            this.mtb_senha.PasswordChar = '*';
            this.mtb_senha.Size = new System.Drawing.Size(227, 20);
            this.mtb_senha.TabIndex = 0;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(12, 17);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_senha.TabIndex = 1;
            this.lbl_senha.Text = "Senha";
            this.lbl_senha.Click += new System.EventHandler(this.Lbl_senha_Click);
            // 
            // mtb_CPF
            // 
            this.mtb_CPF.Location = new System.Drawing.Point(12, 88);
            this.mtb_CPF.Mask = "000.000.000-00";
            this.mtb_CPF.Name = "mtb_CPF";
            this.mtb_CPF.Size = new System.Drawing.Size(227, 20);
            this.mtb_CPF.TabIndex = 2;
            this.mtb_CPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btn_mostrarCPF
            // 
            this.btn_mostrarCPF.Location = new System.Drawing.Point(361, 88);
            this.btn_mostrarCPF.Name = "btn_mostrarCPF";
            this.btn_mostrarCPF.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrarCPF.TabIndex = 3;
            this.btn_mostrarCPF.Text = "Mostrar";
            this.btn_mostrarCPF.UseVisualStyleBackColor = true;
            this.btn_mostrarCPF.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cb_somenteTexto
            // 
            this.cb_somenteTexto.AutoSize = true;
            this.cb_somenteTexto.Location = new System.Drawing.Point(245, 91);
            this.cb_somenteTexto.Name = "cb_somenteTexto";
            this.cb_somenteTexto.Size = new System.Drawing.Size(98, 17);
            this.cb_somenteTexto.TabIndex = 4;
            this.cb_somenteTexto.Text = "Somente Texto";
            this.cb_somenteTexto.UseVisualStyleBackColor = true;
            // 
            // F_MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 180);
            this.Controls.Add(this.cb_somenteTexto);
            this.Controls.Add(this.btn_mostrarCPF);
            this.Controls.Add(this.mtb_CPF);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.mtb_senha);
            this.Name = "F_MaskedTextBox";
            this.Text = "F_MaskedTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_senha;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.MaskedTextBox mtb_CPF;
        private System.Windows.Forms.Button btn_mostrarCPF;
        private System.Windows.Forms.CheckBox cb_somenteTexto;
    }
}