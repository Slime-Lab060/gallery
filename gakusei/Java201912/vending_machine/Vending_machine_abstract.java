package vending_machine;
/*Abstarctで宣伝 主に計算メソッド
 * その他補助機能搭載*/
/*お釣りの上限  50円10枚, 10円20枚
 * ただしお釣りの返却が例:50円が11枚と表示された場合
 * 今のところ仕様です。
 * ↑修正しました。*/
public abstract class Vending_machine_abstract{
  boolean flgs = false;
  final int[] coin = {50,10};
  int[] cnt = {0,0};
  int[] cnts = {110,200};
  int fishing;
  int fishings;

   abstract int otsuri(int num, int sum);
   abstract void otsurinum(int sum);
   abstract boolean hantei(boolean flg);
   abstract boolean hantei(boolean flg, int n);

}