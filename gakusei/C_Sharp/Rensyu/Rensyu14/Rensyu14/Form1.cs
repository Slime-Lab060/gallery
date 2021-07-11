using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rensyu14
{

    public partial class Form1 : Form
    {
        int[] array = new int[9];
        int[] sarch = new int[9];
        int temp = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void 削除処理CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTbl0.Text = "";
            txtTbl1.Text = "";
            txtTbl2.Text = "";
            txtTbl3.Text = "";
            txtTbl4.Text = "";
            txtTbl5.Text = "";
            txtTbl6.Text = "";
            txtTbl7.Text = "";
            txtTbl8.Text = "";


        }

        private void テーブル入力TCtrlTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTbl0.Enabled = true;
            txtTbl1.Enabled = true;
            txtTbl2.Enabled = true;
            txtTbl3.Enabled = true;
            txtTbl4.Enabled = true;
            txtTbl5.Enabled = true;
            txtTbl6.Enabled = true;
            txtTbl7.Enabled = true;
            txtTbl8.Enabled = true;
            並列処理SCtrlSToolStripMenuItem.Enabled = true;
            検索結果SCtrlSToolStripMenuItem1.Enabled = true;
            削除処理CToolStripMenuItem.Enabled = true;
            txtNum.Enabled = false;

        }

        private void 並列結果SCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            array[0] = int.Parse(txtTbl0.Text);
            array[1] = int.Parse(txtTbl1.Text);
            array[2] = int.Parse(txtTbl2.Text);
            array[3] = int.Parse(txtTbl3.Text);
            array[4] = int.Parse(txtTbl4.Text);
            array[5] = int.Parse(txtTbl5.Text);
            array[6] = int.Parse(txtTbl6.Text);
            array[7] = int.Parse(txtTbl7.Text);
            array[8] = int.Parse(txtTbl8.Text);

            /*隣接交換法*/
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            txtTbl0.Text = array[0].ToString();
            txtTbl1.Text = array[1].ToString();
            txtTbl2.Text = array[2].ToString();
            txtTbl3.Text = array[3].ToString();
            txtTbl4.Text = array[4].ToString();
            txtTbl5.Text = array[5].ToString();
            txtTbl6.Text = array[6].ToString();
            txtTbl7.Text = array[7].ToString();
            txtTbl8.Text = array[8].ToString();
            txtTbl0.Enabled = false;
            txtTbl1.Enabled = false;
            txtTbl2.Enabled = false;
            txtTbl3.Enabled = false;
            txtTbl4.Enabled = false;
            txtTbl5.Enabled = false;
            txtTbl6.Enabled = false;
            txtTbl7.Enabled = false;
            txtTbl8.Enabled = false;
            txtNum.Enabled = false;
        }

        private void 検索入力NCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTbl0.Enabled = false;
            txtTbl1.Enabled = false;
            txtTbl2.Enabled = false;
            txtTbl3.Enabled = false;
            txtTbl4.Enabled = false;
            txtTbl5.Enabled = false;
            txtTbl6.Enabled = false;
            txtTbl7.Enabled = false;
            txtTbl8.Enabled = false;
            txtNum.Enabled = true;
        }

        private void 検索結果SCtrlSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtTbl0.BackColor = Color.White;
            txtTbl1.BackColor = Color.White;
            txtTbl2.BackColor = Color.White;
            txtTbl3.BackColor = Color.White;
            txtTbl4.BackColor = Color.White;
            txtTbl5.BackColor = Color.White;
            txtTbl6.BackColor = Color.White;
            txtTbl7.BackColor = Color.White;
            txtTbl8.BackColor = Color.White;

            int mid=0;
            int pos = -1;
            int poss = 0;
            int low = 0;
            int up = sarch.Length - 1;
            sarch[0] = int.Parse(txtTbl0.Text);
            sarch[1] = int.Parse(txtTbl1.Text);
            sarch[2] = int.Parse(txtTbl2.Text);
            sarch[3] = int.Parse(txtTbl3.Text);
            sarch[4] = int.Parse(txtTbl4.Text);
            sarch[5] = int.Parse(txtTbl5.Text);
            sarch[6] = int.Parse(txtTbl6.Text);
            sarch[7] = int.Parse(txtTbl7.Text);
            sarch[8] = int.Parse(txtTbl8.Text);
            int value = int.Parse(txtNum.Text);

            while (low <= up)
            {
                mid = (low + up) / 2;
                if (sarch[mid] == value)
                {
                    pos = sarch[mid];
                    poss = mid;
                    result(mid);
                    break;
                    
                    
                }
                else if (sarch[mid] < value)
                {
                    low = mid + 1;
                }
                else if (sarch[mid] > value)
                {
                    up = mid - 1;
                }
            }
            if (pos < 0)
            {
                System.Diagnostics.Debug.WriteLine("見つかりません");
                optNashi.Checked = true;
            }
            else
            {
            }
        }
        private void result(int pos)
        {
            //System.Diagnostics.Debug.WriteLine("見つかりました: " + pos + " " + poss);
            optAri.Checked = true;

            if (pos == 0)
                txtTbl0.BackColor = Color.Black;
            if (pos == 1)
                txtTbl1.BackColor = Color.Black;
            if (pos == 2)
                txtTbl2.BackColor = Color.Black;
            if (pos == 3)
                txtTbl3.BackColor = Color.Black;
            if (pos == 4)
                txtTbl4.BackColor = Color.Black;
            if (pos == 5)
                txtTbl5.BackColor = Color.Black;
            if (pos == 6)
                txtTbl6.BackColor = Color.Black;
            if (pos == 7)
                txtTbl7.BackColor = Color.Black;
            if (pos == 8)
                txtTbl8.BackColor = Color.Black;
        }
    }
}
