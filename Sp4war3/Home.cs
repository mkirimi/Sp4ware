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
using Java.Lang;

namespace Sp4war3
{
    [Activity(Label = "Sp4war3", MainLauncher = true, Icon = "@drawable/icon")]
    public class Home : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.layoutHome);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = "Sp4rkWare";

            var innovationToolbar = FindViewById<Toolbar>(Resource.Id.innovation_toolbar);
            innovationToolbar.Title = "Featured Innovations";
            innovationToolbar.InflateMenu(Resource.Menu.innovations_menus);

            innovationToolbar.MenuItemClick += (sender, e) =>
            {
                Toast.MakeText(this, "Bottom toolbar tapped: " + e.Item.TitleFormatted, ToastLength.Short).Show();
            };
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.top_menus, menu);
            return base.OnCreateOptionsMenu(menu);
        }
      
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            var submitFeedback = new Intent(this, typeof(Feedback));
            if (item.ItemId == Resource.Id.menu_feedback)
                StartActivity(submitFeedback);

            var viewAchievements = new Intent(this, typeof(Achievements));
            if (item.ItemId == Resource.Id.menu_achievements)
                StartActivity(viewAchievements);

            var openLab = new Intent(this, typeof(Lab));
            if (item.ItemId == Resource.Id.menu_lab)
                StartActivity(openLab);

            var openSettings = new Intent(this, typeof(Settings));
            if (item.ItemId == Resource.Id.menu_preferences)
                StartActivity(openSettings);
            return base.OnOptionsItemSelected(item);
        }
    }
}

    
