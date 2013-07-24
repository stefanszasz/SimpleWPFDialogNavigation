using SimpleWPFDialogNav.Infrastructure;

namespace SimpleWPFDialogNav.ViewModels
{
    public class MainViewModel : BaseVM
    {
        private int _myProperty;

        public int MyProperty
        {
            get { return _myProperty; }
            set
            {
                if (value == _myProperty) return;
                _myProperty = value;
                OnPropertyChanged();
            }
        }

        public void ShowNextWindow()
        {
            var openScreen = ViewFactory.Create<SecondWindowVM>("one", "two");
            /* MODAL
            bool? showModal = openScreen.ShowModal();
            if (showModal == true)
            {
                
            }*/
            
            //normal window.show
            openScreen.Show();
        }
    }
}