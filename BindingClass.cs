using System;
using System.Collections.ObjectModel;
using System.Data;


namespace CommentBoardRefine.Models
{
  public  class BindingClass
    {
        public ObservableCollection<Column> BindModel { get; set; }

         public   BindingClass()
            {
            string InsertQuery= "SELECT COMMENT_ID, USER_NAME,MESSAGE,POSTED_DATE,END_DATE FROM COMMENTBOARD "                                                   
                          +"WHERE 1=1 "
                          +"  AND CONVERT(DATE, END_DATE) >= CONVERT(DATE, GETDATE()) "                          
                          +"ORDER BY POSTED_DATE DESC";

            DataTable GetDatatable = SQL.GetDB(InsertQuery);

            BindModel = new ObservableCollection<Column>() { };
            
            for (int i = 0; i < GetDatatable.Rows.Count; i++)
            {
                Column cl = new Column();

                cl.ID = (int)GetDatatable.Rows[i].ItemArray[0];
                cl.User = GetDatatable.Rows[i].ItemArray[1].ToString();
                cl.Message= GetDatatable.Rows[i].ItemArray[2].ToString();
                cl.Posted_Date = (DateTime)GetDatatable.Rows[i].ItemArray[3];
                cl.End_Date = (DateTime)GetDatatable.Rows[i].ItemArray[4];

                BindModel.Add(cl);
                                
            }  
        }
        
    }
}
