using System;
using Livet;
using Livet.Commands;
using Livet.Messaging;
using Livet.Messaging.IO;
using Livet.EventListeners;
using Livet.Messaging.Windows;
using CommentBoardRefine.Models;
using System.Collections.ObjectModel;

namespace CommentBoardRefine.ViewModels
{    
    public class MainWindowViewModel : ViewModel
    {
        //RaisePropertyChangedイベントを通じて、ViewModelプロパティに格納されたモデルの変更情報を表示画面(View)に反映させる
        private ObservableCollection<Column> _BindingModel { get; set; }        
        public ObservableCollection<Column> BindingModel
        {
            get { return _BindingModel; }
            set { _BindingModel = value;
                RaisePropertyChanged("BindingModel");
            }
        }

        private DateTime _UpdateTime;
        public DateTime UpdateTime 
        { 
            get { return _UpdateTime; }
            set { _UpdateTime = value; RaisePropertyChanged("UpdateTime");}
        }

        public void Initialize(){　}

        public    MainWindowViewModel()
        {
            BindingModel = new BindingClass().BindModel;
            UpdateTime = DateTime.Now;            
        }


        #region Postボタン
        private ViewModelCommand _PostCommand;
        public ViewModelCommand PostCommand
        {
            get
            {
                if (_PostCommand == null)
                {
                    _PostCommand = new ViewModelCommand(Post);
                }

                return _PostCommand;
            }

        }
        public void Post()
        {
            MainWindowControlModel.CreatePostWindow(this);

        }

        #endregion

        #region Reloadボタン
        private ViewModelCommand _ReloadCommand;

        public ViewModelCommand ReloadCommand
        {
            get
            {
                if (_ReloadCommand == null)
                {
                    _ReloadCommand = new ViewModelCommand(Reload);
                }

                return _ReloadCommand;
            }

        }

        public void Reload()
        {
            BindingModel = new BindingClass().BindModel;
            UpdateTime = DateTime.Now;

        }
        #endregion
    }
}
