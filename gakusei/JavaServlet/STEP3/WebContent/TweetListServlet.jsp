<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ page import="java.util.ArrayList"%>
<%@ page import="java.util.List"%>
<%@ page import="pac.TweetList"%>
<%@ page import="java.net.URLEncoder"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>つぶやきアプリ</title>
<link rel="stylesheet" type="text/css" href="css/tablemain.css">
<script type="text/javascript" src="js/fontkit.js"></script>
<meta name="viewport" content="width=device-width, initial-scale=1">
<jsp:useBean id="info" class="pac.TweetListInfo" scope="session" />
</head>
<body>
	<div class="comparison-table-wrap">
		<div class="comparison-table">
			<h1>つぶやきアプリ</h1>

			<%=request.getRemoteUser()%>:<a href="logout.jsp">ログアウト</a>
			<%
				if (request.isUserInRole("admins")) {
			%>
			<a href="UserListServlet">ユーザ管理</a>
			<%
				}
			%>
			<p>
				<input type="button" onclick="location.href='./tweetinput.html'"
					value="書き込み" class="btn">
			</p>
			<form action="TweetPersionServlet" method="get">
				<table border=1>
					<tbody>
						<%
							ArrayList<TweetList> list = info.getTweetListArray();
						for (int i = 0; i < list.size(); i++) {
						%>
						<tr>
							<td><span> <%=i + 1%> <a href="TweetPersonServlet?name=<%=URLEncoder.encode(list.get(i).getname(), "UTF-8")%>"><%=list.get(i).getname()%>さん</a> <%=list.get(i).getdate()%></span>
							 <span><%=list.get(i).gettweet()%></span>
							</td>
						</tr>
						<% } %>
					</tbody>
				</table>
			</form>
		</div>
	</div>
			<div class="footerlogo">
		<i class="fa fa-copyright" aria-hidden="true">2020 Slime Lab</i>
	</div>
</body>
</html>