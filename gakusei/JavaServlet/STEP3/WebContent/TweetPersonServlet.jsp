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
</head>
<body>
<div class="comparison-table-wrap">
<div class="comparison-table">
	<form action="TweetPersonServlet" method="post">
	<jsp:useBean id="peason" class="pac.TweetListInfo" scope="session" />
	<%
		ArrayList<TweetList> list = peason.getTweetListArray();
	%>
	<%
		String Name = list.get(0).getname();
	%>
	<h1>つぶやきアプリ</h1>
	<h2><%=Name%>さんのつぶやき</h2>
			<% if(request.isUserInRole("admins")) {%>
		 <input type="submit" value="削除"  class="btn" >
		 <%} %>
		<input type="button" onclick="history.back()" value="戻る" class="btn">
		<input type="hidden"name="name" value="<%=Name%>">


		<table border=1>
			<tr>
				<th>名前</th>
				<th>つぶやき</th>
				<th>日付</th>
			</tr>
			<tr>
				<%
					for (int i = 0; i < list.size(); i++) {
				%>
				<td><%=list.get(i).getname()%></td>
				<td><%=list.get(i).gettweet()%></td>
				<td><%=list.get(i).getdate()%></td>
			</tr>
			<%
				}
			%>
		</table>
	</form>
	</div>
	</div>
				<div class="footerlogo">
		<i class="fa fa-copyright" aria-hidden="true">2020 Slime Lab</i>
	</div>
</body>
</html>