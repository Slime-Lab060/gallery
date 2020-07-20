package exer05;

import java.awt.Color;
import java.awt.Font;
import java.util.Random;

import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JProgressBar;
import javax.swing.SwingConstants;
import javax.swing.border.EmptyBorder;

/**
 * スプラッシュスクリーンを表示するだけのクラスです。<br>
 * 特に意味はありません。
 * */
public final class Splash extends JFrame {

	private JPanel contentPane;
	private static JProgressBar Bar;
	private JLabel loadlbl;
	private JLabel back;
	private JLabel version;
	private String[] image= {"image/splash160_2.png","image/splash158.png",
			"image/splasht.png","image/splasht2.png","image/splash160.png",
			"image/splash160_3.png","image/splash160_4.png"};

	/**
	 * コンストラクタ
	 */
	Splash() {
		setUndecorated(true);
		setResizable(false);
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setSize(500, 270);
		setLocationRelativeTo(null);
		contentPane = new JPanel();
		contentPane.setBackground(new Color(192, 192, 192));
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		contentPane.setLayout(null);
		setContentPane(contentPane);

		Bar = new JProgressBar();
		Bar.setBounds(12, 230, 476, 30);
		Bar.setFont(new Font("Meiryo UI", Font.BOLD, 24));
		Bar.setForeground(new Color(6, 176, 37));
		contentPane.add(Bar);

		loadlbl = new JLabel("しばらくお待ちください. . .");
		loadlbl.setBounds(133, 200, 260, 28);
		loadlbl.setForeground(new Color(255, 255, 255));
		loadlbl.setHorizontalAlignment(SwingConstants.CENTER);
		loadlbl.setFont(new Font("Meiryo UI", Font.BOLD, 20));
		loadlbl.setForeground(new Color(255, 255, 255));
		contentPane.add(loadlbl);

		version = new JLabel("Version 1.6");
		version.setForeground(new Color(255, 255, 255));
		version.setFont(new Font("Meiryo UI", Font.BOLD, 18));
		version.setBounds(12, 10, 180, 35);
		contentPane.add(version);

		back= new JLabel();
		back.setHorizontalAlignment(SwingConstants.CENTER);
		back.setBounds(0, 0, 500, 270);

		int n = new Random().nextInt(image.length);
		String i = image[n];
		back.setIcon (new ImageIcon(this.getClass().getResource(i)));

		//スプラッシュ画像特定の画像なのか
		if(i == image[1]||i == image[2]||i == image[3]){
			//一致したら画像追加
			JLabel image = new JLabel();
			image.setBounds(155, 10, 195, 195);
			image.setHorizontalAlignment(SwingConstants.CENTER);
			image.setIcon( new ImageIcon(this.getClass().getResource("image/imagew.png")));
			contentPane.add(image);
		}
		contentPane.add(back);

		//特定の画像だったら
		if(i == image[4]) {
			//文字を黒に変更する
			loadlbl.setForeground(new Color(30, 30, 30));
			version.setForeground(new Color(30, 30, 30));
		}
	}

	/**
	 * プログレスバーを更新するメソッド
	 * */
	public static void loading(){

		String[] hint = {"(・∀・)ログイン画面!!","(^▽^)ようこそ","お疲れ様です(・ω・)","よし！！"
				,"30億のデバイスで走るJava","手にしたくなるものを、手にしやすく。","丸太"};

		//格納されている配列をランダムに添え字を取得する
		int index = new Random().nextInt(hint.length);
		String result = hint[index];
		Splash frame = new Splash();

		frame.setVisible(true);
		Bar.setStringPainted(true);

		try {

			for(int x=0;x<=25;x++) {
				Splash.Bar.setValue(x*4);
				Thread.sleep(50);
				if(x == 25) {
					//ここで文字を表示を切り替える
					Bar.setString(result);
					Thread.sleep(700);
					//100%になったらリソース開放
					frame.dispose();
				}
			}
		}catch(InterruptedException e) {
			e.printStackTrace();
		}
	}
}
