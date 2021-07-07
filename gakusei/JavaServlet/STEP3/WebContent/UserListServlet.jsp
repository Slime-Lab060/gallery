<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ page import="java.util.ArrayList"%>
<%@ page import="java.util.List"%>
<%@ page import="pac.UserList"%>
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
	<jsp:useBean id="info" class="pac.UserListInfo" scope="session" />
	<div class="comparison-table-wrap">
		<div class="comparison-table">
			<h1>ユーザ管理</h1>
			<span><%=request.getRemoteUser()%>:</span><a href="logout.jsp">ログアウト</a>
				<a href="javascript:history.back();	">つぶやきへ戻る</a>
			<table border=1>
				<tr>
					<th>ユーザID</th>
					<th>ロール</th>
					<th colspan="2"><a href="userinput.html"><span style="color: #fefefe">ユーザ作成</span></a>
				</tr>
				<%
					ArrayList<UserList> list = info.getUserListArray();
				for (int i = 0; i < list.size(); i++) {
				%>
				<tr>
					<td><%=list.get(i).getuserid()%></td>
					<td><%=list.get(i).getrole()%></td>
					<td><a
						href="userPersonServlet?userid=<%=URLEncoder.encode(list.get(i).getuserid(), "UTF-8")%>">編集</a></td>
					<td><a
						href="UserPersonServlet?userid=<%=URLEncoder.encode(list.get(i).getuserid(), "UTF-8")%>">削除</a></td>
				</tr>
				<%
					}
				%>
			</table>
		</div>
	</div>
				<div class="footerlogo">
		<i class="fa fa-copyright" aria-hidden="true">2020 Slime Lab</i>
	</div>
</body>
</html>