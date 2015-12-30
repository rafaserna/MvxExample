namespace MvxExample.Core
{
    using Cirrious.MvvmCross.ViewModels;

    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<ViewModels.StartViewModel>();
        }
    }
}
