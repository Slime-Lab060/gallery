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
</head>
<body>
	<form action="TweetPersionServlet" method="get">
		<jsp:useBean id="TweetList" class="pac.TweetList" scope="session" />
		<h1>つぶやきアプリ</h1>
		<p>
			<input type="button" onclick="location.href='./tweetinput.html'" value="書き込み">
		<table border=1>
			<tr>
				<th>名前</th>
				<th>つぶやき</th>
				<th>日付</th>
			</tr>
			<%
			@SuppressWarnings("unchecked")
				ArrayList<TweetList> list = (ArrayList<TweetList>) request.getAttribute("tweet");
				for (int i = 0; i < list.size(); i++) {
					//for(TweetList tw : list){}
			%>
			<tr>
				<th><a href="TweetPersonServlet?name=<%=URLEncoder.encode(list.get(i).getname(), "UTF-8")%>"><%=list.get(i).getname()%></a></th>
				<th><%=list.get(i).gettweet()%></th>
				<th><%=list.get(i).getdate()%></th>
			</tr>
			<% } %>
		</table>
	</form>
</body>
</html>