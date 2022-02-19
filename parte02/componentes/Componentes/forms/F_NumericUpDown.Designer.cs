namespace Componentes
{
    partial class F_NumericUpDown
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
            this.nud_numeros = new System.Windows.Forms.NumericUpDown();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.btn_definirValor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numeros)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_numeros
            // 
            this.nud_numeros.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_numeros.Location = new System.Drawing.Point(12, 23);
            this.nud_numeros.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_numeros.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_numeros.Name = "nud_numeros";
            this.nud_numeros.Size = new System.Drawing.Size(120, 20);
            this.nud_numeros.TabIndex = 0;
            this.nud_numeros.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(160, 24);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(100, 20);
            this.tb_valor.TabIndex = 1;
            this.tb_valor.Text = "0";
            // 
            // btn_definirValor
            // 
            this.btn_definirValor.Location = new System.Drawing.Point(276, 22);
            this.btn_definirValor.Name = "btn_definirValor";
            this.btn_definirValor.Size = new System.Drawing.Size(75, 23);
            this.btn_definirValor.TabIndex = 2;
            this.btn_definirValor.Text = "Definir Valor";
            this.btn_definirValor.UseVisualStyleBackColor = true;
            this.btn_definirValor.Click += new System.EventHandler(this.Btn_definirValor_Click);
            // 
            // F_NumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 330);
            this.Controls.Add(this.btn_definirValor);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.nud_numeros);
            this.Name = "F_NumericUpDown";
            this.Text = "F_NumericUpDown";
            ((System.ComponentModel.ISupportInitialize)(this.nud_numeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_numeros;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Button btn_definirValor;
    }
}