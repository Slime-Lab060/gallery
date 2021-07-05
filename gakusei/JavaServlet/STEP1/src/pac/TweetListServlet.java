package pac;

import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

@WebServlet("/TweetListServlet")
public class TweetListServlet extends HttpServlet {

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String Name = request.getParameter("name");
		String Tweet = request.getParameter("tweet");

		Date d = new Date();
		SimpleDateFormat f = new SimpleDateFormat("yyyy/MM/dd HH:mm:ss");
		String date = f.format(d);

		Connection conn=null;
		Statement stmt=null;
		ResultSet rs=null;

		ArrayList<TweetList> list  = new ArrayList<TweetList>();
		TweetList data ;
		try {
			//ドライバ設定
			Class.forName("com.mysql.jdbc.Driver");
			conn = DriverManager.getConnection("jdbc:mysql://localhost:3306/tweet?serverTimezone=JST","user","password");
			stmt = conn.createStatement();

			String sql = "INSERT INTO TWEET VALUES('" + Name + "','" + Tweet + "','" + date + "');";
			int su = stmt.executeUpdate(sql);
			System.out.println(su+"件追加しました。");

			rs = stmt.executeQuery("SELECT * FROM TWEET");

			//データベースから取得したデータを格納する
			while(rs.next()) {
				data = new TweetList() ;
				data.setname(rs.getString("NAME"));
				data.settweet(rs.getString("TWEET"));
				data.setdate(rs.getString("DATE"));
				list.add(data);
			}
			//結果をjspファイルにフォワードで送信する
			request.setAttribute("tweet", list);
			RequestDispatcher dispatch = request.getRequestDispatcher("TweetListServlet.jsp");
			dispatch.forward(request, response);

		}catch(SQLException | ClassNotFoundException e) {
			System.out.println(e);
		}
	}
}