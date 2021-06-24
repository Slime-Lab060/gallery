using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rensyu08
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void btnKei_Click(object sender, EventArgs e)
        {
            int ans=0;
            if (int.TryParse(txtKin.Text, out ans))
            {

                if (ans >= 10000)
                {
                    chk10000.Checked = true;
                    ans = ans % 10000;
                }
                if (ans >= 5000)
                {
                    chk5000.Checked = true;
                    ans = ans % 5000;
                }
                if (ans >= 2000)
                {
                    chk2000.Checked = true;
                    ans = ans % 2000;
                }
                if (ans >= 1000)
                {
                    chk1000.Checked = true;
                    ans = ans % 1000;
                }
                if (ans >= 500)
                {
                    chk500.Checked = true;
                    ans = ans % 500;
                }
                if (ans >= 100)
                {
                    chk100.Checked = true;
                    ans = ans % 100;
                }
                if (ans >= 50)
                {
                    chk50.Checked = true;
                    ans = ans % 50;
                }
                if (ans >= 10)
                {
                    chk10.Checked = true;
                    ans = ans % 10;
                }
                if (ans >= 5)
                {
                    chk5.Checked = true;
                    ans = ans % 5;
                }
                if (ans >= 1)
                {
                    chk1.Checked = true;
                    ans = ans % 1;
                }
            }
            else
            {
                MessageBox.Show("数字を入力してください");
                return;
            }

            txtKin.Text = ans.ToString();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtKin.Text = "";
            chk1.Checked = false;
            chk5.Checked = false;
            chk10.Checked = false;
            chk50.Checked = false;
            chk100.Checked = false;
            chk500.Checked = false;
            chk1000.Checked = false;
            chk2000.Checked = false;
            chk5000.Checked = false;
            chk10000.Checked = false;
        }
    }
}
