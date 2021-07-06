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

@WebServlet("/TweetPersonServlet")
public class TweetPersonServlet extends HttpServlet {

	private TweetListInfo TweetListInfo;

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

		String name = request.getParameter("name") ;
		TweetDAO dao = new TweetDAO();
		TweetList data  = new TweetList();
		data.setname(name);
		try {

			TweetListInfo = dao.getTweet(true,data);
			//結果をjspファイルにセッションフォワードで送信する
			HttpSession session = request.getSession();
			session.setAttribute("peason", TweetListInfo);
			getServletContext().getRequestDispatcher("/TweetPersonServlet.jsp").forward(request, response);
			System.out.println("ID_REQUEST: " + session.getId());
		}catch(DatabaseException | SystemException e) {
			e.printStackTrace();
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		String name = request.getParameter("name") ;
		TweetDAO dao = new TweetDAO();
		
		try {
			
			dao.DeleteTweet(name);//データベース中身削除
			TweetListInfo.deleteTweetListArray();//ArrayList中身を削除
			TweetListInfo = dao.getTweet(false,null);//再更新
			
			HttpSession session = request.getSession();
			session.setAttribute("info", TweetListInfo);
			System.out.println("ID_DELETE: " + session.getId());
			response.sendRedirect("TweetListServlet.jsp");
			//getServletContext().getRequestDispatcher("/TweetListServlet.jsp").forward(request, response);
		} catch (DatabaseException | SystemException e) {
			e.printStackTrace();
		}
	}
}
