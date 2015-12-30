namespace MvxExample.Android
{
    using Cirrious.MvvmCross.Droid.Views;
    using global::Android.App;

    [Activity(Label = "Splash Screen", MainLauncher = true, Icon = "@drawable/icon")]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen() : base(Resource.Layout.SplashScreen)
        {
        }
    }
}