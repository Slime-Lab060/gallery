package pac;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import pac.dao.UserDAO;
import pac.exception.DatabaseException;
import pac.exception.MysqlException;
import pac.exception.SystemException;

@WebServlet("/UserListServlet")
public class UserListServlet extends HttpServlet {
	
	private UserListInfo Userlistinfo;

	protected void doGet	(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		
		UserDAO dao = new UserDAO();
		try {
			
			Userlistinfo = dao.getUser();
			HttpSession session = request.getSession();
			session.setAttribute("info", Userlistinfo);
			getServletContext().getRequestDispatcher("/UserListServlet.jsp").forward(request, response);
			
		} catch (DatabaseException | SystemException e) {
			e.printStackTrace();
			HttpSession session = request.getSession();
		      session.setAttribute("Except", e);
		      getServletContext().getRequestDispatcher("/error.jsp").forward(request, response);
		}
	}
	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) 
			throws ServletException, IOException {

		String UserID="NaN";
		String Password="NaN";
		String Role="NaN";

		//リクエストを取得
		UserID = request.getParameter("useridname");
		Password= request.getParameter("password");
		Role = request.getParameter("users");

		UserList data  = new UserList();
		UserDAO dao = new UserDAO();

		//値をセット
		data.setuserid(UserID);
		data.setpassword(Password);
		data.setrole(Role);

		try {
			//データ件数&データ取得
			dao.addUser(data);
			Userlistinfo = dao.getUser();

			//結果をjspファイルにフォワードで送信する
			HttpSession session = request.getSession();
			System.out.println("USERLIST_REQUEST: " + session.getId());
			//session.setAttribute("ret", ret);
			session.setAttribute("info", Userlistinfo);
			getServletContext().getRequestDispatcher("/UserListServlet.jsp").forward(request, response);
			
		}catch (DatabaseException | SystemException e) {
			e.printStackTrace();
			HttpSession session = request.getSession();
			session.setAttribute("Except", e);
			getServletContext().getRequestDispatcher("/error.jsp").forward(request, response);
			
		} catch (MysqlException e) {
			e.printStackTrace();
			HttpSession session = request.getSession();
			session.setAttribute("Except", e);
			getServletContext().getRequestDispatcher("/error.jsp").forward(request, response);
		}
	}
}
