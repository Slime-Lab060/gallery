package exer05;

import java.awt.Container;
import java.awt.Font;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JOptionPane;
import javax.swing.JTextField;

/**
 * メニュー画面クラス<br>
 * ホームメニュー<br>
 * ここでデータの登録, 修正, 削除を行う
 */
public class MenuView extends JFrame{

	Container cntnr;
	JLabel    titleLbl;
	JButton	  registerBtn;
	JButton	  displayBtn;
	JButton	  deleteBtn;
	JButton   fixBtn;

	JLabel    nameLbl;
	JTextField nameTxt;

	JLabel    phoneLbl;
	JTextField phoneTxt;

	JLabel    hobbyLbl;
	JTextField hobbyTxt;

	JLabel classnumLbl;
	JTextField classnumTxt;

	JMenuBar menuBar;
	JMenu menu;
	JMenuItem menuitem;
	JMenuItem menuitem2;
	JMenuItem menuitem3;

	/**
	 * コンストラクタ
	 */
	public MenuView(String title, Controller ctrl){

		super(title);

		setSize(290, 300);
		setLocationRelativeTo(null);
		setResizable(false);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		cntnr = getContentPane();
		cntnr.setLayout(null);//nullの場合絶対参照になる

		/**
		 * 各部品のインスタンス生成
		 */
		menuBar = new JMenuBar();

		menu = new JMenu("メニュー");
		menu.setFont(new Font("YU Gothic UI", Font.PLAIN, 14));

		menuitem = new JMenuItem("About");
		menuitem.setFont(new Font("YU Gothic UI", Font.PLAIN, 14));

		menuitem2 = new JMenuItem("説明");
		menuitem2.setFont(new Font("YU Gothic UI", Font.PLAIN, 14));

		menuitem3 = new JMenuItem("閉じる");
		menuitem3.setFont(new Font("YU Gothic UI", Font.PLAIN, 14));

		titleLbl = new JLabel("学生管理システム");
		titleLbl.setFont(new Font("YU Gothic UI", Font.BOLD, 18));

		registerBtn = new JButton("登録");
		registerBtn.setFont(new Font("YU Gothic UI", Font.BOLD, 14));

		fixBtn = new JButton("修正");
		fixBtn.setFont(new Font("YU Gothic UI", Font.BOLD, 14));

		displayBtn = new JButton("全件表示");
		displayBtn.setFont(new Font("YU Gothic UI", Font.BOLD, 14));

		deleteBtn = new JButton("削除");
		deleteBtn.setFont(new Font("YU Gothic UI", Font.BOLD, 14));

		nameTxt = new JTextField();
		phoneTxt = new JTextField();
		hobbyTxt = new JTextField();
		classnumTxt = new JTextField();

		classnumLbl = new JLabel("クラス番号");
		classnumLbl.setFont(new Font("YU Gothic UI", Font.PLAIN, 14));

		nameLbl = new JLabel("氏名");
		nameLbl.setFont(new Font("YU Gothic UI", Font.PLAIN, 14));

		phoneLbl = new JLabel("携帯電話");
		phoneLbl.setFont(new Font("YU Gothic UI", Font.PLAIN, 14));

		hobbyLbl = new JLabel("趣味");
		hobbyLbl.setFont(new Font("YU Gothic UI", Font.PLAIN, 14));


		/**
		 * 各部品の設定
		 */
		menuBar.setBounds(0, 0, 290, 25);

		titleLbl.setBounds(20, 40, 140, 20);

		registerBtn.setBounds(20, 200, 80, 20);
		displayBtn.setBounds(159, 230, 90, 20);
		deleteBtn.setBounds(20, 230, 80, 20);
		fixBtn.setBounds(159, 200, 90, 20);

		classnumLbl.setBounds(20, 80, 80, 20);
		classnumTxt.setBounds(100, 80, 50, 20);

		nameLbl.setBounds(20, 110, 80, 20);
		nameTxt.setBounds(100, 110, 150, 20);

		phoneLbl.setBounds(20, 140, 80, 20);
		phoneTxt.setBounds(100, 140, 150, 20);

		hobbyLbl.setBounds(20, 170, 80, 20);
		hobbyTxt.setBounds(100, 170, 150, 20);


		/**
		 * 各部品をコンテナに追加
		 */
		cntnr.add(menuBar);
		menuBar.add(menu);
		menu.add(menuitem);
		menu.add(menuitem2);
		menu.add(menuitem3);

		cntnr.add(titleLbl);

		cntnr.add(registerBtn);
		cntnr.add(displayBtn);
		cntnr.add(deleteBtn);
		cntnr.add(fixBtn);

		cntnr.add(classnumTxt);
		cntnr.add(classnumLbl);

		cntnr.add(nameLbl);
		cntnr.add(nameTxt);

		cntnr.add(phoneTxt);
		cntnr.add(phoneLbl);

		cntnr.add(hobbyTxt);
		cntnr.add(hobbyLbl);

		cntnr.add(registerBtn);

		/**
		 * ボタンにアクションリスナーを追加
		 */
		registerBtn.addActionListener(ctrl);
		displayBtn.addActionListener(ctrl);
		deleteBtn.addActionListener(ctrl);
		fixBtn.addActionListener(ctrl);
		menuitem.addActionListener(ctrl);
		menuitem2.addActionListener(ctrl);
		menuitem3.addActionListener(ctrl);

		/**
		 * ボタンにアクションコマンドを定義
		 */
		registerBtn.setActionCommand("MENU_REGISTER");
		displayBtn.setActionCommand("MENU_DISPLAY");
		deleteBtn.setActionCommand("MENU_DELETE");
		fixBtn.setActionCommand("MENU_FIX");

		menuitem.setActionCommand("ABOUT");
		menuitem2.setActionCommand("EXP");
		menuitem3.setActionCommand("CANCEL");

	}

	/**
	 * クラス番号データを取得
	 * */
	public String getInputclassnum(){
		return classnumTxt.getText();
	}

	/**
	 * 入力データの取得
	 */
	public CustomerData getInputData(){
		// 顧客データクラスのインスタンス生成
		CustomerData data = new CustomerData();

		if(classnumTxt.getText().equals("")){
			JOptionPane.showMessageDialog(this, "クラス番号を入力してください");
			return null;

		}else{

			data.setClassNumber(classnumTxt.getText());
			data.setName(nameTxt.getText());
			data.setPhone(phoneTxt.getText());
			data.setHobby(hobbyTxt.getText());
		}
		return data;
	}

	/**
	 * setVisibleのオーバーライド
	 */
	public void setVisible(boolean b){
		//項目をクリアして表示
		nameTxt.setText("");
		phoneTxt.setText("");
		hobbyTxt.setText("");

		super.setVisible(b);
	}
}
