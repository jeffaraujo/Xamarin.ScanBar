﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
 
namespace Xamarin.ScanBar.Droid
{
    [Activity(Label = "Xamarin.ScanBar", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            global::Acr.BarCodes.BarCodes.Init(() => (Activity)Forms.Forms.Context);
            //global::Acr.BarCodes.BarCodes.Init(() => (Activity)Forms.Context);

            LoadApplication(new App());
        }
    }
}

