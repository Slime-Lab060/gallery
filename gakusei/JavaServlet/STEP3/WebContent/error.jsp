<%@ page language="java" contentType="text/html; charset=UTF-8"
  pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>エラー</title>
	<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" type="text/css" href="css/main.css">
</head>
<body>
<div class="box">
<h1  style="color:#c80000">エラー画面</h1>
<%
  Exception e = (Exception) session.getAttribute("Except");
%>
<p style="	color "><%= e.getMessage() %></p>
<button type="button" onclick="location.href='./index.html'" class="btn">メニューへ戻る</button>
<!-- <p><a href="index.html">メニューへ戻る</a> -->
</div>
</body>
</html>
