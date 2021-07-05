package vending_machine;

public class Vending_machine_Calculation extends Vending_machine_abstract {


	@Override
    int otsuri(int num, int sum){
    fishing = sum - num;//金集の計算用
    fishings = sum - num;//お釣り元データ返却用
    System.out.printf("お釣り:%d円\n", fishing);
    for(int i = 0;i < coin.length;i++) {
       	cnt[i] = fishing/coin[i];
       	cnts[i] -= cnt[i];
       	fishing %= coin[i];
       	if(0 < cnt[i]) {
           //System.out.printf("%2d円:%1d枚\n", coin[i], cnt[i]);
          //System.out.printf("|残り:%2d円:%1d枚|\n", coin[i], cnts[i]);
        }
    }
	 return fishings;
	}

	@Override
	  boolean hantei(boolean flg){
        for(int i = 0; i <cnts.length;i++) {
        	if(cnts[i] < 0) {
        		System.out.println("▲お釣りが足りないエラー▼");
        		System.out.println("この自動販売機は利用できません。");
        		flg = true;
        	}
	    }
        return flg;
	  }
	@Override
	  boolean hantei(boolean flg1, int n){
        for(int i = 0; i <cnts.length;i++){
       	  if(cnts[i] < 0) {
       	   flg1 = false;
          }
       	}
		return flg1;
	}

	@Override
	  void otsurinum(int sum) {
		for(int i = 0;i < coin.length;i++) {
          	cnt[i] = sum/coin[i];
          	cnts[i] -= cnt[i];
          	sum %= coin[i];
               if(0 < cnt[i]) {
          		System.out.printf("%2d円:%1d枚\n", coin[i], cnt[i]);
               }
	    }
	}
}