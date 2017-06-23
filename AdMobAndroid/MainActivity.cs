using Android.App;
using Android.Widget;
using Android.OS;
using Android.Gms.Ads;
using AdMobAndroid.ad;

namespace AdMobAndroid
{
    [Activity(Label = "AdMobAndroid", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        AdView bannerAd;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            bannerAd = AdWrapper.ConstructStandardBanner(this, AdSize.SmartBanner, "");
            bannerAd.CustomBuild();

            var layout = FindViewById<LinearLayout>(Resource.Id.mainLayout);
            layout.AddView(bannerAd);
        }

        protected override void OnResume()
        {
            if (bannerAd != null) bannerAd.Resume();
            base.OnResume();
        }

        protected override void OnPause()
        {
            if (bannerAd != null) bannerAd.Pause();
            base.OnPause();
        }
    }
}

