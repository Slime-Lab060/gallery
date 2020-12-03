package pac1;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

@WebServlet("/WriteCookieServlet")
public class WriteCookieServlet extends HttpServlet {

	protected void doPost(HttpServletRequest request,HttpServletResponse response)
			throws ServletException, IOException {

		PrintWriter out = response.getWriter();
		String Myno = request.getParameter("number");
		String Myname = request.getParameter("name");
		String Mymail = request.getParameter("mail");

		out.println("<p>登録しました。</p>");
		out.println("<p>MyNo:"+ Myno +"</p>");
		out.println("<p>MyName:"+ Myname+"</p>");
		out.println("<p>MyMail:"+ Mymail +"</p>");
		out.println("<a href=\"/TestServlet/ReadCookieServlet\">戻る</a>");

		//クッキー作成&登録
		Cookie cookieNo = new Cookie("Myno", Myno);
		Cookie cookieName = new Cookie("Myname", Myname);
		Cookie cookieMail = new Cookie("Mymail", Mymail);
		cookieNo.setMaxAge(10);
		cookieName.setMaxAge(10);
		cookieMail.setMaxAge(10);
		response.addCookie(cookieNo);
		response.addCookie(cookieName);
		response.addCookie(cookieMail);
	}
}