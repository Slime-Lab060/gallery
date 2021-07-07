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
import pac.exception.SystemException;

@WebServlet("/UserPersonServlet")
public class UserPersonServlet extends HttpServlet {

	private UserListInfo Userlistinfo;

	protected void doGet(HttpServletRequest request, HttpServletResponse response) 
			throws ServletException, IOException {
		String userid = request.getParameter("userid");
		UserDAO dao = new UserDAO();

		try {
			dao.deleteUser(userid);
			Userlistinfo = dao.getUser();

			//結果をjspファイルにフォワードで送信する
			HttpSession session = request.getSession();
			System.out.println("USERDELETE_REQUEST: " + session.getId());
			session.setAttribute("info", Userlistinfo);
			response.sendRedirect("UserListServlet");
			//getServletContext().getRequestDispatcher("/UserListServlet.jsp").forward(request, response);

		} catch (DatabaseException | SystemException |NullPointerException e) {
			e.printStackTrace();
			HttpSession session = request.getSession();
			session.setAttribute("Except", e);
			getServletContext().getRequestDispatcher("/error.jsp").forward(request, response);
			return;
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) 
			throws ServletException, IOException {

		String UserID = request.getParameter("useridname");
		String Password= request.getParameter("password");
		String Role = request.getParameter("users");

		UserDAO dao = new UserDAO();
		UserList data  = new UserList();

		data.setuserid(UserID);
		data.setpassword(Password);
		data.setrole(Role);

		try {
			//データ件数&データ取得
			dao.UpdateUser(data);
			Userlistinfo = dao.getUser();

			//結果をjspファイルにフォワードで送信する
			HttpSession session = request.getSession();
			System.out.println("USERUPDATE_REQUEST: " + session.getId());
			//session.setAttribute("ret", ret);
			session.setAttribute("info", Userlistinfo);
			getServletContext().getRequestDispatcher("/UserListServlet.jsp").forward(request, response);
			
		}catch (DatabaseException | SystemException e) {
			e.printStackTrace();
			HttpSession session = request.getSession();
			session.setAttribute("Except", e);
			getServletContext().getRequestDispatcher("/error.jsp").forward(request, response);
			return;
		}
	}
}