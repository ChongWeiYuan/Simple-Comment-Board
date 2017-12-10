# Simple-Comment-Board(WPF)
Gitによるversion管理、マークダウン記法の習熟を目的に、GitHubアカウント作成しました。  
簡単なコメントボードをMVVMで作成。  
SQLへのアクセスクラスに、接続文字列を追加すれば動作します。  
注意:Livet導入が前提のコードです。
  
利用したサーバーはSQL SERVERです  

1、.netフレームワークに「Livet」を導入し、プロジェクトを作成し、直下に、各ファイル、フォルダを上書きする。  
2、SQLサーバーに「T-SQL table」に記載されたテーブルを作成し、接続文字列を取得  
3、接続文字列をSQLアクセスクラスに配置  
  
  
ボタンレイアウトは、下記MSDNを拝借しました  
https://msdn.microsoft.com/ja-jp/library/bb613545(v=vs.110).aspx
