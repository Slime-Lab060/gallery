package exer05;
/**
 * JDBCドライバ8x以前の書き方は、以下の通りです。
 * 「com.mysql.jdbc.Driver」
 * 8x以降はこの書き方は非推奨になっています。
 *
 *
 *JDBCドライバーの読み込みを行うときのパラメータ一覧↓
 *1.データベース読み込み
 *2.文字エンコード UTF8
 *3.SSL/TLS使用
 *4.タイムゾーン GMT+9:00(日本時間)
 *5.バルクインサート(大量データ投入用のinsert文みたいなもの)
 *6.ユーザ名
 *7.パスワード
 */

import java.sql.Connection;
import java.sql.DatabaseMetaData;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

import javax.swing.JOptionPane;


/**
 *データーベースアクセスクラス<br>
 *SQLコマンドの実行はここで行う
 */
public class DbConnector {

	private static  Connection con;
	private static  Statement stmt;
	private static String tablename;
	private static String[] str = new String [4];

	//SQL文定数
	private final String comma  = ",", single="'", where = " WHERE ";

	public boolean logincheck(String user,String password , String urls ,
			String table,String text,int version) {
		try {
			//取得したデータはここで代入される
			tablename = table;
			String driver ="com.mysql"+ text +".jdbc.Driver";
			String url = "jdbc:mysql://localhost:3306/" + urls +"?serverTimezone=JST";
			//JDBCドライバの読み込み
			//8x以降でドライバ読み込みは「cj」を付け加える。
			Class.forName(driver).newInstance();

			//MySQLに接続して、接続情報を取得
			con = DriverManager.getConnection(url, user,password);

			DatabaseMetaData dbmd = con.getMetaData();

			//インストールしているものとバージョンが違う場合警告を出す
			//ちなみにバージョン「5」を使用している人が「8」を選択すると「SQLException」
			//に飛ばされプログラムが終了します。
			if(dbmd.getDatabaseMajorVersion() != version) {
				JOptionPane.showMessageDialog(null,
						"インストールしているものとバージョンが異なります!\n"
								+ "動作はしますが非推奨です。", "警告",
								JOptionPane.WARNING_MESSAGE);
			}

			/*ここからSQL文実行*/
			//SQLステートメント
			stmt = con.createStatement();

			//ここでSQLのフィールド名を取得する
			String sql = "SELECT * FROM " + tablename;
			ResultSet rs = stmt.executeQuery(sql);
			ResultSetMetaData meta = rs.getMetaData();
			str[0] = meta.getColumnName(1);
			str[1] = meta.getColumnName(2);
			str[2] = meta.getColumnName(3);
			str[3] = meta.getColumnName(4);
			rs.close();

		}catch(SQLException e){
			System.out.printf(e+"\n***データベースに接続できません***\n"
					+"起動できない原因は以下の要素が考えられます\n"
					+"1.ユーザ名またはパスワードが間違っていませんか？\n"
					+"2.サービスを有効にしていますか？\n"
					+"3.ドライバーのURLの記述が間違っていませんか？\n"
					+"記述は以下の通りです\n「jdbc:mysql://localhost:3306/テーブル名」");
			JOptionPane.showMessageDialog(null, "データベースに接続できません",
					"エラー",JOptionPane.ERROR_MESSAGE);
			System.exit(1);

		} catch (InstantiationException e) {
			System.out.println(e);
			System.exit(1);

		} catch (IllegalAccessException e) {
			System.out.println(e);
			System.exit(1);

		} catch (ClassNotFoundException e) {
			System.out.printf(e+"\n起動できない原因は以下の要素が考えられます\n"
					+"1.ビルドパスを設定していますか？\n"
					+"2.またはドライバー読み込む情報が間違っていませんか？");
			JOptionPane.showMessageDialog(null, "ドライバーの読み込みができません",
					"エラー",JOptionPane.ERROR_MESSAGE);
			System.exit(1);
		}
		return true;

	}

