using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rensyu16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stopwatch Stopwatch = new Stopwatch();
        private void btnStart_Click(object sender, EventArgs e)
        {
            Stopwatch.Start();
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stopwatch.Stop();
            timer1.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisp.Text = "";
            Stopwatch.Reset();
            timer1.Enabled = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDisp.Text = (Stopwatch.Elapsed).ToString(@"ss");
        }

    }
}
