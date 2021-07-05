package pac;

import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class TweetPersonServlet
 */
@WebServlet("/TweetPersonServlet")
public class TweetPersonServlet extends HttpServlet {

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String str = request.getParameter("name") ;
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

			rs = stmt.executeQuery("SELECT * FROM TWEET WHERE NAME='"+ str + "';");

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
			RequestDispatcher dispatch = request.getRequestDispatcher("TweetPersonServlet.jsp");
			dispatch.forward(request, response);
		}catch(Exception e){

		}
	}
}
