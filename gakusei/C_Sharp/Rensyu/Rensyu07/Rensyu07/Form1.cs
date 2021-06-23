using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rensyu07
{
    public partial class Form1 : Form
    {
        int su1=0, su2=0,ans;
        public Form1()
        {
            InitializeComponent();
        }

        private void optTasu_Checked(object sender, EventArgs e)
        {
            if (optTasu.Checked == true)
            {
                su1 = 0; su2 = 0;
                int.TryParse(txtNum1.Text, out su1);
                int.TryParse(txtNum2.Text, out su2);
                lblKigo.Text = "＋";
                ans = su1 + su2;
                txtAns.Text = ans.ToString();
            }
        }

        private void optHiku_Checked(object sender, EventArgs e)
        {
            if (optHiku.Checked == true)
            {
                su1 = 0; su2 = 0;
                int.TryParse(txtNum1.Text, out su1);
                int.TryParse(txtNum2.Text, out su2);
                lblKigo.Text = "－";
                ans = su1 - su2;
                txtAns.Text = ans.ToString();
            }
        }

        private void optKakeru_Checked(object sender, EventArgs e)
        {
            if (optKakeru.Checked == true)
            {
                su1 = 0; su2 = 0;
                int.TryParse(txtNum1.Text, out su1);
                int.TryParse(txtNum2.Text, out su2);
                lblKigo.Text = "×";
                ans = su1 * su2;
                txtAns.Text = ans.ToString();
            }
        }

        private void optWaru_Checked(object sender, EventArgs e)
        {
            if (optWaru.Checked == true)
            {
                su1 = 0; su2 = 0;
                int.TryParse(txtNum1.Text, out su1);
                int.TryParse(txtNum2.Text, out su2);
                lblKigo.Text = "÷";
                if (su1 == 0 || su2 == 0)
                {
                    MessageBox.Show("0除算はできません");
                    txtAns.Text=("infinity");
                }
                else
                {
                    ans = su1 / su2;
                    txtAns.Text = ans.ToString();
                }
            }
        }
    }
}
