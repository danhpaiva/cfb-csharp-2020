namespace Componentes
{
    partial class F_MonthCalendar
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
            this.mc_calendario = new System.Windows.Forms.MonthCalendar();
            this.tb_dataAtual = new System.Windows.Forms.TextBox();
            this.tb_dataInicial = new System.Windows.Forms.TextBox();
            this.btn_pegarData = new System.Windows.Forms.Button();
            this.tb_dataFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mc_calendario
            // 
            this.mc_calendario.Location = new System.Drawing.Point(18, 18);
            this.mc_calendario.MaxSelectionCount = 30;
            this.mc_calendario.Name = "mc_calendario";
            this.mc_calendario.TabIndex = 0;
            this.mc_calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Mc_calendario_DateChanged);
            // 
            // tb_dataAtual
            // 
            this.tb_dataAtual.Location = new System.Drawing.Point(257, 71);
            this.tb_dataAtual.Name = "tb_dataAtual";
            this.tb_dataAtual.Size = new System.Drawing.Size(176, 20);
            this.tb_dataAtual.TabIndex = 1;
            // 
            // tb_dataInicial
            // 
            this.tb_dataInicial.Location = new System.Drawing.Point(257, 119);
            this.tb_dataInicial.Name = "tb_dataInicial";
            this.tb_dataInicial.Size = new System.Drawing.Size(176, 20);
            this.tb_dataInicial.TabIndex = 2;
            this.tb_dataInicial.TextChanged += new System.EventHandler(this.Tb_dataInicial_TextChanged);
            // 
            // btn_pegarData
            // 
            this.btn_pegarData.Location = new System.Drawing.Point(257, 18);
            this.btn_pegarData.Name = "btn_pegarData";
            this.btn_pegarData.Size = new System.Drawing.Size(176, 23);
            this.btn_pegarData.TabIndex = 3;
            this.btn_pegarData.Text = "Pegar Data";
            this.btn_pegarData.UseVisualStyleBackColor = true;
            this.btn_pegarData.Click += new System.EventHandler(this.Btn_pegarData_Click);
            // 
            // tb_dataFinal
            // 
            this.tb_dataFinal.Location = new System.Drawing.Point(257, 160);
            this.tb_dataFinal.Name = "tb_dataFinal";
            this.tb_dataFinal.Size = new System.Drawing.Size(176, 20);
            this.tb_dataFinal.TabIndex = 4;
            this.tb_dataFinal.TextChanged += new System.EventHandler(this.Tb_dataFinal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Atual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data Inicial do Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Final do Range";
            // 
            // F_MonthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 249);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_dataFinal);
            this.Controls.Add(this.btn_pegarData);
            this.Controls.Add(this.tb_dataInicial);
            this.Controls.Add(this.tb_dataAtual);
            this.Controls.Add(this.mc_calendario);
            this.Name = "F_MonthCalendar";
            this.Text = "F_MonthCalendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mc_calendario;
        private System.Windows.Forms.TextBox tb_dataAtual;
        private System.Windows.Forms.TextBox tb_dataInicial;
        private System.Windows.Forms.Button btn_pegarData;
        private System.Windows.Forms.TextBox tb_dataFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}