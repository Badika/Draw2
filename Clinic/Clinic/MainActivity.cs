using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.V4.View;
using System.Collections.Generic;
using Android.Support.V4.App;
using Android.Support.Design.Widget;
using Android.Views;

namespace Clinic
{
    [Activity(Label = "@string/app_name", Theme = "@style/MyTheme", MainLauncher = true)]
    public class MainActivity : FragmentActivity
    {

        ViewPager mPager;
        Android.Support.V4.View.PagerAdapter mPagerAdapter;
        List<FragmentBase> fragments;
        Toolbar editToolbar;
   
        protected override void OnCreate(Bundle savedInstanceState)
        {


            base.OnCreate(savedInstanceState);


            fragments = new List<FragmentBase>();

            fragments.Add(new Page0Patients(this.Parent) { FID = 0 });
            fragments.Add(new Page1Doctors(this.Parent) { FID = 1 });
            for (int i = 2; i < 4; i++)
            {
                fragments.Add(new FragmentBase(this.Parent) { FID = i });
            }

            SetContentView(Resource.Layout.pager_layout);



            editToolbar = FindViewById<Toolbar>(Resource.Id.edit_toolbar);
            editToolbar.Title = "Patients";
            editToolbar.InflateMenu(Resource.Layout.edit_menus);
            editToolbar.MenuItemClick += (sender, e) => {
                Toast.MakeText(this, "Bottom toolbar tapped: " + e.Item.TitleFormatted, ToastLength.Short).Show();
            };

            


            mPager = FindViewById<Android.Support.V4.View.ViewPager>(Resource.Id.pager);
            mPagerAdapter = new ScreenSlidePagerAdapter(ref fragments, SupportFragmentManager);
            mPager.Adapter = mPagerAdapter;
            mPager.PageSelected += mPager_PageSelected;
        }

        private void mPager_PageSelected(object sender, ViewPager.PageSelectedEventArgs e)
        {
            switch(e.Position)
            {
                case 0: editToolbar.Title = "Patients"; break;
                case 1: editToolbar.Title = "Doctors"; break;
                case 2: editToolbar.Title = "Page3"; break;
                case 3:
                    editToolbar.Title = "Page4";
                    editToolbar.InflateMenu(Resource.Layout.just_tools);
                    break;
            }
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }
    }
}