package exer05;

import java.awt.Container;
import java.awt.Font;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.nio.charset.Charset;
import java.util.ArrayList;

import javax.swing.JButton;
import javax.swing.JFileChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.filechooser.FileNameExtensionFilter;
import javax.swing.table.DefaultTableColumnModel;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableColumn;

/**
 * 全件表示用クラス<br>
 * データベースから実行されたデータの一覧を表示するクラスです。<br>
 * データの一覧表示は、JTableを使用しています。
 */
public class DisplayView extends JFrame{

	private Container cntnr;
	private JTable    table;
	private JButton	  prevBtn;
	private JButton   cuiBtn;
	private JButton   pwBtn;
	private JScrollPane pane;
	private JLabel textlbl;
	private JLabel cntlbl;
	private JFileChooser save;

	private String[] columnHeader = {"クラス番号", "氏名", "電話番号","趣味"};

	private static boolean flg = false;
	/**
	 * コンストラクタ
	 */
	public DisplayView(String title, Controller ctrl){

		super(title);

		setSize(300, 280);
		setLocationRelativeTo(null);
		setResizable(false);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setDefaultCloseOperation(JFrame.DO_NOTHING_ON_CLOSE);

		cntnr = getContentPane();
		cntnr.setLayout(null);


		/**
		 * 各部品のインスタンス生成
		 */
		table = new JTable(0,4);
		table.setAutoCreateRowSorter(true);
		table.setEnabled(false);
		table.getTableHeader().setReorderingAllowed(false);
		cntnr.add(table);

		//保存するときディレクトリの場所をデスクトップに変更
		save = new JFileChooser(System.getProperty("user.home") + "/Desktop");
		//保存するときフィルターを設定
		save.setFileFilter(new FileNameExtensionFilter("*.txt", "txt"));

		pane = new JScrollPane(table);

		prevBtn = new JButton("戻る");
		prevBtn.setFont(new Font("YU Gothic UI", Font.BOLD, 14));

		pwBtn = new JButton("保存");
		pwBtn.setFont(new Font("YU Gothic UI", Font.BOLD, 13));

		cuiBtn = new JButton("CUI");
		cuiBtn.setFont(new Font("YU Gothic UI", Font.BOLD, 16));

		textlbl = new JLabel("件数: ");
		textlbl.setFont(new Font("YU Gothic UI", Font.BOLD, 16));

		cntlbl = new JLabel();
		cntlbl.setFont(new Font("YU Gothic UI", Font.BOLD, 16));

		/**
		 * 各部品の設定
		 */
		pane.setBounds(10, 20, 270,167);
		prevBtn.setBounds(219, 200, 60, 30);
		cuiBtn.setBounds(150, 200, 60, 30);
		pwBtn.setBounds(81,200,60,30);
		textlbl.setBounds(10,190,50,50);
		cntlbl.setBounds(50,190,50,50);

		/**
		 * 各部品をコンテナに追加
		 */
		cntnr.add(pane);
		cntnr.add(prevBtn);
		cntnr.add(cuiBtn);
		cntnr.add(pwBtn);
		cntnr.add(textlbl);
		cntnr.add(cntlbl);

		/**
		 * ボタンにアクションリスナーを追加
		 */
		prevBtn.addActionListener(ctrl);
		cuiBtn.addActionListener(ctrl);
		pwBtn.addActionListener(ctrl);

		/**
		 * ボタンにアクションコマンドを定義
		 */
		prevBtn.setActionCommand("DISPLAY_PREV");
		cuiBtn.setActionCommand("CUI");
		pwBtn.setActionCommand("PW");

		//JTableカラム名前を登録
		DefaultTableColumnModel column = (DefaultTableColumnModel)table.getColumnModel();
		TableColumn column0 = column.getColumn(0);
		TableColumn column1 = column.getColumn(1);
		TableColumn column2 = column.getColumn(2);
		TableColumn column3 = column.getColumn(3);
		column0.setHeaderValue(columnHeader[0]);
		column1.setHeaderValue(columnHeader[1]);
		column2.setHeaderValue(columnHeader[2]);
		column3.setHeaderValue(columnHeader[3]);
	}

	/**
	 * データベースに登録されたデータを全部出力するメソッド
	 * @see GakuseiList#getClassnum()
	 * @see GakuseiList#getName()
	 * @see GakuseiList#getPhone()
	 * @see GakuseiList#getHobby()
	 * */
	public void getdata(ArrayList<GakuseiList> gaku) {
		int cnt = 0;
		String str = "";
		DefaultTableModel model =(DefaultTableModel)table.getModel();
		model.setRowCount(0);
		Object [] row = new Object[4];

		for(int i=0;i<gaku.size();i++) {
			row[0]=gaku.get(i).getClassnum();
			row[1]=gaku.get(i).getName();
			row[2]=gaku.get(i).getPhone();
			row[3]=gaku.get(i).getHobby();
			model.addRow(row);
			cnt++;
		}
		str = String.valueOf(cnt);//文字列型から整数型に変換
		cntlbl.setText(str);
	}

