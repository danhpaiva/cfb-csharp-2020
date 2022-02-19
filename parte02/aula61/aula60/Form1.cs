using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula60
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void btn_texto_Click(object sender, EventArgs e)
        {
            //Pegando texto do textbox e alterando o texto da label
            lb_texto.Text = tb_texto.Text;
        }
    }
}
