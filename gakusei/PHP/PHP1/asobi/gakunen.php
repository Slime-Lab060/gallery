<?php
$gakunen = $_POST['gakunen'];

switch ($gakunen) {

    case '1':
        $kousha = 'あなたは校舎は南校舎です。';
        $bukatsu = '部活動にはスポーツ系と文科系があります。';
        $mokuhyou = 'まずは学校に慣れましょう。';
        break;

    case '2':
        $kousha = 'あなたは校舎は西校舎です。';
        $bukatsu = '学園祭を目指して全力で取り組みましょう。';
        $mokuhyou = '今しかできないことを見つけよう。';
        break;

    case '3':
        $kousha = 'あなたは校舎は東校舎です。';
        $bukatsu = '受験に就職に忙しくなります。後輩へ譲っていきましょう。';
        $mokuhyou = '将来への道を作ろう。';
        break;

    default:
        $kousha = 'あなたは校舎は3年生と同じです。';
        $bukatsu = '部活動ありません。';
        $mokuhyou = '早く卒業しましょう。';
        break;
}

print '校舎 ' . $kousha . '<br />';
print '部活 ' . $bukatsu . '<br />';
print '目標 ' . $mokuhyou . '<br />';
