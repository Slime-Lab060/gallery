package exer05;

import java.util.ArrayList;

/**
 * モデルクラス
 */
public class Model {

	private DbConnector db;
	private ArrayList<GakuseiList> list = null;


	/**
	 * コンストラクタ
	 */
	public Model(){

		// 顧客データクラスのインスタンス生成
		db = new DbConnector();
	}

	/**
	 * 検索した名前と一致するデータを取得
	 * @return Select文で実行した結果
	 * @see DbConnector#selectData(String)
	 */
	public CustomerData getData(String name) {

		CustomerData data = null;

		//データベースからデータを取得
		data = db.selectData(name);

		return data;
	}

	/**
	 * データを全件取得
	 * @return データベースから取得した一覧表
	 * @see DbConnector#AllData()
	 */
	public ArrayList<GakuseiList> Alldata() {
		list = null;
		list = db.AllData();
		return list;

	}

	/**
	 * データの登録
	 * 検索した名前と一致する場合は、既存のデータを更新
	 * @see DbConnector#selectData(String)
	 * @see DbConnector#insertData(CustomerData)
	 * @see DbConnector#updateData(CustomerData)
	 * @see CustomerData#setClassNumber()
	 */
	public void setData(CustomerData data) {
		//データを検索
		CustomerData data_wk = null;

		//データベースからデータを取得
		data_wk = db.selectData(data.getClassNumber());

		//データがnullなら
		if(data_wk == null) {
			//登録メソッド実行
			db.insertData(data);
			DisplayView.flgchenge();
		}else{
			//更新メソッドを実行
			db.updateData(data);
			DisplayView.flgchenge();
		}
	}

	/**
	 * データの削除
	 * 検索した名前と一致する場合は、削除
	 */
	public void deleteData(String name) {

		//データベースからデータ削除
		db.deleteData(name);
		DisplayView.flgchenge();
	}

	/**ログインメソッド*/
	public boolean Loginmodel(String username, String password, String driver, String table, String text, int version) {
    return db.logincheck(username, password, driver, table, text, version);}
}
