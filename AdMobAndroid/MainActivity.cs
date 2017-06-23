using Android.App;
using Android.Widget;
using Android.OS;
using Android.Gms.Ads;

namespace AdMobAndroid
{
    [Activity(Label = "AdMobAndroid", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate { button.Text = $"{count++} clicks!"; };

            var ad = new AdView(this);
            ad.AdSize = AdSize.SmartBanner;
            ad.AdUnitId = ""; // secret ID
            var requestbuilder = new AdRequest.Builder();
            ad.LoadAd(requestbuilder.Build());

            var layout = FindViewById<LinearLayout>(Resource.Id.mainLayout);
            layout.AddView(ad);
        }
    }
}

