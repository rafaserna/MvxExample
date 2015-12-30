namespace MvxExample.Core.ViewModels
{
    using Cirrious.MvvmCross.ViewModels;

    public class StartViewModel : MvxViewModel
    {
        private string initialText;

        public StartViewModel()
        {
            InitialText = "Hello MvvmCross";
        }

        public string InitialText
        {
            get { return this.initialText; }
            set
            {
                this.initialText = value;
                RaisePropertyChanged(() => InitialText);
            }
        }
    }
}
