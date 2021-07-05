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
		<%
		@SuppressWarnings("unchecked")
				ArrayList<TweetList> list = (ArrayList<TweetList>) request.getAttribute("tweet");
		%>
	<h1>つぶやきアプリ</h1>
	<h2><%=list.get(0).getname() %>さんのつぶやき</h2>
	<p>
		<input type="button" onclick="history.back()" value="戻る">
	<table border=1>
		<tr>
			<th>名前</th>
			<th>つぶやき</th>
			<th>日付</th>
		</tr>
		<tr>
		<%for (int i = 0; i < list.size(); i++) { %>
			<th><%=list.get(i).getname()%></th>
			<th><%=list.get(i).gettweet()%></th>
			<th><%=list.get(i).getdate()%></th>
		</tr>
		<% } %>
	</table>
</body>
</html>