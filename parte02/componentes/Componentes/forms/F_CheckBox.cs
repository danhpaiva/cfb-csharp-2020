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
    public partial class F_CheckBox : Form
    {

        List<CheckBox> transp = new List<CheckBox>();
        public F_CheckBox()
        {
            InitializeComponent();
            transp.Add(cb_carro);
            transp.Add(cb_aviao);
            transp.Add(cb_navio);
            transp.Add(cb_onibus);
        }

        private void btn_transportesSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach (CheckBox t in transp)
            {
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                }
            }

            MessageBox.Show(txt);
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_patinete.Checked)
            {
                MessageBox.Show("Patinete marcado!");
            }
        }

        private void btn_abrirFormFilho_Click(object sender, EventArgs e)
        {
            F_filhoCheckBox f_FilhoCheckBox = new F_filhoCheckBox();
            f_FilhoCheckBox.ShowDialog();
        }
    }
}
