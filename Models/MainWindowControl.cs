
using Livet;
using CommentBoardRefine.Views;
using CommentBoardRefine.ViewModels;
using System.Windows;

namespace CommentBoardRefine.Models
{
    public class MainWindowControlModel : NotificationObject
    {
        public static void CreatePostWindow(MainWindowViewModel Parent)
        {
            var PWindow = new PostWindow();
            
            PostWindowViewModel vm = (PostWindowViewModel)PWindow.DataContext;
            vm.ParentViewModel = Parent;

            PWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            PWindow.Show();



        }

    }
}
