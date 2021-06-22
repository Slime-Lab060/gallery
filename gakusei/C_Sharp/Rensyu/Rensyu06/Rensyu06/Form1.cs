using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rensyu06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKei_Click(object sender, EventArgs e)
        {
            int su1, su2;
            double ans=1;
            if (int.TryParse(txtAtai.Text, out su1)== true &&
                int.TryParse(txtKaijo.Text,out su2) == true)
            {
                int i = 1;
                while (i <= su2)
                {
                    ans = ans * su1;
                    i++;
                }
                txtAns.Text = ans.ToString();
            }
            else
            {
                MessageBox.Show("数字を入力してください");
            }

        }
    }
}
