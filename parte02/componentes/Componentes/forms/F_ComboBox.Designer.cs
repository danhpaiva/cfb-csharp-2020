namespace Componentes
{
    partial class F_ComboBox
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
            this.cb_transportes = new System.Windows.Forms.ComboBox();
            this.btn_mostrarSelecionado = new System.Windows.Forms.Button();
            this.btn_limparElemento = new System.Windows.Forms.Button();
            this.btn_resetarElemento = new System.Windows.Forms.Button();
            this.tb_transporte = new System.Windows.Forms.TextBox();
            this.btn_addNovoTransporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.cb_transportes.Location = new System.Drawing.Point(12, 12);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(144, 21);
            this.cb_transportes.TabIndex = 0;
            this.cb_transportes.SelectedIndexChanged += new System.EventHandler(this.cb_transportes_SelectedIndexChanged);
            // 
            // btn_mostrarSelecionado
            // 
            this.btn_mostrarSelecionado.Location = new System.Drawing.Point(162, 12);
            this.btn_mostrarSelecionado.Name = "btn_mostrarSelecionado";
            this.btn_mostrarSelecionado.Size = new System.Drawing.Size(210, 23);
            this.btn_mostrarSelecionado.TabIndex = 1;
            this.btn_mostrarSelecionado.Text = "Mostrar Selecionado";
            this.btn_mostrarSelecionado.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionado.Click += new System.EventHandler(this.btn_mostrarSelecionado_Click);
            // 
            // btn_limparElemento
            // 
            this.btn_limparElemento.Location = new System.Drawing.Point(162, 42);
            this.btn_limparElemento.Name = "btn_limparElemento";
            this.btn_limparElemento.Size = new System.Drawing.Size(210, 23);
            this.btn_limparElemento.TabIndex = 2;
            this.btn_limparElemento.Text = "Limpar Elementos";
            this.btn_limparElemento.UseVisualStyleBackColor = true;
            this.btn_limparElemento.Click += new System.EventHandler(this.btn_limparElemento_Click);
            // 
            // btn_resetarElemento
            // 
            this.btn_resetarElemento.Location = new System.Drawing.Point(162, 72);
            this.btn_resetarElemento.Name = "btn_resetarElemento";
            this.btn_resetarElemento.Size = new System.Drawing.Size(210, 23);
            this.btn_resetarElemento.TabIndex = 3;
            this.btn_resetarElemento.Text = "Resetar Elementos";
            this.btn_resetarElemento.UseVisualStyleBackColor = true;
            this.btn_resetarElemento.Click += new System.EventHandler(this.btn_resetarElemento_Click);
            // 
            // tb_transporte
            // 
            this.tb_transporte.Location = new System.Drawing.Point(162, 113);
            this.tb_transporte.Name = "tb_transporte";
            this.tb_transporte.Size = new System.Drawing.Size(208, 20);
            this.tb_transporte.TabIndex = 4;
            // 
            // btn_addNovoTransporte
            // 
            this.btn_addNovoTransporte.Location = new System.Drawing.Point(162, 140);
            this.btn_addNovoTransporte.Name = "btn_addNovoTransporte";
            this.btn_addNovoTransporte.Size = new System.Drawing.Size(208, 23);
            this.btn_addNovoTransporte.TabIndex = 5;
            this.btn_addNovoTransporte.Text = "Adicionar Novo Transporte";
            this.btn_addNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_addNovoTransporte.Click += new System.EventHandler(this.btn_addNovoTransporte_Click);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 367);
            this.Controls.Add(this.btn_addNovoTransporte);
            this.Controls.Add(this.tb_transporte);
            this.Controls.Add(this.btn_resetarElemento);
            this.Controls.Add(this.btn_limparElemento);
            this.Controls.Add(this.btn_mostrarSelecionado);
            this.Controls.Add(this.cb_transportes);
            this.Name = "F_ComboBox";
            this.Text = "F_ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_transportes;
        private System.Windows.Forms.Button btn_mostrarSelecionado;
        private System.Windows.Forms.Button btn_limparElemento;
        private System.Windows.Forms.Button btn_resetarElemento;
        private System.Windows.Forms.TextBox tb_transporte;
        private System.Windows.Forms.Button btn_addNovoTransporte;
    }
}