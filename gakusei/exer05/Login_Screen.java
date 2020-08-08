package exer05;

import java.awt.Font;

import javax.swing.ButtonGroup;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JPasswordField;
import javax.swing.JRadioButton;
import javax.swing.JTextField;
import javax.swing.border.EmptyBorder;

/**
 * ログイン画面のクラスです
 * */
public final class Login_Screen extends JFrame {
	private JPanel contentPane;
	JRadioButton mysqlold;
    JRadioButton mysqlnew;
	private JPasswordField passwdt;
	private JTextField usernamet;
	private JTextField drivert;
	private JTextField tablet;
	private JButton loginbtn;
	private JButton cancelbtn;
	private JLabel psswdlbl;
	private JLabel passwdlbl;
	private JLabel driverdlbl;
	private JLabel tablelbl;

	private ButtonGroup bg;

	/**コンストラクタ*/
	Login_Screen(Controller ctrl,Controller key,Controller mouse) {
		setTitle("ログイン画面");
		setResizable(false);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setSize(320, 270);
		setLocationRelativeTo(null);
		getContentPane().setLayout(null);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);

		//ラジオボタン実装
		bg = new ButtonGroup();
		mysqlold = new JRadioButton("MySQL 5.X");
		mysqlold.setFont(new Font("YU Gothic UI", Font.BOLD, 11));
		mysqlnew = new JRadioButton("MySQL 8.X");
		mysqlnew.setFont(new Font("YU Gothic UI", Font.BOLD, 11));
		mysqlnew.setBounds(100, 150, 90, 20);
		mysqlold.setBounds(15, 150, 90, 20);
		contentPane.add(mysqlnew);
		contentPane.add(mysqlold);
		bg.add(mysqlnew);
		bg.add(mysqlold);
		mysqlold.setSelected(true);

		loginbtn = new JButton("ログイン");
		loginbtn.setFont(new Font("YU Gothic UI", Font.BOLD, 16));
		loginbtn.setBounds(40, 175, 110, 40);
		contentPane.add(loginbtn);

		cancelbtn = new JButton("キャンセル");
		cancelbtn.setFont(new Font("YU Gothic UI", Font.BOLD, 16));
		cancelbtn.setBounds(161, 175, 110, 40);
		contentPane.add(cancelbtn);

		passwdt = new JPasswordField();
		passwdt.setBounds(93, 57, 200, 20);
		contentPane.add(passwdt);

		usernamet = new JTextField();
		usernamet.setColumns(10);
		usernamet.setBounds(93, 24, 200, 20);
		contentPane.add(usernamet);

		drivert = new JTextField();
		drivert.setColumns(10);
		drivert.setBounds(93, 90, 200, 20);
		contentPane.add(drivert);

		tablet = new JTextField();
		tablet.setColumns(10);
		tablet.setBounds(93, 123, 200, 20);
		contentPane.add(tablet);

		psswdlbl = new JLabel("ユーザ名");
		psswdlbl.setFont(new Font("YU Gothic UI", Font.PLAIN, 14));
		psswdlbl.setBounds(12, 24, 70, 20);
		contentPane.add(psswdlbl);

		passwdlbl = new JLabel("パスワード");
		passwdlbl.setFont(new Font("YU Gothic UI", Font.PLAIN, 14));
		passwdlbl.setBounds(12, 57, 70, 20);
		contentPane.add(passwdlbl);

		driverdlbl = new JLabel("データベース名");
		driverdlbl.setFont(new Font("YU Gothic UI", Font.PLAIN, 12));
		driverdlbl.setBounds(12, 90, 70, 20);
		contentPane.add(driverdlbl);

		tablelbl = new JLabel("テーブル名");
		tablelbl.setFont(new Font("YU Gothic UI", Font.PLAIN, 14));
		tablelbl.setBounds(12, 123, 70, 20);
		contentPane.add(tablelbl);

		/**
		 * ボタンにアクションリスナーを追加
		 */
		loginbtn.addActionListener(ctrl);
		cancelbtn.addActionListener(ctrl);

		/**
		 * ボタンにアクションコマンドを定義
		 */
		loginbtn.setActionCommand("LOGIN");
		cancelbtn.setActionCommand("CANCEL");

		requestFocusInWindow(true);//フォーラムにフォーカス合わせる
		setFocusable(true);//画面にキー入力有効
		addKeyListener(key);//キーボードイベント

	}

	/**ログインボタンを押すと実行されるメソッド
	 * 入力された値をDbConnectorに値を持っていきます*/
	boolean login() {
		Model model = new Model();
		byte version=0 ;
		String text = null ;

		if(mysqlold.isSelected()) {
			//Mysql 5.Xを選択した場合
			text = "";
			version = 5;
		}else if(mysqlnew.isSelected()) {
			//Mysql 8.Xを選択した場合
			text = ".cj";
			version = 8;
		}

		//テキストボックスから値を取得
		String password = new String(passwdt.getPassword());
		String username = new String(usernamet.getText());
		String driver = new String(drivert.getText());
		String table = new String(tablet.getText());
		dispose();//リソース開放
		return model.Loginmodel(username,password ,driver,table,text,version);
	}
}
