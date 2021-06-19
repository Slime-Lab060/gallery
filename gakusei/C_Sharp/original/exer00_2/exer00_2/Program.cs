using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer00_2
{
    class Program
    {
        /**
         * Mainメソッド
         * システムが起動して最初に動作する。
         */
        static void Main(string[] args)
        {
            //現在日時を取得
            System.DateTime datenow = DateTime.Now;

            //コンソールに年月書き込み
            System.Console.Write("{0}年 {1}月\n",datenow.Year, datenow.Month);

            //DispCalenderメソッド引数を渡すときは(型, 引数名)
            //現在の年月の1日(例2020/7/1)
            DateTime dateFirst = DateTime.Parse(string.Format
                ("{0}/{1}/1",datenow.Year,datenow.Month));

            //DispCalendeメソッド呼び出し&引数を渡す
            DispCalender(dateFirst);

            //ユーザから入力待機
            System.Console.ReadLine();
        }



        /**
         * カレンダー部分を作成&表示
         */
        static void DispCalender(DateTime dateFirst)
        {
            //変数の宣言
            int week;

            //monthの月を取得
            //2020/07/01 = 「7」がmonthに入る
            //11月ならmonthに「11」が入る
            int month = dateFirst.Month;

            //曜日を表示
            Console.Write("--------------------\n");
            Console.Write("日 月 火 水 木 金 土\n");

            /*日の開始位置まで空白で埋める
             *dateFirst=「2020/07/01」.DayOfWeek=「水曜日」を整数型に変換すると
             *「3」が返ってくる*/
            for (week = 0;week < (int)dateFirst.DayOfWeek ;week++)
            {
                Console.Write("   ");
            }

            //月の終わりの日まで1週間ごとに日にちを表示する
            //whileの条件式はmonth =「7」と dateFirst.Month =「7」が同じか
            while (month == dateFirst.Month)
            {
                //weekが7とmonth「7」== dateFirst.Month=「7」なるまで
                for (; week<7 && month == dateFirst.Month;week++)
                {
                    //第1パラメータ 0「表示したいものを入れる」
                    //第2パラメータ 2「表示する文字数[2]の場合は[2桁]表示する」
                    //dateFirst.Day =「1」～「3*」までコンソール出力
                    Console.Write("{0,2} ",dateFirst.Day);

                    dateFirst = dateFirst.AddDays(1);//翌日にする
                }
                Console.Write("\n");
                week = 0;//週をリセット(日曜日からスタート)
            }
        }
    }
}
