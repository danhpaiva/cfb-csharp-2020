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
    public partial class F_MonthCalendar : Form
    {
        public F_MonthCalendar()
        {
            InitializeComponent();
        }

        private void Btn_pegarData_Click(object sender, EventArgs e)
        {
            tb_dataAtual.Text = mc_calendario.TodayDate.ToShortDateString();
            tb_dataInicial.Text = mc_calendario.SelectionStart.ToShortDateString();
            tb_dataFinal.Text = mc_calendario.SelectionEnd.ToShortDateString();
        }

        private void Tb_dataInicial_TextChanged(object sender, EventArgs e)
        {
            tb_dataInicial.Text = mc_calendario.SelectionStart.ToShortDateString();
        }

        private void Tb_dataFinal_TextChanged(object sender, EventArgs e)
        {
            tb_dataFinal.Text = mc_calendario.SelectionEnd.ToShortDateString();
        }

        private void Mc_calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            tb_dataAtual.Text = mc_calendario.TodayDate.ToShortDateString();
            tb_dataInicial.Text = mc_calendario.SelectionStart.ToShortDateString();
            tb_dataFinal.Text = mc_calendario.SelectionEnd.ToShortDateString();
        }
    }
}
