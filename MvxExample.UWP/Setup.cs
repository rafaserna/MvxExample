namespace MvxExample.UWP
{
    using Cirrious.MvvmCross.ViewModels;
    using Cirrious.MvvmCross.WindowsCommon.Platform;
    using Cirrious.MvvmCross.WindowsCommon.Views;
    using Windows.UI.Xaml.Controls;

    public class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
    }
}
