using System;


namespace CommentBoardRefine.Models
{
 public   class Column
    {
        public int ID { get; set; }
        public string Message { get; set; }
        public string User { get; set; }
        public DateTime Posted_Date { get; set; }
        public DateTime End_Date { get; set; }
    }
}
