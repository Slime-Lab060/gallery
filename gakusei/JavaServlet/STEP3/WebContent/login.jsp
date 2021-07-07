<%@ page language="java" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>

<head>
<link rel="stylesheet" type="text/css" href="css/main.css">
<script type="text/javascript" src="js/fontkit.js"></script>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<title>つぶやきアプリ ログイン</title>
</head>

<body>
	<div class="boxr">
		<div class="login-content">
			<form class="box" action="j_security_check" method="post">
				<img src="img/avatar_blue.svg">
				<h2>つぶやきアプリ</h2>
				<div class="input-div one">
					<div class="i">
						<i class="fas fa-user"></i>
					</div>
					<div class="div">
						<h5>ユーザID</h5>
						<input type="text" class="input" name="j_username" required>
					</div>
				</div>
				<div class="input-div pass">
					<div class="i">
						<i class="fas fa-lock"></i>
					</div>
					<div class="div">
						<h5>パスワード</h5>
						<input type="password" class="input" name="j_password" required>
					</div>
				</div>
				<a href="#">パスワードを忘れた場合</a> <input type="submit" class="btn"
					value="ログイン">
			</form>
		</div>
		<div class="wrapper">
			<i class="fa fa-copyright" aria-hidden="true">2020 Slime Lab</i>
		</div>
	</div>
	<script type="text/javascript" src="js/main.js"></script>
</body>

</html>