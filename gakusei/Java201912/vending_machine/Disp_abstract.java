package vending_machine;

import java.io.IOException;

public abstract class Disp_abstract {
     int n = 0 , p = 0;
     String[] str = new String[10];
	 /*画面表示用*/
	 final String [][] disp = {
		  {"|0:Ｏｈ！！お茶","        ￥120|"},{"|1:美ネラルウォーター","  ￥100|"},
		  {"|2:ココアスパークリング","￥130|"},{"|3:紅茶伝説","            ￥130|"},
		  {"|4:コーヒー＋＋","        ￥150|"},{"|5:コーヒー＃","          ￥200|"}};

	 /*レシート用*/
	 final String []out = {
			  "Ｏｈ！！お茶 ￥120","美ネラルウォーター ￥100",
			  "ココアスパークリング ￥130","紅茶伝説 ￥130",
			  "コーヒー＋＋ ￥150","コーヒー＃ ￥200"};

	  abstract void machine();
      abstract void keikoku(boolean flg);
      abstract String display(int num,boolean flg);
      abstract void recipt(String[] str,int otsuri,int sum)throws IOException;

}