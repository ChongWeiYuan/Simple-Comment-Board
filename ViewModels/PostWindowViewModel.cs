using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using Livet;
using Livet.Commands;
using Livet.Messaging;
using Livet.Messaging.IO;
using Livet.EventListeners;
using Livet.Messaging.Windows;

using CommentBoardRefine.Models;

namespace CommentBoardRefine.ViewModels
{
    public class PostWindowViewModel : ViewModel
    {
        public void Initialize()
        {
            TextEndDate = DateTime.Now.AddMonths(1).ToString();
        }


        public MainWindowViewModel ParentViewModel;

        public string Username { get; set; }

        private string _InsertText;
        public string InsertText
        {
            get { return _InsertText; }
            set {
                    _InsertText = value;
                    RaisePropertyChanged("InsertText");
                }                
        }


        private string _TextEndDate;
        public string TextEndDate
        {
            get { return _TextEndDate; }

            set
            {
                _TextEndDate = value;
                RaisePropertyChanged("TextEndDate");
            }
        }


        private string _EndDate;
        public string EndDate
        {
            get { return _EndDate; }

            set { _EndDate = value; 
            RaisePropertyChanged("EndDate");
            }
        }
        
        #region Submitボタン
        private ViewModelCommand _Submit;
        public ViewModelCommand SubmitCommand
        {
            get
            {
                if (_Submit == null)
                {
                    _Submit = new ViewModelCommand(Submit);
                }

                return _Submit;
            }

        }
        public void Submit()
        {
            SubmitModel.Insert(InsertText,EndDate);

            //呼び出し元VMでリロード実行
            ParentViewModel.Reload();            
        }

        #endregion

    }
}
