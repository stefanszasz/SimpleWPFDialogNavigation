using System;
using System.Linq;
using System.Reflection;
using System.Windows;
using SimpleWPFDialogNav.ViewModels;

namespace SimpleWPFDialogNav.Infrastructure
{
    public class ViewFactory
    {
        public static T Create<T>(params object[] vmArguments) where T : ScreenVM
        {
            foreach (var window in Assembly.GetExecutingAssembly().GetTypes().Where(x => typeof(Window).IsAssignableFrom(x)))
            {
                if (window.GetCustomAttribute<DataContextAttribute>(true) != null)
                {
                    var screenVM = (T)Activator.CreateInstance(typeof(T), vmArguments);
                    var newWindow = (Window)Activator.CreateInstance(window);
                    newWindow.DataContext = screenVM;
                    screenVM.Showed = newWindow.Show;
                    
                    screenVM.ShowedDialog = () =>
                    {
                        bool? showDialog = newWindow.ShowDialog();
                        return showDialog;
                    };

                    newWindow.Closing += (s, ea) =>
                    {
                        ea.Cancel = !screenVM.CanBeClosed();                        
                    };

                    newWindow.Closed += (sender, args) => screenVM.Closed();

                    return screenVM;
                }
            }

            throw new InvalidOperationException(string.Format("Cannot find a window that has DataContextAttribute type set to {0}", typeof(T)));
        }
    }
}