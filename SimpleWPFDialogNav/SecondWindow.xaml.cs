using System;
using System.Windows;
using SimpleWPFDialogNav.Infrastructure;
using SimpleWPFDialogNav.ViewModels;

namespace SimpleWPFDialogNav
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    [DataContext(typeof(SecondWindowVM))]
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();                        
        }
        
        private void OkClick(object sender, RoutedEventArgs e)
        {
            //for modal windows
            //DialogResult = true;
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            //for modal windows
            //DialogResult = false;
        }
    }
}
