package vending_machine;

import java.io.IOException;
import java.util.Scanner;

 public class Vending_machine_moneycount {
	private int sum = 0 ,coin = 0,
			    cnt1 = 0,cnt2 = 0,cnt3 = 0;
	private boolean flg = false;

	public void moneycnt() throws IOException {
		Vending_machine_display display = new Vending_machine_display();
		@SuppressWarnings("resource")
		Scanner sc = new Scanner(System.in);
        System.out.println("投入できる硬貨は10円、50円、100円です。");
        System.out.println("10円「1」50円「2」、100円「3」で入力してください。");
        System.out.println("投入が終わりましたら「0」を入力してください。");

        /*while分の扱いには気を付けよう！！
         * 定数使うならenumが望ましいがめんどいのと
         * やり方が忘れたので今回はやらない*/
        while(coin != 999) {
            if(sum >= 700) {
               flg = true;
          	   display.disp(sum,cnt1 ,cnt2 ,cnt3, flg);

               break;
            }else{
              System.out.print("投入硬貨=>");
              coin = sc.nextInt();
            }
          if(coin == 0) {
        	  if(sum < 100) {
        		  System.out.println("最低100円投入してください。");
        	  }else{
        	  	  display.disp(sum,cnt1 ,cnt2 ,cnt3 ,flg);

                  break;
        	  }

          }else if(coin == 1) {
        	  sum += 10;
        	  System.out.printf("合計金額>%s円\n" , sum);
        	  cnt1++;

          }else if(coin == 2) {
        	  sum += 50;
        	  System.out.printf("合計金額>%s円\n" , sum);
        	  cnt2++;

          }else if(coin == 3) {
        	  sum += 100;
        	  System.out.printf("合計金額>%s円\n" , sum);
        	  cnt3++;

          }else if(coin == 9){
        	  sum += 700;
        	  System.out.printf("合計金額>%s円\n" , sum);

          }else if(coin == 159){
        	  System.out.println("デバッグ表示");
        	  System.out.printf("投下した枚数:10円%d枚, 50円%d枚, 100円%d枚\n",cnt1 ,cnt2 ,cnt3);

          }else if(coin != 999){
        	  System.out.println("1～3を入力してください");

          }else{
        	  System.out.println("強制終了しました。");
      	      System.exit(0);
          }
       }
	}
 }