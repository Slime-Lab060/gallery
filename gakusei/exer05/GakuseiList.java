
package exer05;
/**
 * 学生データクラス<br>
 * データベースから「SELECT」文で実行したデータを格納するクラス<br>
 *CustomerDataクラスと同じ処理があるが、違いは<br>
 *テキストボックスから入力された値を格納&データベースのデータを取得
 *専用クラスです。<br>
 *複数のデータを呼び出しているわけではないので、
 *複数のデータには対応していません。
 *
 *@see CustomerData
 * */
public class GakuseiList {
	private String classnum, name, phone, hobby;

	/**
	 * コンストラクタ
	 */
	public GakuseiList(String classnum, String name, String phone, String hobby) {
		this.classnum = classnum;
		this.name = name;
		this.phone = phone;
		this.hobby = hobby;
	}

	/*データベースから取得した値が欲しい場合ここのメソッドからもらう*/

	/**
	 * クラス番号取得
	 * @return クラス番号
	 */
	public String getClassnum() {
		return classnum;
	}

	/**
	 * 氏名取得
	 * @return 氏名
	 */
	public String getName() {
		return name;
	}

	/**
	 * 携帯電話取得
	 * @return 携帯電話番号
	 */
	public String getPhone() {
		return phone;
	}

	/**
	 * 趣味取得
	 * @return 趣味
	 */
	public String getHobby() {
		return hobby;
	}
}
