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
    public partial class F_RadioButton : Form
    {
        public F_RadioButton()
        {
            InitializeComponent();
        }

        private void Btn_selecionado_Click(object sender, EventArgs e)
        {
            string text = "";

            text = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;

            tb_selecionado.Text = text;
            MessageBox.Show(text);
        }

        private void Btn_selecionadoDois_Click(object sender, EventArgs e)
        {
            string text = "";

            foreach (RadioButton rb in groupBox1.Controls)
            {
                if (rb.Checked)
                {
                    text = rb.Text;
                    tb_selecionado.Text = text;
                }
            }

            MessageBox.Show(text);
        }
    }
}
