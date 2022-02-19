namespace aula60
{
    partial class F_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_texto = new System.Windows.Forms.Button();
            this.lb_texto = new System.Windows.Forms.Label();
            this.tb_texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_texto
            // 
            this.btn_texto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_texto.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_texto.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_texto.Location = new System.Drawing.Point(12, 97);
            this.btn_texto.Name = "btn_texto";
            this.btn_texto.Size = new System.Drawing.Size(160, 49);
            this.btn_texto.TabIndex = 0;
            this.btn_texto.Text = "OK";
            this.btn_texto.UseVisualStyleBackColor = false;
            this.btn_texto.Click += new System.EventHandler(this.btn_texto_Click);
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texto.Location = new System.Drawing.Point(12, 166);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(445, 25);
            this.lb_texto.TabIndex = 1;
            this.lb_texto.Text = "https://www.linkedin.com/in/danhpaiva/";
            // 
            // tb_texto
            // 
            this.tb_texto.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_texto.Location = new System.Drawing.Point(12, 45);
            this.tb_texto.Name = "tb_texto";
            this.tb_texto.Size = new System.Drawing.Size(160, 33);
            this.tb_texto.TabIndex = 2;
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.tb_texto);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.btn_texto);
            this.Name = "F_Principal";
            this.Text = "Curso de C# - CFB Cursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_texto;
        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.TextBox tb_texto;
    }
}

