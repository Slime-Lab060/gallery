package vending_machine;

import java.io.IOException;
import java.util.Scanner;


public class Vending_machine_display {
	private int num = 0,u = 0;
	private boolean flg1 = false,flg2 = true,flg3 = true;
	public String[] str = new String[10];
    /*商品選択処理
     * 今のところ cnt1&cnt2&cnt3は使っていなので今後廃止*/
	public void disp(int sum,int cnt1,int cnt2,int cnt3,boolean flg) throws IOException {
		for(int i = 0;i<str.length;i++) {
			str[i] = "";
		}
	    int no = sum;
	    @SuppressWarnings("resource")
		Scanner sc = new Scanner(System.in);
	    Vending_machine_Calculation machines = new Vending_machine_Calculation();
	    Disp_clac wow = new Disp_clac();
	    System.out.printf("\n*** 自動販売機　シミュレート ***\n");
        System.out.println("|============================|");
        System.out.println("|商品一覧                    |");
        wow.machine();
        System.out.println("|============================|");
        wow.keikoku(flg);
        System.out.println("0～5を選択してください。");
        System.out.println("投入した金額:￥" + sum);
        while(no >= 100) {
           flg1 = machines.hantei(flg1);
           if(flg1 == true) {
    	     break;
           }

     System.out.print("商品番号>=");
     num = sc.nextInt();
     switch(num){
      case 0:
          if(no >= 120){
            no = machines.otsuri(120, sum);//ここでお釣り計算
            flg3 = machines.hantei(flg2,0);//硬貨枚数確認
            str[u] = wow.display(0,flg3);//商品名表示
            u++;
            sum = no;
           }else{
    	    System.out.println("お金が足りません。");
          }
      break;

      case 1:
          if(no >= 100){
            no = machines.otsuri(100, sum);
            flg3 = machines.hantei(flg2, 1);
            str[u] = wow.display(1,flg3);
            u++;
            sum = no;
           }else{
            System.out.println("お金が足りません。");
           }
      break;

      case 2:
          if(no >= 130){
            no = machines.otsuri(130, sum);
            flg3 = machines.hantei(flg2,2);
            str[u] = wow.display(2,flg3);
            u++;
           sum = no;
          }else{
     	   System.out.println("お金が足りません。");
      }
      break;

      case 3:
          if(no >= 130){
            no = machines.otsuri(130, sum);
            flg3 = machines.hantei(flg2,3);
            str[u] = wow.display(3,flg3);
            u++;
            sum = no;
           }else {
         	 System.out.println("お金が足りません。");
           }
      break;

      case 4:
          if(no >= 150){
            no = machines.otsuri(150, sum);
            flg3 = machines.hantei(flg2,4);
            str[u] = wow.display(4,flg3);
            u++;
            sum = no;
          }else{
            System.out.println("お金が足りません。");
          }
      break;

      case 5:
          if(no >= 200){
            no = machines.otsuri(200, sum);
            flg3= machines.hantei(flg2,5);
            str[u] = wow.display(5,flg3);
            u++;
            sum = no;
          }else{
         	 System.out.println("お金が足りません。");
          }
      break;

      case 9:
      System.out.println("お釣り" + sum);
      machines.otsurinum(sum);
      no = 0;
      break;

      default:
    	  if(num!= 999){
              System.out.println("0～5を入力してください.");
    	  }
      }
     }
      System.out.println("お買い上げありがした～");
      after(sum,no);
   }

	private void after(int sum,int osturi) throws IOException{
		Disp_clac cl = new Disp_clac();
		Scanner sc = new Scanner(System.in);
	    String n = "y";
		System.out.printf("***レシート発行しますか***\n[y]で発行する\n=>");
		String y = sc.next();
		if(y.equals(n)){
		cl.recipt(str,osturi,sum);
		sc.close();
		}else {
			System.out.println("ご利用ありがとうございました。");
			sc.close();
		}
	}
}