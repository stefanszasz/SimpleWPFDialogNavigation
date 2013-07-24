using System;

namespace SimpleWPFDialogNav.ViewModels
{
    public class ScreenVM : BaseVM
    {
        internal Action Showed;
        internal Func<bool?> ShowedDialog;

        public virtual void Show()
        {
            Showed();
            ScreenShowed();
        }

        public virtual bool? ShowModal()
        {
            ScreenShowed();
            return ShowedDialog();
        }

        public virtual void Closed()
        {
            
        }

        public virtual void ScreenShowed()
        {
            
        }

        public virtual bool CanBeClosed()
        {
            return true;
        }
    }
}