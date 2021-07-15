using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rensyu15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte select = 0;
        double result = 0;
        int su1 = 0, su2 = 0, su3 = 0;

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void テキストのクリアCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text1.Text = "";
            text2.Text = "";
            text3.Text = "";
            resulttext.Text = "";
        }

        private void 四角形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
            g1.Text = "四角形の面積";
            lbl1.Text = "たて:";
            lbl2.Text = "よこ";
            select = 1;
        }

        private void 三角形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
            g1.Text = "三角形の面積";
            lbl1.Text = "底辺:";
            lbl2.Text = "高さ:";
            select = 2;
        }

        private void 台形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
            g1.Text = "台形の面積";
            lbl1.Text = "上底:";
            lbl2.Text = "下底:";
            lbl3.Text = "高さ";
            select = 3;
        }

        private void ひし型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
            g1.Text = "ひし型の面積";
            lbl1.Text = "対角線:";
            select = 4;
        }

        private void 円ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
            g1.Text = "円の面積";
            lbl1.Text = "半径:";
            select = 5;
        }
        private void clear()
        {
            g1.Text = "";
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                sikaku();
            }else if(select == 2)
            {
                sikaku();
            }
            else if (select == 3)
            {
                daikei();
            }
            else if (select == 4)
            {
                hankei();
            }
            else if (select == 5)
            {
                hankei();
            }
            else { }
        }

        private void sikaku()
        {
            if (int.TryParse(text1.Text, out su1) == true && int.TryParse(text2.Text, out su2) == true)
            {
                if (select == 1)
                {
                    result = su1 * su2;
                    resulttext.Text = result.ToString();
                }
                else if (select == 2)
                {
                    result = su1 * su2 / 2;
                    resulttext.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("数字を入力してください");
                }
            }
        }

        private void daikei()
        {
            if (int.TryParse(text1.Text, out su1) == true && int.TryParse(text2.Text, out su2) == true && int.TryParse(text3.Text, out su3) == true)
            {
                if (select == 3)
                {
                    result = (su1 + su2) * su3 / 2;
                    resulttext.Text = result.ToString();
                }
            }
        }

        private void hankei()
        {

            if (int.TryParse(text1.Text, out su1) == true)
            {
                if (select == 4)
                {
                    result = (su1 * su1) / 2;
                    resulttext.Text = result.ToString();
                }
                else if (select == 5)
                {
                    result = su1 * su1 * 3.1415926;
                    resulttext.Text = result.ToString();
                }

            }
        }
    }
}