	/**
	 * コンソール出力専用
	 * */
	public void getdatacui(ArrayList<GakuseiList> gaku) {

		if(flg == true){
			JOptionPane.showMessageDialog(null, "既に出力されています", "情報",
					JOptionPane.INFORMATION_MESSAGE);
		}else{

			int option = JOptionPane.showConfirmDialog(
					null, "コンソール出力します。よろしいですか？",
					"確認", JOptionPane.OK_CANCEL_OPTION);

			if(option == JOptionPane.OK_OPTION) {
				System.out.println("***学生リスト表***");
				System.out.println("+------------+------------+-------------+----------------+");
				System.out.println("| クラス番号 |    氏名    |  電話 番号  |      趣味      |");
				System.out.println("+------------+------------+-------------+----------------+");
				for(int i=0;i<gaku.size();i++) {
					System.out.printf("| "+format(gaku.get(i).getClassnum(), 10)+" | ");
					System.out.printf(format(gaku.get(i).getName(),  10)+ " | ");
					System.out.printf(format(gaku.get(i).getPhone(), 11)+" | ");
					System.out.printf(format(gaku.get(i).getHobby(), 14)+" |\n");
				}
				System.out.println("+------------+------------+-------------+----------------+\n");
				flg = true;
				JOptionPane.showMessageDialog(null, "コンソール出力しました");
			}
		}
	}

	/**
	 * 文字ずれ修正プログラム
	 * */
	private static String format(String target, int length){
		int byteDiff = (getByteLength(target, Charset.forName("UTF-8"))-target.length())/2;
		return String.format("%-"+(length-byteDiff)+"s", target);
	}

	/**
	 * 文字数をバイトに変換
	 * 半角:1バイト
	 * 全角:3～4バイト
	 * */
	private static int getByteLength(String string, Charset charset) {
		return string.getBytes(charset).length;
	}

	/**
	 * CUI更新フラグメソッド
	 */
	static void flgchenge() {
		flg = false;
	}

	/**
	 *ファイルを作成するメソッド
	 */
	public void fileset(ArrayList<GakuseiList> gaku)throws IOException{

		boolean flg = true;
		int selected = save.showSaveDialog(this);

		if (selected == JFileChooser.APPROVE_OPTION){
			try {
				String user = save.getSelectedFile()+"";//ユーザが保存する場所設定
				File file = new File(user);//ファイルに登録

				while(flg == true){

					if (checkBeforeWritefile(file)){//ファイルが存在するのかチェック

						//ファイルに書き込み
						PrintWriter pw = new PrintWriter(new BufferedWriter(new FileWriter(file)));

						pw.println("***学生リスト表***");
						pw.println("+------------+------------+-------------+----------------+");
						pw.println("| クラス番号 |    氏名    |  電話 番号  |      趣味      |");
						pw.println("+------------+------------+-------------+----------------+");
						for(int i=0;i<gaku.size();i++) {
							pw.printf("| "+format(gaku.get(i).getClassnum(), 10)+" | ");
							pw.printf(format(gaku.get(i).getName(),  10)+ " | ");
							pw.printf(format(gaku.get(i).getPhone(), 11)+" | ");
							pw.printf(format(gaku.get(i).getHobby(), 14)+" |\n");
						}
						pw.println("+------------+------------+-------------+----------------+");
						pw.println("表示がずれる場合フォントを「ＭＳ ゴシック」に変更してください。");
						pw.close();
						flg = false;
						System.out.println("ファイルを保存しました");
						JOptionPane.showMessageDialog(null, "ファイルを保存しました");
						break;
					}else{
						//ファイルが存在しない場合は新規作成
						String newFile = save.getSelectedFile()+".txt";
						file = new File(newFile);
						file.createNewFile();
					}
				}
			} catch (IOException e) {
				e.printStackTrace();
			}finally {

			}

		}else if (selected == JFileChooser.CANCEL_OPTION){
			//キャンセル動作された場合の処理
		}else if (selected == JFileChooser.ERROR_OPTION){
			System.out.println("エラー");
		}
	}

	/**
	 * ファイルを保存するときにファイルは存在するかのチェックを行います。<br>
	 * 同様に書き込みもチェック行う。
	 * */
	private boolean checkBeforeWritefile(File file) {
		if (file.exists()){//ファイルが存在するか
			if (file.isFile() && file.canWrite()){
				return true;//存在する
			}
		}
		return false;//存在しない
	}
}