#!/bin/bash
read -p "プロキシー設定 http://は除く >" proxy

#入力した文字が空ではないとipv4アドレス正規表現になっているかの確認(ポート番号)
if [[ -n $proxy ]] && [[ $proxy =~ ^[0-9]+\.[0-9]+\.[0-9]+\.[0-9]+\:[0-9]+$ ]]; then

	read -n1 -p "$proxy でよろしいですか?(y/N)" yn
	    if [[ $yn = [yY] ]]; then
			printf "\nプロキシーを環境変数に設定します...\n"
			proxys="http://"
			proxys+="$proxy"
			yes | sudo sh -c "echo 'export http_proxy=$proxys' > /etc/profile.d/proxy.sh"
			yes | sudo sh -c "echo 'export https_proxy=$proxys' >> /etc/profile.d/proxy.sh"
			yes | sudo sh -c "echo 'export ftp_proxy=$proxys' >> /etc/profile.d/proxy.sh"
			yes | sudo sh -c "echo 'export HTTP_PROXY=$proxys' >> /etc/profile.d/proxy.sh"
			yes | sudo sh -c "echo 'export HTTPS_PROXY=$proxys' >> /etc/profile.d/proxy.sh"
			yes | sudo sh -c "echo 'export FTP_PROXY=$proxys' >> /etc/profile.d/proxy.sh"
			yes | sudo sh -c "echo 'export no_proxy=\"localhost,127.0.0.1\"' >> /etc/profile.d/proxy.sh"
			read -n1 -p "sudoにプロキシを適応しますか?(この操作は初回だけ実行してください！)(y/N)" yn
			if [[ $yn = [yY] ]]; then
			     yes | sudo sh -c "echo 'Defaults env_keep=\"http_proxy\"' >> /etc/sudoers"
			     yes | sudo sh -c "echo 'Defaults env_keep+=\"https_proxy\"' >> /etc/sudoers"
			    printf "\n設定が完了しました。\n設定を反映するには一度ログアウトしてください。\n"
			else
				printf "sudoの設定はキャンセルしました。"
				printf "\n設定が完了しました。\n設定を反映するには一度ログアウトしてください。\n"
			fi

	    else
		     printf "\nキャンセルしました \n"
	    fi

    else

	echo "値が空です。"
fi