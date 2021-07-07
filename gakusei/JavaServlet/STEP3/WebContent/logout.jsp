<%@ page language="java" contentType="text/html; charset=UTF-8"
  pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>つぶやきアプリ ログアウト</title>
<link rel="stylesheet" type="text/css" href="css/main.css">
</head>
<body>
<%
  session.invalidate();
%>
<div class="box">
<h1>つぶやきアプリ</h1>
<p>ログアウトしました。</p>
<input type="button" Value="ログイン画面へ" onclick="location.href='./index.html'" class="btn">
</div>
</body>
</html>
