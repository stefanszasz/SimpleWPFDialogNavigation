using System.Windows;
using SimpleWPFDialogNav.ViewModels;

namespace SimpleWPFDialogNav
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>    
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _mainViewModel;

        public MainWindow()
        {
            InitializeComponent();
            _mainViewModel = new MainViewModel();
            DataContext = _mainViewModel;
        }

        private void ShowNextWindow(object sender, RoutedEventArgs e)
        {
            _mainViewModel.ShowNextWindow();
        }
    }
}
