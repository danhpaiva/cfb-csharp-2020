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
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void Lbl_senha_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (cb_somenteTexto.Checked)
            {
                mtb_CPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                mtb_CPF.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            string mensagem = mtb_CPF.Text;
            MessageBox.Show(mensagem);
        }
    }
}
