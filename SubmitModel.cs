using System;


namespace CommentBoardRefine.Models
{
    class SubmitModel
    {
        public static void Insert(string MessageText,string EndTime)
        {          
            string InsertQuery = "INSERT INTO COMMENTBOARD(USER_NAME,MESSAGE,POSTED_DATE,END_DATE) VALUES('"
                                 + StatusModel.UserName+"','"
                                 + MessageText + "',CONVERT(DATETIME,'"
                                 +DateTime.Now + "'),CONVERT(DATETIME,'"
                                 + EndTime + "'));";
            
            SQL.GetDB(InsertQuery);

        }        
    }
}
