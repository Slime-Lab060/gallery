#!/bin/bash
read -n1 -p "アンインストール開始してもよろしいですか? (y/N): " yn
if [[ $yn = [yY] ]]; then

  echo "アンインストールを開始します。"
  rm -f .vimrc
  echo "アンインストール完了しました。"

else

  echo "キャンセルしました。"

fi
