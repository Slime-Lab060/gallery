package vending_machine;

import java.util.Scanner;

public class Coin {

	public static void main(String[] args) {
		/*条件50円10枚 10円20枚でその金額でお釣りが返せない場合
		 * エラーと表示し商品を変えないようにする。*/
        int [] coin = {50,10};
        int [] count = {0,0};
        @SuppressWarnings("unused")
		int total = 0;
		Scanner sc = new Scanner(System.in);
        System.out.println("金額を入力してお釣りの計算と枚数表示するプログラムサンプル");
		System.out.print("金額入力>");
	    int test = sc.nextInt();
        for(int i = 0; i < coin.length;i++) {
           count[i] = test / coin[i];
           test %= coin[i];
           //total += count[i];
           if(0 < count[i]) {
        	   System.out.printf("%6d円:%4d枚\n", coin[i], count[i]);
           }
        }
        //System.out.printf("%3d枚",total);
        sc.close();
	}

}