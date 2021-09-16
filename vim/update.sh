#!/bin/bash
read -n1 -p "アップデートを開始してもよろしいですか? (y/N): " yn
if [[ $yn = [yY] ]]; then

  echo "アップデートを開始します。"
  curl -fLo ~/.vimrc https://raw.githubusercontent.com/Slime-Lab060/Gakusei_Management/master/vim/.vimrc
  echo "アップデート完了しました。"

else

  echo "キャンセルしました。"

fi
