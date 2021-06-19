using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*
         * 「日付取得」ボタンのクリックイベント処理
         */
        private void button1_Click_1(object sender, EventArgs e)
        {
            //DateTimeクラスのNow現在日時を取得
            DateTime wow = NewMethod();
            dateLBl.Text = string.Format("現在の時刻は\n{0}\n {1}",
            wow.ToLongDateString(), wow.ToShortTimeString());
        }

        private static DateTime NewMethod()
        {
            return DateTime.Now;
        }

        private void dateLBl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello :)");
        }
    }
}
