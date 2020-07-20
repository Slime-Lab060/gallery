package exer05;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.io.IOException;
import java.util.ArrayList;

import javax.swing.JOptionPane;

/**
 *
 * コントローラクラス<br>
 * 最初に実行されるクラスです。<br>
 * ボタンが押されたりしたときの制御はここで行っています。<br>
 * @version 1.6<br>
 * @author Slime Lab<br>
 */
public class Controller extends KeyAdapter implements ActionListener{

	MenuView menuView;

	DisplayView disp;

	Model model;

	Login_Screen log_sc;

	ArrayList<GakuseiList> list;
	/**
	 * mainメソッド
	 */
	public static void main(String[] args){

		// コントローラクラスをインスタンス化
		Controller ctrl = new Controller();
		// システム実行
		ctrl.run();
	}

	/**
	 * コンストラクタ
	 */
	public Controller(){

		// メニュー画面クラスをインスタンス化
		menuView = new MenuView("学生管理システム", this);

		//全件データ表示インスタンス化
		disp = new DisplayView("学生リスト表",this);

		// モデルクラスをインスタンス化
		model = new Model();

		//ログイン画面インスタンス化
		log_sc = new Login_Screen(this, this, this);
	}

	/**
	 * システム実行
	 */
	public void run(){
		//ロード画面を表示
		Splash.loading();

		//ログイン画面
		log_sc.setVisible(true);
	}

	/**
	 * アクションリスナー
	 */
	public void actionPerformed(ActionEvent event){

		// アクションコマンドを取得
		String cmd = event.getActionCommand();

		//ログインボタンイベント
		if(cmd.equals("LOGIN") == true){
			boolean flg =log_sc.login();
			if(flg == true) {
				log_sc.setVisible(false);
				menuView.setVisible(true);
			}

			//キャンセルボタンイベント
		}else if(cmd.equals("CANCEL") == true){
			System.exit(0);


			//メニュー画面の「登録」ボタンのイベント
		}else if(cmd.equals("MENU_REGISTER") == true){
			CustomerData data;//Java(テキストボックス用)
			CustomerData data_wk;//データベース内部


			//クラス番号が空白の場合「null」が返却される
			data = menuView.getInputData();

			//テキストボックスに「クラス番号」の値が空白なのかチェック
			if(data == null) {
			}else{
				// モデルからデータを検索
				data_wk = model.getData(data.getClassNumber());

				//データベースの「クラス番号」が空白なのかチェック
				if(data_wk == null){
					//空白だったら登録
					model.setData(data);
					JOptionPane.showMessageDialog(menuView, "登録しました");
				}else{
					//空白ではない場合はダイアログ表示
					JOptionPane.showMessageDialog(menuView, "既に登録されています");
				}
			}

			//メニュー画面の「削除」ボタンのイベント
		}else if(cmd.equals("MENU_DELETE") == true){
			String name = menuView.getInputclassnum();

			// モデルからデータを検索
			CustomerData data = model.getData(name);

			//データベース「クラス番号」が空白なのかチェック
			if(data == null){
				JOptionPane.showMessageDialog(menuView, "データが見つかりません");
			}else{
				//データが存在した場合、データを削除するのか最終チェック
				int res = JOptionPane.showConfirmDialog(
						menuView, "データを削除します。よろしいですか？",
						"削除確認", JOptionPane.OK_CANCEL_OPTION);

				if(res == JOptionPane.OK_OPTION) {
					// OKの場合削除
					model.deleteData(name);

					// 削除完了のメッセージを表示
					JOptionPane.showMessageDialog(menuView, "削除しました");
				}
			}

			//メニュー画面の「修正ボタン」のイベント
		}else if(cmd.equals("MENU_FIX") == true){

			//テキストボックス「クラス番号」入力された値を取得
			String name = menuView.getInputclassnum();

			//データがない場合「null」が返却される
			CustomerData check = model.getData(name);

			//テキストボックスからデータを取得
			CustomerData data = menuView.getInputData();

			//データベースにデータが存在するか
			if(check == null) {
				JOptionPane.showMessageDialog(menuView, "データが見つかりません");
			}else{
				//データが存在した場合、値を変更するか最終チェック
				int res = JOptionPane.showConfirmDialog(
						menuView, "データを更新します。よろしいですか？",
						"更新確認", JOptionPane.OK_CANCEL_OPTION);

				if(res == JOptionPane.OK_OPTION) {
					//OKの場合データを更新する
					model.setData(data);
					JOptionPane.showMessageDialog(menuView, "更新しました");
				}
			}

			//メニュー画面の「全件表示」ボタンのイベント
		}else if(cmd.equals("MENU_DISPLAY")==true) {
			menuView.setVisible(false);
			list = null;
			list = model.Alldata();//データを取得
			disp.getdata(list);//全件表示メソッド
			disp.setVisible(true);

			//「戻る」ボタンが押された動作
		}else if(cmd.equals("DISPLAY_PREV")==true) {
			disp.setVisible(false);
			menuView.setVisible(true);

			//「CUI」ボタンが押された動作
		}else if(cmd.equals("CUI")==true){
			disp.getdatacui(list);
		}else if(cmd.contentEquals("PW") == true) {
			try {
				disp.fileset(list);
			} catch (IOException e) {
				e.printStackTrace();
			}
			//メニュバーから「About」が押された時のイベント
		}else if(cmd.contentEquals("ABOUT")== true) {
			JOptionPane.showMessageDialog(menuView,"学生管理システム\n"
					+ "Version 1.6(ビルド:1.8.0_202-b08)\n"
					+ "作者:Slime Lab","About",JOptionPane.INFORMATION_MESSAGE);

			//メニュバーから「説明」が押された時のイベント
		}else if(cmd.contentEquals("EXP")== true) {
			JOptionPane.showMessageDialog(menuView,"全件表示の中に「CUI」ボタンがあります。\n"
					+ "コンソール出力をしたい場合は、コマンドプロンプトから実行してください。","説明",JOptionPane.INFORMATION_MESSAGE);
		}
	}


	/**キーが押されたときに呼び出されます。*/
	public void keyPressed(KeyEvent e) {
		int keyCode = e.getKeyCode();

		switch(keyCode) {

		case KeyEvent.VK_ENTER:
			boolean flg =log_sc.login();
			if(flg == true) {
				log_sc.setVisible(false);
				// メニュー画面を表示
				menuView.setVisible(true);
			}
			break;

		case KeyEvent.VK_ESCAPE:
			System.exit(0);
			break;

		case KeyEvent.VK_1:
			log_sc.mysqlold.setSelected(true);
			break;

		case KeyEvent.VK_2:
			log_sc.mysqlnew.setSelected(true);
			break;
		}
	}
}
