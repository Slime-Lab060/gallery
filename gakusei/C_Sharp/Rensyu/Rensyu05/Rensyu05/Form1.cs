using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rensyu05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKei_Click(object sender, EventArgs e)
        {
            int n;
            int i=1;
            int a = 1;

            if (int.TryParse(txtAtai.Text, out n) == true){

                while (n >= i)
                {
                    a *=  i;
                    i++;
                }
                lblAns.Text = a.ToString();
            }
            else
            {
                MessageBox.Show("数字を入力してください");
            }
            /*
            int Factorial(int n)
            {
                if (n == 0)
                    return 1;
                return n * Factorial(n - 1);
            }
            */
        }
    }
}
