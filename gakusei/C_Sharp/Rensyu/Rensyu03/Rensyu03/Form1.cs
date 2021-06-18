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
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSu2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSu1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSu3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMax_Click(object sender, EventArgs e)
        {/*
            int su1 = int.Parse(txtSu1.Text);
            int su2 = int.Parse(txtSu2.Text);
            int su3 = int.Parse(txtSu3.Text)
          */;
            int su1, su2, su3;

            if (int.TryParse(txtSu1.Text, out su1) == true &&
            int.TryParse(txtSu2.Text, out su2) == true &&
            int.TryParse(txtSu3.Text, out su3) == true)
            {
                if (su1 >= su2)
                {
                    if (su1 >= su3)
                    {
                        txtMax.Text = su1.ToString();
                    }
                    else
                    {
                        txtMax.Text = su3.ToString();
                    }
                }
                else if (su2 >= su3)
                {
                    txtMax.Text = su2.ToString();
                }
                else
                {
                    txtMax.Text = su3.ToString();
                }
            }
            else
            {
                MessageBox.Show ("数字を入力してください。");
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMax.Text = "";
            txtSu1.Text = "";
            txtSu2.Text = "";
            txtSu3.Text = "";
        }
    }

}
