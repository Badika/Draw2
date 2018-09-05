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

namespace CustomViewPager
{
    class Patients : ListActivity
    {
        Patient[] items;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            items = new Patient[] {
                new Patient("Victoria1", "Figurska1", DateTime.Now),
                new Patient("Victoria2", "Figurska2", DateTime.Now),
                new Patient("Victoria3", "Figurska3", DateTime.Now),
                new Patient("Victoria4", "Figurska4", DateTime.Now),
            };
            ListAdapter = new ArrayAdapter<Patient>(this, Android.Resource.Layout.SimpleListItem1, items);
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            var t = items[position];
            Android.Widget.Toast.MakeText(this, string.Format(t.FirstName + " " + t.LastName), Android.Widget.ToastLength.Short).Show();
        }
    }
}

