namespace Componentes
{
    partial class F_LinkLabel
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.ll_Linkedin = new System.Windows.Forms.LinkLabel();
            this.ll_calculadora = new System.Windows.Forms.LinkLabel();
            this.ll_multiplosLinks = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(25, 38);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(229, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // ll_Linkedin
            // 
            this.ll_Linkedin.AutoSize = true;
            this.ll_Linkedin.Location = new System.Drawing.Point(25, 93);
            this.ll_Linkedin.Name = "ll_Linkedin";
            this.ll_Linkedin.Size = new System.Drawing.Size(48, 13);
            this.ll_Linkedin.TabIndex = 2;
            this.ll_Linkedin.TabStop = true;
            this.ll_Linkedin.Text = "LinkedIn";
            this.ll_Linkedin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_Linkedin_LinkClicked);
            // 
            // ll_calculadora
            // 
            this.ll_calculadora.AutoSize = true;
            this.ll_calculadora.Location = new System.Drawing.Point(99, 93);
            this.ll_calculadora.Name = "ll_calculadora";
            this.ll_calculadora.Size = new System.Drawing.Size(63, 13);
            this.ll_calculadora.TabIndex = 3;
            this.ll_calculadora.TabStop = true;
            this.ll_calculadora.Text = "Calculadora";
            this.ll_calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_calculadora_LinkClicked);
            // 
            // ll_multiplosLinks
            // 
            this.ll_multiplosLinks.AutoSize = true;
            this.ll_multiplosLinks.Location = new System.Drawing.Point(28, 140);
            this.ll_multiplosLinks.Name = "ll_multiplosLinks";
            this.ll_multiplosLinks.Size = new System.Drawing.Size(132, 13);
            this.ll_multiplosLinks.TabIndex = 4;
            this.ll_multiplosLinks.TabStop = true;
            this.ll_multiplosLinks.Text = "Google - GitHub - Youtube";
            this.ll_multiplosLinks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_multiplosLinks_LinkClicked);
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.ll_multiplosLinks);
            this.Controls.Add(this.ll_calculadora);
            this.Controls.Add(this.ll_Linkedin);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.Name = "F_LinkLabel";
            this.Text = "F_LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.LinkLabel ll_Linkedin;
        private System.Windows.Forms.LinkLabel ll_calculadora;
        private System.Windows.Forms.LinkLabel ll_multiplosLinks;
    }
}