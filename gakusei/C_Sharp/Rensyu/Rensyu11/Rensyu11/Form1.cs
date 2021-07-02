using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rensyu11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMok_Click(object sender, EventArgs e)
        {
            cmbKisyu.Text = "";
            cmbKisyu.Items.Clear();
            String selectItem = cmbMaker.SelectedItem.ToString();
            if(selectItem == "ＳＯＮＹ")
            {
                cmbKisyu.Items.Add("ＰＣＶＪ２１Ｖ５");
                cmbKisyu.Items.Add("ＰＣＧＦＸ３３ＳＢＰ");
                cmbKisyu.Items.Add("ＰＣＧＦＸ９０ＧＫ");
            }
            else if(selectItem == "ＮＥＣ")
            {
                cmbKisyu.Items.Add("ＰＣＶＬ１００１Ａ");
                cmbKisyu.Items.Add("ＰＣＬＬ３００１Ａ");
                cmbKisyu.Items.Add("ＰＣＬＣ５００１Ｄ");
            }
            else if (selectItem == "ＦＵＪＩＴＳＵ")
            {
                cmbKisyu.Items.Add("ＦＭＶＣＥ８９０ＬＹ");
                cmbKisyu.Items.Add("ＦＭＶＭＧ８７５Ｙ");
                cmbKisyu.Items.Add("ＦＭＶＮＢ８９Ｄ");
            }
            else if (selectItem == "ＴＯＳＨＩＢＡ")
            {
                cmbKisyu.Items.Add("ＰＡＴ３４８０ＣＲＥ");
                cmbKisyu.Items.Add("ＰＡＧ３５１０ＰＭＥ");
                cmbKisyu.Items.Add("ＰＡＬ２０６０ＴＮＭＬ");
            }
            else if (selectItem == "ＩＢＭ")
            {
                cmbKisyu.Items.Add("２２５５１Ｊ７");
                cmbKisyu.Items.Add("２６５６８０Ｊ");
            }
        }

        private void btnKok_Click(object sender, EventArgs e)
        {
            String Meker = cmbMaker.SelectedItem.ToString();
            String Kisyu = cmbKisyu.SelectedItem.ToString();
            lblMaker.Text = Meker;
            lblKisyu.Text = Kisyu;
        }
    }
}
