package exer05;

/**
 * 顧客データクラス<br>
 * テキストボックスから入力された値を格納&<br>
 * データベースから取得したデータ格納するためのクラスです。
 *
 * @see GakuseiList
 */
public class CustomerData {

	private String classnum; // クラス番号
	private String name;	 // 氏名
	private String phone; 	 // 携帯電話
	private String hobby;	 // 趣味


	public CustomerData(){
		classnum = "";
		name = "";
		phone = "";
		hobby = "";

	}

	/**
	 * クラス番号セット
	 * */
	public void setClassNumber(String classnum){
		this.classnum = classnum;
	}

	/**
	 * クラス番号取得
	 * */
	public String getClassNumber() {
		return classnum;
	}


	/**
	 * 氏名セット
	 * */
	public void setName(String name) {
		this.name = name;
	}

	/**
	 * 氏名取得
	 * */
	public String getName() {
		return name;
	}


	/**
	 * 電話番号セット
	 * */
	public void setPhone(String phone) {
		this.phone = phone;
	}

	/**
	 * 電話番号取得
	 * */
	public String getPhone() {
		return phone;
	}


	/**
	 * 趣味セット
	 * */
	public void setHobby(String hobby) {
		this.hobby = hobby;
	}

	/**
	 * 趣味取得
	 * */
	public String getHobby() {
		return hobby;
	}
}
