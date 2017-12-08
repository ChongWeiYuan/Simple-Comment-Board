using System;
using System.Data;
using System.Data.SqlClient;


namespace CommentBoardRefine.Models
{
    class SQL
    {
        //接続文字列
        private static string SqlConnectionString =  //@"ConnectionString";


        public static DataTable GetDB(String Query)
        {
            

            //接続文字列をプロパティから収納
            var cn = new SqlConnection();
            cn.ConnectionString = SqlConnectionString;
            cn.Open(); //DBとのアクセス確保(処理後、必ずcloseする)

            //クエリ収納
            var cmd = new SqlCommand();
            cmd.Connection = cn;

            //【注意】コマンドタイプ設定はストアド等で設定は異なる
            cmd.CommandType = CommandType.Text;

            //実行クエリ文
            cmd.CommandText = Query;

            //データリーダにクエリ文収納
            SqlDataReader rd = cmd.ExecuteReader();

            //【要検証】このインスタンスはいつまで持続するのか？
            DataTable datatable = new DataTable();

            //データーテーブル型にクエリ結果を収納
            datatable.Load(rd);

            //アクセスを閉じ、データーテーブル型を返す
            cn.Close();        

            return datatable;

        }

    }
}
