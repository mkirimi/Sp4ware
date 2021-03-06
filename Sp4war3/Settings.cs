using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Sp4war3
{
    [Activity(Label = "Settings")]
    public class Settings : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Settings);

            var btnBackToHome = FindViewById<Button>(Resource.Id.btnBackToHome);
            btnBackToHome.Click += (sender, e) =>
            {
                var backToHome = new Intent(this, typeof(Home));
                //submitFeedback.PutExtra("FirstData", "Data from FirstActivity");
                StartActivity(backToHome);
            };
        }
    }
}