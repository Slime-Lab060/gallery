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
<link rel="stylesheet" type="text/css" href="css/main.css">
<script type="text/javascript" src="js/fontkit.js"></script>
<meta name="viewport" content="width=device-width, initial-scale=1">
</head>
<body>
	<div class="login-content">
		<form action="UserPersonServlet" method="post" class="box">

			<!-- <h1>つぶやきアプリ</h1> -->
			<h2>ユーザ情報変更</h2>
			<!--  ユーザID:<%--<%= request.getParameter("userid") %>  --%>
			<input type="password" name="password" placeholder="パスワード" maxlength="8" required>
			-->
			<input type="hidden" name="useridname" value="<%=request.getParameter("userid")%>">
			<div class="input-div one">
				<div class="i">
					<i class="fas fa-user"></i>
				</div>
				<div class="div">
					<h5>
						<%=request.getParameter("userid")%>
					</h5>
				</div>
			</div>

			<div class="input-div pass">
				<div class="i">
					<i class="fas fa-lock"></i>
				</div>
				<div class="div">
					<h5>パスワード</h5>
					<input type="password" class="input" name="password" maxlength="8"
						required>
				</div>
			</div>


			<!--
			ロール: <input type="radio" name="users" value="users" checked>users
 			<input type="radio" name="users" value="admins">admins<br>
 			-->
			<div style="margin-top: 10px;">
				<label class="radio"> <input type="radio" name="users"
					value="users" checked> <span class="checkmark">users</span>
				</label> <label class="radio"> <input type="radio" name="users"
					value="admins"> <span class="checkmark">admins</span>
				</label>
			</div>

			<input type="submit" value="変更" class="btn">
			<!--  <input type="reset" value="リセット">-->
			<input type="button" onclick="history.back()" value="戻る" class="btn">

		</form>
	</div>
	<script type="text/javascript" src="js/main.js"></script>
		<div class="wrapper">
			<i class="fa fa-copyright" aria-hidden="true">2020 Slime Lab</i>
		</div>
</body>
</html>