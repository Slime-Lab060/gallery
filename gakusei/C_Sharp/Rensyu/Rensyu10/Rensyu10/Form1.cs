using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rensyu10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstJpn.Items.Add("１月");
            lstJpn.Items.Add("２月");
            lstJpn.Items.Add("３月");
            lstJpn.Items.Add("４月");
            lstJpn.Items.Add("５月");
            lstJpn.Items.Add("６月");
            lstJpn.Items.Add("７月");
            lstJpn.Items.Add("８月");
            lstJpn.Items.Add("９月");
            lstJpn.Items.Add("１０月");
            lstJpn.Items.Add("１１月");
            lstJpn.Items.Add("１２月");
            lstEng.Items.Add("Ｊａｎｕａｒｙ");
            lstEng.Items.Add("Ｆｅｂｒｕａｒｙ");
            lstEng.Items.Add("Ｍａｒｃｈ");
            lstEng.Items.Add("Ａｐｒｉｌ");
            lstEng.Items.Add("Ｍａｙ");
            lstEng.Items.Add("Ｊｕｎｅ");
            lstEng.Items.Add("Ｊｕｌｙ");
            lstEng.Items.Add("Ａｕｇｕｓｔ");
            lstEng.Items.Add("Ｓｅｐｔｅｍｂｅｒ");
            lstEng.Items.Add("Ｏｃｔｏｂｅｒ");
            lstEng.Items.Add("Ｎｏｖｅｍｂｅｒ");
            lstEng.Items.Add("Ｄｅｃｅｍｂｅｒ");

        }

        private void btnyaku_Click(object sender, EventArgs e)
        {
            if (lstJpn.SelectedItem == null)
            {
                MessageBox.Show("選択してください。");
            }
            else
            {
                int i = 0;
                i = lstJpn.SelectedIndex;
                txtKekka.Text = lstEng.Items[i].ToString();
            }
        }
        public void data()
        {
        }

        private void lstJpn_Load(object sender, EventArgs e)
        {
        }
    }
}
