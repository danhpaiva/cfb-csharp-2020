using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_TreeView : Form
    {
        public F_TreeView()
        {
            InitializeComponent();
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox2.Clear();
            textBox1.Text = treeView1.SelectedNode.Text;
            if(treeView1.SelectedNode.Tag != null)
            {
                textBox2.Text = treeView1.SelectedNode.Tag.ToString();
            }
            
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            TreeNode raizEstados = treeView1.Nodes.Add("Estados");
            raizEstados.Name = "raizEstados";

            TreeNode raizCores = treeView1.Nodes.Add("Cores");
            raizCores.Name = "raizCores";

            TreeNode estado1 = raizEstados.Nodes.Add("Minas Gerais");
            estado1.Name = "Minas Gerais";

            TreeNode estado2 = raizEstados.Nodes.Add("Rio de Janeiro");
            estado2.Name = "Rio de Janeiro";

            TreeNode estado3 = raizEstados.Nodes.Add("São Paulo");
            estado3.Name = "São Paulo";

            TreeNode cor1 = raizCores.Nodes.Add("Azul");
            cor1.Name = "Azul";

            TreeNode cor2 = raizCores.Nodes.Add("Vermelho");
            cor2.Name = "Vermelho";

        }

        private void Btn_removerSelecionado_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao remover nó.");
            }
            
        }

        private void Btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Remove(treeView1.Nodes["raizEstados"]);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao remover nó: " + ex.GetType() + " (nó estados não foi criado ainda... ou já foi excluído");
            }
        }
    }
}
