
namespace Componentes
{
    partial class F_TabControl
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
            this.tab_ctrl_principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_novaTab = new System.Windows.Forms.TextBox();
            this.btn_novaTab = new System.Windows.Forms.Button();
            this.btn_removerTab = new System.Windows.Forms.Button();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.btn_posicionarTab = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tab_ctrl_principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_ctrl_principal
            // 
            this.tab_ctrl_principal.Controls.Add(this.tabPage1);
            this.tab_ctrl_principal.Controls.Add(this.tabPage2);
            this.tab_ctrl_principal.Location = new System.Drawing.Point(12, 81);
            this.tab_ctrl_principal.Name = "tab_ctrl_principal";
            this.tab_ctrl_principal.SelectedIndex = 0;
            this.tab_ctrl_principal.Size = new System.Drawing.Size(594, 260);
            this.tab_ctrl_principal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 234);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Componentes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 234);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_novaTab
            // 
            this.tb_novaTab.Location = new System.Drawing.Point(16, 13);
            this.tb_novaTab.Name = "tb_novaTab";
            this.tb_novaTab.Size = new System.Drawing.Size(100, 20);
            this.tb_novaTab.TabIndex = 1;
            // 
            // btn_novaTab
            // 
            this.btn_novaTab.Location = new System.Drawing.Point(134, 13);
            this.btn_novaTab.Name = "btn_novaTab";
            this.btn_novaTab.Size = new System.Drawing.Size(126, 23);
            this.btn_novaTab.TabIndex = 2;
            this.btn_novaTab.Text = "Nova Tab";
            this.btn_novaTab.UseVisualStyleBackColor = true;
            this.btn_novaTab.Click += new System.EventHandler(this.btn_novaTab_Click);
            // 
            // btn_removerTab
            // 
            this.btn_removerTab.Location = new System.Drawing.Point(266, 13);
            this.btn_removerTab.Name = "btn_removerTab";
            this.btn_removerTab.Size = new System.Drawing.Size(126, 23);
            this.btn_removerTab.TabIndex = 3;
            this.btn_removerTab.Text = "Remover Tab Atual";
            this.btn_removerTab.UseVisualStyleBackColor = true;
            this.btn_removerTab.Click += new System.EventHandler(this.btn_removerTab_Click);
            // 
            // numUpDown
            // 
            this.numUpDown.Location = new System.Drawing.Point(16, 52);
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(100, 20);
            this.numUpDown.TabIndex = 4;
            // 
            // btn_posicionarTab
            // 
            this.btn_posicionarTab.Location = new System.Drawing.Point(134, 52);
            this.btn_posicionarTab.Name = "btn_posicionarTab";
            this.btn_posicionarTab.Size = new System.Drawing.Size(126, 23);
            this.btn_posicionarTab.TabIndex = 5;
            this.btn_posicionarTab.Text = "Posicionar na Tab";
            this.btn_posicionarTab.UseVisualStyleBackColor = true;
            this.btn_posicionarTab.Click += new System.EventHandler(this.btn_posicionarTab_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // F_TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 353);
            this.Controls.Add(this.btn_posicionarTab);
            this.Controls.Add(this.numUpDown);
            this.Controls.Add(this.btn_removerTab);
            this.Controls.Add(this.btn_novaTab);
            this.Controls.Add(this.tb_novaTab);
            this.Controls.Add(this.tab_ctrl_principal);
            this.Name = "F_TabControl";
            this.Text = "F_TabControl";
            this.Load += new System.EventHandler(this.F_TabControl_Load);
            this.tab_ctrl_principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_ctrl_principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_novaTab;
        private System.Windows.Forms.Button btn_novaTab;
        private System.Windows.Forms.Button btn_removerTab;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Button btn_posicionarTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}