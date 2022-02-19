namespace Componentes
{
    partial class F_TreeView
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
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("HRV");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Fit");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Honda", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Palio");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("UNO");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Fiat", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_removerSelecionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode19.Name = "hrv";
            treeNode19.Tag = "https://www.honda.com.br/automoveis/hrv";
            treeNode19.Text = "HRV";
            treeNode20.Name = "fit";
            treeNode20.Text = "Fit";
            treeNode21.Name = "honda";
            treeNode21.Text = "Honda";
            treeNode22.Name = "palio";
            treeNode22.Text = "Palio";
            treeNode23.Name = "uno";
            treeNode23.Text = "UNO";
            treeNode24.Name = "fiat";
            treeNode24.Text = "Fiat";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode24});
            this.treeView1.Size = new System.Drawing.Size(139, 219);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(157, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(130, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(156, 41);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(79, 23);
            this.btn_remover.TabIndex = 2;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.Btn_remover_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 4;
            // 
            // btn_removerSelecionado
            // 
            this.btn_removerSelecionado.Location = new System.Drawing.Point(241, 41);
            this.btn_removerSelecionado.Name = "btn_removerSelecionado";
            this.btn_removerSelecionado.Size = new System.Drawing.Size(107, 23);
            this.btn_removerSelecionado.TabIndex = 5;
            this.btn_removerSelecionado.Text = "Remover Selec.";
            this.btn_removerSelecionado.UseVisualStyleBackColor = true;
            this.btn_removerSelecionado.Click += new System.EventHandler(this.Btn_removerSelecionado_Click);
            // 
            // F_TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 278);
            this.Controls.Add(this.btn_removerSelecionado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.treeView1);
            this.Name = "F_TreeView";
            this.Text = "F_TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_removerSelecionado;
    }
}