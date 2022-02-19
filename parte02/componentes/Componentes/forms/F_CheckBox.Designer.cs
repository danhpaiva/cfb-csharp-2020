namespace Componentes
{
    partial class F_CheckBox
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
            this.cb_carro = new System.Windows.Forms.CheckBox();
            this.cb_aviao = new System.Windows.Forms.CheckBox();
            this.cb_navio = new System.Windows.Forms.CheckBox();
            this.cb_onibus = new System.Windows.Forms.CheckBox();
            this.btn_transportesSelecionados = new System.Windows.Forms.Button();
            this.cb_patinete = new System.Windows.Forms.CheckBox();
            this.btn_abrirFormFilho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_carro
            // 
            this.cb_carro.AutoSize = true;
            this.cb_carro.Location = new System.Drawing.Point(13, 13);
            this.cb_carro.Name = "cb_carro";
            this.cb_carro.Size = new System.Drawing.Size(51, 17);
            this.cb_carro.TabIndex = 0;
            this.cb_carro.Text = "Carro";
            this.cb_carro.UseVisualStyleBackColor = true;
            // 
            // cb_aviao
            // 
            this.cb_aviao.AutoSize = true;
            this.cb_aviao.Location = new System.Drawing.Point(13, 37);
            this.cb_aviao.Name = "cb_aviao";
            this.cb_aviao.Size = new System.Drawing.Size(53, 17);
            this.cb_aviao.TabIndex = 1;
            this.cb_aviao.Text = "Avião";
            this.cb_aviao.UseVisualStyleBackColor = true;
            // 
            // cb_navio
            // 
            this.cb_navio.AutoSize = true;
            this.cb_navio.Location = new System.Drawing.Point(13, 61);
            this.cb_navio.Name = "cb_navio";
            this.cb_navio.Size = new System.Drawing.Size(54, 17);
            this.cb_navio.TabIndex = 2;
            this.cb_navio.Text = "Navio";
            this.cb_navio.UseVisualStyleBackColor = true;
            // 
            // cb_onibus
            // 
            this.cb_onibus.AutoSize = true;
            this.cb_onibus.Location = new System.Drawing.Point(13, 85);
            this.cb_onibus.Name = "cb_onibus";
            this.cb_onibus.Size = new System.Drawing.Size(59, 17);
            this.cb_onibus.TabIndex = 3;
            this.cb_onibus.Text = "Ônibus";
            this.cb_onibus.UseVisualStyleBackColor = true;
            // 
            // btn_transportesSelecionados
            // 
            this.btn_transportesSelecionados.Location = new System.Drawing.Point(123, 13);
            this.btn_transportesSelecionados.Name = "btn_transportesSelecionados";
            this.btn_transportesSelecionados.Size = new System.Drawing.Size(198, 23);
            this.btn_transportesSelecionados.TabIndex = 4;
            this.btn_transportesSelecionados.Text = "Transportes selecionados";
            this.btn_transportesSelecionados.UseVisualStyleBackColor = true;
            this.btn_transportesSelecionados.Click += new System.EventHandler(this.btn_transportesSelecionados_Click);
            // 
            // cb_patinete
            // 
            this.cb_patinete.AutoSize = true;
            this.cb_patinete.Location = new System.Drawing.Point(13, 127);
            this.cb_patinete.Name = "cb_patinete";
            this.cb_patinete.Size = new System.Drawing.Size(65, 17);
            this.cb_patinete.TabIndex = 5;
            this.cb_patinete.Text = "Patinete";
            this.cb_patinete.UseVisualStyleBackColor = true;
            this.cb_patinete.CheckedChanged += new System.EventHandler(this.cb_patinete_CheckedChanged);
            // 
            // btn_abrirFormFilho
            // 
            this.btn_abrirFormFilho.Location = new System.Drawing.Point(123, 43);
            this.btn_abrirFormFilho.Name = "btn_abrirFormFilho";
            this.btn_abrirFormFilho.Size = new System.Drawing.Size(198, 23);
            this.btn_abrirFormFilho.TabIndex = 6;
            this.btn_abrirFormFilho.Text = "Abrir form filho";
            this.btn_abrirFormFilho.UseVisualStyleBackColor = true;
            this.btn_abrirFormFilho.Click += new System.EventHandler(this.btn_abrirFormFilho_Click);
            // 
            // F_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 269);
            this.Controls.Add(this.btn_abrirFormFilho);
            this.Controls.Add(this.cb_patinete);
            this.Controls.Add(this.btn_transportesSelecionados);
            this.Controls.Add(this.cb_onibus);
            this.Controls.Add(this.cb_navio);
            this.Controls.Add(this.cb_aviao);
            this.Controls.Add(this.cb_carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_transportesSelecionados;
        private System.Windows.Forms.CheckBox cb_patinete;
        public System.Windows.Forms.CheckBox cb_carro;
        public System.Windows.Forms.CheckBox cb_aviao;
        public System.Windows.Forms.CheckBox cb_navio;
        public System.Windows.Forms.CheckBox cb_onibus;
        private System.Windows.Forms.Button btn_abrirFormFilho;
    }
}