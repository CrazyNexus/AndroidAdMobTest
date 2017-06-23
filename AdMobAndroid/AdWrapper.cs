//
// AdWrapper.cs
//
// Created by Thomas Dubiel on 23.06.2017
// Copyright 2017 Thomas Dubiel (td@crazynexus.de). All rights reserved.
//
using Android.Content;
using Android.Gms.Ads;

namespace AdMobAndroid.ad
{
    public static class AdWrapper
    {

        public static AdView ConstructStandardBanner(Context context, AdSize adSize, string adId)
        {
            return new AdView(context)
            {
                AdSize = AdSize.SmartBanner,
                AdUnitId = "" // secret stuff
            };
        }

        public static AdView CustomBuild(this AdView ad)
        {
            var requestBuilder = new AdRequest.Builder();
            ad.LoadAd(requestBuilder.Build());
            return ad;
        }
    }
}
