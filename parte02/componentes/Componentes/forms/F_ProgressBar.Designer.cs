namespace Componentes
{
    partial class F_ProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_definirValor = new System.Windows.Forms.Button();
            this.btn_preencher = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 140);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(569, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 50;
            // 
            // btn_definirValor
            // 
            this.btn_definirValor.Location = new System.Drawing.Point(13, 59);
            this.btn_definirValor.Name = "btn_definirValor";
            this.btn_definirValor.Size = new System.Drawing.Size(75, 23);
            this.btn_definirValor.TabIndex = 1;
            this.btn_definirValor.Text = "Definir Valor";
            this.btn_definirValor.UseVisualStyleBackColor = true;
            this.btn_definirValor.Click += new System.EventHandler(this.Btn_definirValor_Click);
            // 
            // btn_preencher
            // 
            this.btn_preencher.Location = new System.Drawing.Point(12, 111);
            this.btn_preencher.Name = "btn_preencher";
            this.btn_preencher.Size = new System.Drawing.Size(75, 23);
            this.btn_preencher.TabIndex = 2;
            this.btn_preencher.Text = "Preencher";
            this.btn_preencher.UseVisualStyleBackColor = true;
            this.btn_preencher.Click += new System.EventHandler(this.Btn_preencher_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // F_ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 203);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_preencher);
            this.Controls.Add(this.btn_definirValor);
            this.Controls.Add(this.progressBar1);
            this.Name = "F_ProgressBar";
            this.Text = "F_ProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_definirValor;
        private System.Windows.Forms.Button btn_preencher;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}