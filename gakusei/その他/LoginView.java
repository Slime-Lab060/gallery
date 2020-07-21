package exer01;

/*タイトルの呼び出しはコンストラクタ or
 * SetTitleを使用すことで呼び出すことができる
 *
 * */

import java.awt.Container;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPasswordField;
import javax.swing.JTextField;

public class LoginView extends JFrame implements ActionListener {

	//変数の宣言
	Container cntnr;
	JLabel userLbl;
	JLabel passLbl;
	JTextField userText;
	JTextField passText;
	JButton loginBtn;
	JButton cancelBtn;

	public LoginView(String title) {
		//コンストラクタの呼び出し
		super(title);

		//画面表示(左上から x,y)
		setLocation(200, 200);

		//画面サイズ(幅,高さ)
		setSize(300, 200);

		//部品を配置するコンテナの取得
		cntnr = getContentPane();
		cntnr.setLayout(null);

		//部品生成(インスタンス)
		userLbl = new JLabel("ユーザ名");
		passLbl = new JLabel("パスワード");
		userText = new JTextField();
		passText = new JPasswordField();
		loginBtn = new JButton("ログイン");
		cancelBtn = new JButton("キャンセル");

		/*部品の配置の指定(パラメータ指定↓)
		 * int x座標, int y座標, int 幅, int 高さ
		 * */
		userLbl.setBounds(20, 30, 80, 20);
		passLbl.setBounds(20, 60, 80, 20);
		userText.setBounds(100, 30, 150, 20);
		passText.setBounds(100, 60, 150, 20);
		loginBtn.setBounds(30, 100, 100, 30);
		cancelBtn.setBounds(140, 100, 100, 30);

		/*コンテナ追加*/
		cntnr.add(userLbl);
		cntnr.add(passLbl);
		cntnr.add(userText);
		cntnr.add(passText);
		cntnr.add(loginBtn);
		cntnr.add(cancelBtn);

		/*ボタンにアクションリスナーを追加*/
		loginBtn.addActionListener(this);
		cancelBtn.addActionListener(this);
	}

	public void actionPerformed(ActionEvent e) {

		/*ログインボタンが押されたのか*/
		if (e.getSource() == loginBtn) {

			/*uesrTextと"text" & passTextと"psswd"がtrueなら*/
			if (userText.getText().equals("test") &&
					passText.getText().equals("psswd")) {

				/*ダイアログ表示&終了*/
				JOptionPane.showMessageDialog(this, "ログイン成功");
				JOptionPane.showMessageDialog(this, "ハードコーティング書き方は非推奨です!!");
				System.exit(0);
			} else {
				/*ダイアログ表示*/
				JOptionPane.showMessageDialog(this, "ログイン失敗");
			}

			/*キャンセルボタンが押されたのか*/
		} else if (e.getSource() == cancelBtn) {
			System.exit(0);
		}
	}

	public static void main(String[] args) {
		/*インスタンス化*/
		LoginView loginView = new LoginView("ログイン画面");
		loginView.setVisible(true);
	}
}
