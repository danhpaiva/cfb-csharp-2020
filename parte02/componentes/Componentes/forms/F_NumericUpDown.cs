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
    public partial class F_NumericUpDown : Form
    {
        public F_NumericUpDown()
        {
            InitializeComponent();
        }

        private void Btn_definirValor_Click(object sender, EventArgs e)
        {
            if ((Decimal.Parse(tb_valor.Text) >= nud_numeros.Minimum) & (Decimal.Parse(tb_valor.Text) <= nud_numeros.Maximum)){
                nud_numeros.Value = Decimal.Parse(tb_valor.Text);
            }
            else
            {
                MessageBox.Show("Número deve estar entre mínimo e máximo");
                tb_valor.Focus();
            }

        }
    }
}
