using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rensyu12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Input_str = "";  // 入力された数字
        double Result = 0;      // 計算結果
        string Operator = null; // 押された演算子

        private void btnAc_Click(object sender, EventArgs e)
        {
            //ACが押されたらリセット値をリセットする
            txtAns.Text = "";
            Input_str = "";  
            Result = 0;      
            Operator = null; 

        }

        private void test(object sender, EventArgs e)
        {
            //0～9のボタンが押されたら値を代入する
            Button btn = (Button)sender;
            String text = btn.Text;
            Input_str += text;
            txtAns.Text = Input_str;
        }

        private void btnKigoTasu_Click_1(object sender, EventArgs e)
        {
            double num1 = Result;   // 現在の結果
            double num2;            // 入力された文字

            // 入力された文字が空欄なら、計算をスキップする
            if (Input_str != "")
            {
                // 入力した文字を数字に変換
                num2 = double.Parse(Input_str);

                // 四則計算
                if (Operator == "＋")
                    Result = num1 + num2;
                if (Operator == "－")
                    Result = num1 - num2;
                if (Operator == "×")
                    Result = num1 * num2;
                if (Operator == "÷")
                    if (num2 == 0)
                    {
                        MessageBox.Show("0で割ることはできません");
                    }
                    else
                    {
                        Result = num1 / num2;
                    }

                // 演算子を押されていなかった場合、入力されている文字をそのまま結果扱いにする
                if (Operator == null)
                    Result = num2;
            }

            // 画面に計算結果を表示する
            txtAns.Text = Result.ToString();

            // 今入力されている数字をリセットする
            Input_str = "";

            // 演算子をOperator変数に入れる
            Button btn = (Button)sender;

            String kigou = btn.Text;
            Operator = btn.Text;

            //=が押されたらリセットする
            if (Operator == "=")
                Operator = "";
        }
    }
}