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
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            ll_multiplosLinks.Links.Add(0, 6, "www.google.com/");
            ll_multiplosLinks.Links.Add(9, 6, "https://github.com/danhpaiva");
            ll_multiplosLinks.Links.Add(18, 7, "www.youtube.com");

            ll_multiplosLinks.Links[2].Enabled = false;
        }

        private void ll_Linkedin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/danhpaiva/");

            LinkLabel ll = (LinkLabel)sender;
            ll.LinkVisited = true;
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void ll_multiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }
    }
}
