using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rensyu01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisp_Click(object sender, EventArgs e)
        {
            DateTime wow = DateTime.Now;
            txtDisp.Text = string.Format("{0}",
            wow.ToShortDateString());
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            txtDisp.Text = "";
        }
    }
}
