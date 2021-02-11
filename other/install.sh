#!/bin/bash
read -n1 -p "インストール開始してもよろしいですか? (y/N): " yn
if [[ $yn = [yY] ]]; then

  echo "インストールを開始します。"
  curl -fLo ~/.vimrc https://raw.githubusercontent.com/Slime-Lab060/Gakusei_Management/master/other/.vimrc
  yes | sudo add-apt-repository ppa:jonathonf/vim
  yes | sudo apt update
  yes | sudo apt upgrade
  yes | sudo apt install vim python3 python3-pip cmdtest nodejs git neofetch default-jdk
  yes | sudo pip3 install pynvim
  vim

else

  echo "キャンセルしました。"

fi
