package vending_machine;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.text.SimpleDateFormat;
import java.util.Date;

public class Disp_clac extends Disp_abstract{

	@Override
	void machine() {
		/*商品名を表示する場所*/

	     for(String[] a : disp) {
	    	  System.out.printf("%s %s\n",a[0],a[1]);
	       }

	     /*下記の書き方が今までの2次元配列for文のやり方
	        上記の書き方がfor拡張で書いたやり方のほうが圧倒的にコードが短い!!
	    */
		/*for(int i = 0;i< disp.length;i++) {
			for(int j = 0; j < 2;j++) {
				System.out.print(disp[i][j]);
			}
            System.out.println();
		}*/
	}

	@Override
	String display(int num, boolean flg){
	  if(flg == true) {
         int i = num;
         int j = 0;
	     System.out.printf("%s: お買い上げ!\n",disp[i][j]);
	     str[n] =  out[i];
	  }
	return str[n];
	}


	@Override
	void keikoku(boolean flg) {
        if(flg == true) {
        	System.out.println("▲上限額が越えたので商品画面移りました。▼");
        }
	}

	@Override
	void recipt(String[] str,int otsuri,int sum)throws IOException{
		  try{
			  /*ここでユーザ名取得*/
			  String name = System.getProperty("user.home");
			  String name2 = "\\Desktop\\receipt.txt";
			  String user = name + name2;
			  Date d = new Date();
			  SimpleDateFormat fo = new SimpleDateFormat("yyyy年MM月dd日(E)  HH時mm分");
			  String date = fo.format(d);
			  //System.out.println(user);
		      boolean flg = true;
		      File file = new File(user);

		     while(flg == true){
		      if (checkBeforeWritefile(file)){
		        PrintWriter pw = new PrintWriter(new BufferedWriter(new FileWriter(file)));

		        pw.printf("***/自動販売機シミュレーター/***\n");
		        pw.println("KCSXXX情報専門4Fの自動販売機");
		        pw.println(date);
		        pw.println("【領収書】");
		        for(String a : str){
			    pw.printf("%s \n",a);
			    //System.out.println("内容>" + a);
		        }
		        pw.println("------------------------------");
		        pw.println("小計:￥" + sum);
		        pw.println("お釣り:￥" + otsuri);
		        pw.println("買上");
		        pw.println("------------------------------");
		        pw.println("||| | ||| || |||||| ||| |||||||");

		        pw.close();
		        System.out.println("レシート発行しました。");
		        System.out.println("ご利用ありがとうございました。");
		        flg = false;
		      }else{
		        file.createNewFile();
		        System.out.println("ファイルが存在しないため新規作成します");
		      }
		     }
		   }catch(IOException e){
		      System.out.println(e);
		    }
		  }

		  private static boolean checkBeforeWritefile(File file){
		    if (file.exists()){//ファイルが存在するか
		      if (file.isFile() && file.canWrite()){
		        return true;
		      }
		    }

		    return false;
		  }
}