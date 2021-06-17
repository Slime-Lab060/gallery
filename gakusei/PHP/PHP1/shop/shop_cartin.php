<?php

session_start();
session_regenerate_id(true);
if (!isset($_SESSION['menber_login'])) {
    print 'ようこそゲスト様<br />';
    print '<a href="member_login.html">会員ログイン</a><br />';
    print '<br />';
} else {

    print 'ようこそ';
    print $_SESSION['menber_name'];
    print '様';
    print '<a href="menber_logout.php">ログアウト</a><br />';
}

?>
<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>ろくまる農園</title>
    </head>
    <body>
<?php

try {
    $pro_code = $_GET['procode'];

    if (isset($_SESSION['cart'])) {

        $cart = $_SESSION['cart'];
        $kazu = $_SESSION['kazu'];
        if (in_array($pro_code, $cart)) {
            print 'その商品はすでにカートに入っています。<br />';
            print '<a href="shop_list.php">商品一覧に戻る</a>';
            exit();
        }
    }

    $cart[] = $pro_code;
    $kazu[] = 1;
    $_SESSION['cart'] = $cart;
    $_SESSION['kazu'] = $kazu;

} catch (Exception $e) {
    print 'ただいま障害により大変ご迷惑おかけしております。';
    exit();
}

?>
カートに追加しました。<br /><br />
<a href="shop_list.php">商品一覧に戻る</a>
    </body>
</html>
