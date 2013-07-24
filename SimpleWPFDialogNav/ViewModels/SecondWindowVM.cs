namespace SimpleWPFDialogNav.ViewModels
{
    public class SecondWindowVM : ScreenVM
    {
        private string _name;
        private string _pass;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == _name) return;
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Pass
        {
            get { return _pass; }
            set
            {
                if (value == _pass) return;
                _pass = value;
                OnPropertyChanged();
            }
        }

        public SecondWindowVM(string name, string pass)
        {
            Name = name;
            Pass = pass;
        }

        public override void ScreenShowed()
        {
            
        }

        public override bool CanBeClosed()
        {
            return true;
        }

        public override void Closed()
        {
            
        }
    }
}