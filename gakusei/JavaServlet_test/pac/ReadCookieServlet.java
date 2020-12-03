package pac1;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

@WebServlet("/ReadCookieServlet")
public class ReadCookieServlet extends HttpServlet {

	String Name=null;
	int Counter=1;

	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {

		PrintWriter out = response.getWriter();
		Cookie cookie[] = request.getCookies();

		if(cookie != null) {
			for(Cookie cook : cookie) {
				if(cook.getName().equals("Myname")){
					Name = cook.getValue();
				}
			}

			Counter++;
			out.println("<H1>クッキー登録</H1>");
			out.println("<p>こんにちは、"+ Name +"さん</p>");
			out.println("<p>"+ Counter +"回目の訪問ですね</p>");

		}else{

			out.println("<H1>クッキー登録</H1>");
			out.println("<p>初めての登録ですね</p>");
			out.println("<p>My登録しましょう。</p>");
			out.println("<a href=\"cookieinfo.html\">登録</a>");
		}
	}
}