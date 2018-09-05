using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.V4.View;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Graphics.Drawables;
using Android.Graphics;

namespace CustomViewPager
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);



            //var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            //SetActionBar(toolbar);
            //ActionBar.Title = "Clinic";
            //OnCreateOptionsMenu(toolbar.Menu);

            //GradientDrawable test = new GradientDrawable(GradientDrawable.Orientation.RightLeft, new int[] { /*new Color(90, 134, 34),*/ new Color(56, 172, 136), new Color(109, 200, 211), new Color(198, 223, 245), new Color(255, 255, 255) });
            //toolbar.SetBackgroundDrawable(test);


            //var toolbar2 = FindViewById<Toolbar>(Resource.Id.edit_toolbar);
            //SetActionBar(toolbar2);
            //ActionBar.Title = "Edit content";
            //OnCreateOptionsMenu(toolbar2.Menu);


            //var editToolbar = FindViewById<Toolbar>(Resource.Id.edit_menus);
            //editToolbar.Title = "Editing";
            //editToolbar.InflateMenu(Resource.Menu.edit_menus);
            //editToolbar.MenuItemClick += (sender, e) =>
            //{
            //    Toast.MakeText(this, "Bottom toolbar tapped: " + e.Item.TitleFormatted, ToastLength.Short).Show();
            //};













            // Find views
            var pager = FindViewById<ViewPager>(Resource.Id.pager);
            var tabLayout = FindViewById<TabLayout>(Resource.Id.sliding_tabs);
            var adapter = new CustomPagerAdapter(this, SupportFragmentManager);
         

            // Set adapter to view pager
            pager.Adapter = adapter;

            // Setup tablayout with view pager
            tabLayout.SetupWithViewPager(pager);

            // Iterate over all tabs and set the custom view
            for (int i = 0; i < tabLayout.TabCount; i++)
            {
                TabLayout.Tab tab = tabLayout.GetTabAt(i);
                tab.SetCustomView(adapter.GetTabView(i));
            }
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {

            MenuInflater.Inflate(Resource.Menu.top_menus, menu);

            return base.OnCreateOptionsMenu(menu);
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            Toast.MakeText(this, "Action selected: " + item.TitleFormatted,
                ToastLength.Short).Show();
            return base.OnOptionsItemSelected(item);
        }
    }
}