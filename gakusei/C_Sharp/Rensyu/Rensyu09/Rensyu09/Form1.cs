using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rensyu09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (optJpn.Checked && optToy.Checked)
            {
                MessageBox.Show ("正解です");
            }else if (optFra.Checked && optRen.Checked)
            {
                MessageBox.Show("正解です");
            }else if (optUsa.Checked && optGm.Checked)
            {
                MessageBox.Show("正解です");
            }else if (optIta.Checked && optFer.Checked)
            {
                MessageBox.Show("正解です");
            }
            else
            {
                MessageBox.Show("間違いです");
            }

        }
    }
}
