package pac;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import pac.dao.TweetDAO;
import pac.exception.DatabaseException;
import pac.exception.SystemException;
import pac.generator.Datetime;
@WebServlet("/TweetListServlet")
public class TweetListServlet extends HttpServlet {

	private TweetListInfo TweetListInfo;

	protected void doPost(HttpServletRequest request, HttpServletResponse response) 
			throws ServletException, IOException {

		//int ret = 0;
		String Name="NaN";
		String Tweet="NaN";

		//リクエストを取得
		Name = request.getParameter("name");
		Tweet = request.getParameter("tweet");

		String date = Datetime.GetTime();
		TweetList data  = new TweetList();
		TweetDAO dao = new TweetDAO();

		//値をセット
		data.setname(Name);
		data.settweet(Tweet);
		data.setdate(date);

		try {
			//データ件数&データ取得
			dao.addTweet(data);
			TweetListInfo = dao.getTweet(false,data);

			//結果をjspファイルにフォワードで送信する
			HttpSession session = request.getSession();
			System.out.println("INSERT_REQUEST: " + session.getId());
			//session.setAttribute("ret", ret);
			session.setAttribute("info", TweetListInfo);
			getServletContext().getRequestDispatcher("/TweetListServlet.jsp").forward(request, response);
			
		} catch (DatabaseException | SystemException e) {
			e.printStackTrace();
			HttpSession session = request.getSession();
		      session.setAttribute("Except", e);
		      getServletContext().getRequestDispatcher("/error.jsp").forward(request, response);
		}
	}

	protected void doGet(HttpServletRequest request, HttpServletResponse response) 
			throws ServletException, IOException {
		
		TweetDAO dao = new TweetDAO();
		try {
			
			TweetListInfo = dao.getTweet(false, null);
			HttpSession session = request.getSession();
			session.setAttribute("info", TweetListInfo);
			getServletContext().getRequestDispatcher("/TweetListServlet.jsp").forward(request, response);
			
		} catch (DatabaseException | SystemException e) {
			e.printStackTrace();
			HttpSession session = request.getSession();
		      session.setAttribute("Except", e);
		      getServletContext().getRequestDispatcher("/error.jsp").forward(request, response);
		}
	}
}
