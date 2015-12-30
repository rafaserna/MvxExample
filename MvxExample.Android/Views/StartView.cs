namespace MvxExample.Android.Views
{
    using Cirrious.MvvmCross.Droid.Views;
    using global::Android.App;

    [Activity(Label="Start View")]
    public class StartView : MvxActivity
    {
        protected override void OnCreate(global::Android.OS.Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.StartView);
        }
    }
}