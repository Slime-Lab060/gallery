using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rensyu13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] array = new int[7];
        int temp;

        private void データ入力開始ICtrlIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMae0.Enabled = true;
            txtMae1.Enabled = true;
            txtMae2.Enabled = true;
            txtMae3.Enabled = true;
            txtMae4.Enabled = true;
            txtMae5.Enabled = true;
            txtMae6.Enabled = true;
            データ入力終了ECtrlEToolStripMenuItem.Enabled = true;
        }

        private void データ入力終了ECtrlEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMae0.Enabled = false;
            txtMae1.Enabled = false;
            txtMae2.Enabled = false;
            txtMae3.Enabled = false;
            txtMae4.Enabled = false;
            txtMae5.Enabled = false;
            txtMae6.Enabled = false;
            データ入力終了ECtrlEToolStripMenuItem.Enabled = false;

        }

        private void 昇順ACtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            array[0] = int.Parse(txtMae0.Text);
            array[1] = int.Parse(txtMae1.Text);
            array[2] = int.Parse(txtMae2.Text);
            array[3] = int.Parse(txtMae3.Text);
            array[4] = int.Parse(txtMae4.Text);
            array[5] = int.Parse(txtMae5.Text);
            array[6] = int.Parse(txtMae6.Text);

            /*隣接交換法*/
            for (int i =0;i<array.Length-1 ; i++)
            {
               for(int j =array.Length-1;j > i ; j--)
                {
                    if (array[j-1] > array[j])
                    {
                        temp = array[j-1];
                        array[j-1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            txtAto0.Text = array[0].ToString();
            txtAto1.Text = array[1].ToString();
            txtAto2.Text = array[2].ToString();
            txtAto3.Text = array[3].ToString();
            txtAto4.Text = array[4].ToString();
            txtAto5.Text = array[5].ToString();
            txtAto6.Text = array[6].ToString();
        }

        private void 降順DCtrlDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            array[0] = int.Parse(txtMae0.Text);
            array[1] = int.Parse(txtMae1.Text);
            array[2] = int.Parse(txtMae2.Text);
            array[3] = int.Parse(txtMae3.Text);
            array[4] = int.Parse(txtMae4.Text);
            array[5] = int.Parse(txtMae5.Text);
            array[6] = int.Parse(txtMae6.Text);

            /*隣接交換法*/
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[j - 1] < array[j])
                    {
                        temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            txtAto0.Text = array[0].ToString();
            txtAto1.Text = array[1].ToString();
            txtAto2.Text = array[2].ToString();
            txtAto3.Text = array[3].ToString();
            txtAto4.Text = array[4].ToString();
            txtAto5.Text = array[5].ToString();
            txtAto6.Text = array[6].ToString();
        }
    }
}
