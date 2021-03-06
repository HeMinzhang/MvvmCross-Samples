using Android.App;
using MvvmCross.Platforms.Android.Views;

namespace TwitterSearch.UI.Droid
{
    [Activity(Label = "TwitterSearch", MainLauncher = true, NoHistory = true, Icon = "@drawable/icon")]
    public class SplashScreenActivity
        : MvxSplashScreenActivity
    {
        public SplashScreenActivity()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}