<?php
$mbango = $_POST['mbango'];

$hoshi['M1'] = 'かに星雲';
$hoshi['M31'] = 'アンドロメダ大星雲';
$hoshi['M42'] = 'オリオン大星雲';
$hoshi['M45'] = 'すばる';
$hoshi['M57'] = 'ドーナツ星雲';

print 'あなたが選んだ星は、';
print $hoshi[$mbango];
foreach ($hoshi as $key => $val) {
    print $key;
    print 'は ';
    print $val;
    print '<br />';
}
