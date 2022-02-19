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
    public partial class F_PictureBox : Form
    {
        public F_PictureBox()
        {
            InitializeComponent();
        }

        private void F_PictureBox_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.Nome;
            label2.Text = Properties.Resources.LinkedIn;
            linkLabel1.Text = Properties.Resources.LinkedIn;
        }

        private void Btn_logoUm_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.image1;
        }

        private void Btn_logoDois_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.image2;
        }
    }
}
