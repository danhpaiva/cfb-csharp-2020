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
    public partial class F_TabControl : Form
    {
        public F_TabControl()
        {
            InitializeComponent();
        }

        private void btn_novaTab_Click(object sender, EventArgs e)
        {
            if (tb_novaTab.Text != "")
            {
                TabPage pagina = new TabPage();
                pagina.Text = tb_novaTab.Text;
                pagina.Name = tb_novaTab.Text;
                pagina.TabIndex = tab_ctrl_principal.TabPages.Count;

                tab_ctrl_principal.TabPages.Add(pagina);
                tb_novaTab.Clear();
                DefinirMaximo();
            }
            else
            {
                MessageBox.Show("Digite o noma da nova página.");
                tb_novaTab.Focus();
            }
        }

        private void btn_removerTab_Click(object sender, EventArgs e)
        {
            tab_ctrl_principal.TabPages.Remove(tab_ctrl_principal.SelectedTab);
            DefinirMaximo();
        }

        private void btn_posicionarTab_Click(object sender, EventArgs e)
        {
                tab_ctrl_principal.SelectedIndex = int.Parse(numUpDown.Value.ToString());
        }

        private void DefinirMaximo()
        {
            numUpDown.Maximum = tab_ctrl_principal.TabPages.Count-1;
        }

        private void F_TabControl_Load(object sender, EventArgs e)
        {
            DefinirMaximo();
        }
    }
}
