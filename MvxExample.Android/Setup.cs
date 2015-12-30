namespace MvxExample.Android
{
    using Cirrious.MvvmCross.Droid.Platform;
    using Cirrious.MvvmCross.ViewModels;
    using global::Android.Content;

    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new MvxExample.Core.App();
        }
    }
}