	/**コンストラクタ*/
	public DbConnector() {}


	/**データ登録メソッド*/
	public void insertData(CustomerData data) {

		//INSERT文実行
		String sql ="INSERT INTO "+ tablename +" VALUES('" +
				data.getClassNumber()+ single + comma + single +
				data.getName()  + single + comma + single +
				data.getPhone() + single + comma + single +
				data.getHobby() + single + ")";
		try {
			//SQL実行
			stmt.executeUpdate(sql);

		}catch(SQLException e){
			JOptionPane.showMessageDialog(null, "登録できません\n"
					+ "テーブル名の指定が間違っていませんか?",
					"エラー",JOptionPane.ERROR_MESSAGE);
			try {
				stmt.close();
			} catch (SQLException ev) {
				ev.printStackTrace();
			}
			System.out.println(e);
		}
	}


	/**データ選択メソッド*/
	public CustomerData selectData(String classnum) {
		ResultSet rs;
		CustomerData data = null;

		//SELECT文
		String sql = "SELECT * FROM "+ tablename + where + str[0] +
				" = '" + classnum + single;
		try {
			//SQL実行
			System.out.println(sql);
			rs = stmt.executeQuery(sql);
			ResultSetMetaData meta = rs.getMetaData();

			//返却データの作成
			if(rs.next()) {
				data = new CustomerData();
				data.setClassNumber(rs.getString(meta.getColumnName(1)));
				data.setName(rs.getString(meta.getColumnName(2)));
				data.setPhone(rs.getString(meta.getColumnName(3)));
				data.setHobby(rs.getString(meta.getColumnName(4)));
			}
			rs.close();
		}catch(SQLException e){
			try {
				stmt.close();
			} catch (SQLException ev) {
				ev.printStackTrace();
			}
			System.out.println(e);
		}
		return data;
	}


	/**全件表示メソッド*/
	public ArrayList<GakuseiList> AllData() {
		ArrayList<GakuseiList> gakuseilist = new ArrayList<>();
		GakuseiList data;
		//SELECT文
		String sql = "SELECT * FROM " + tablename;
		try {
			//SQL実行
			ResultSet rs = stmt.executeQuery(sql);
			ResultSetMetaData meta = rs.getMetaData();
			//返却データの作成
			while(rs.next()) {
				data = new GakuseiList(
						rs.getString(meta.getColumnName(1)),
						rs.getString(meta.getColumnName(2)),
						rs.getString(meta.getColumnName(3)),
						rs.getString(meta.getColumnName(4)));
				gakuseilist.add(data);
			}
			rs.close();
		}catch(SQLException e){
			JOptionPane.showMessageDialog(null, "テーブルが見つかりません\n"
					+ "テーブル名の指定が間違っていませんか?",
					"エラー",JOptionPane.ERROR_MESSAGE);
			try {
				stmt.close();
			} catch (SQLException ev) {
				ev.printStackTrace();
			}
			System.out.println(e);

		}
		return gakuseilist;
	}


	/**データ更新メソッド*/
	public void updateData(CustomerData data) {

		//UPDATE文
		String sql = "UPDATE " + tablename + " SET "   +
				str[1]+" = '"  + data.getName()  + single + comma +
				str[2]+" = '" + data.getPhone() + single + comma +
				str[3]+" = '" + data.getHobby() + single +
				where + str[0] + " = '" + data.getClassNumber() + single;
		try {
			//SQL実行
			stmt.executeUpdate(sql);
		}catch(SQLException e){
			try {
				stmt.close();
			} catch (SQLException ev) {
				ev.printStackTrace();
			}
			System.out.println(e);
		}
	}


	/**データ削除メソッド*/
	public void deleteData(String name) {

		//DELETE文
		String sql = "DELETE FROM " + tablename + where + str[0] +" = '" + name + single;
		try {
			//SQL実行
			stmt.executeUpdate(sql);
		}catch(SQLException e){
			System.out.println(e);
		}
	}
}