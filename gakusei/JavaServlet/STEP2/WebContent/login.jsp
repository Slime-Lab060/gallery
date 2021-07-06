<%@ page language="java"  pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<link rel="stylesheet" type="text/css" href="css/main.css">
<meta charset="UTF-8">
<title>つぶやきアプリ ログイン</title>
</head>
<body>
<form class="box" action="j_security_check" method="post">
<h1>つぶやきアプリ</h1>
  <p>ログインID<input type="text" name="j_username" placeholder="Username" required><br>
  パスワード<input type="password" name="j_password" placeholder="Password" required><br>
  <input type="submit" value="ログイン">
</form>
</body>
</html>
