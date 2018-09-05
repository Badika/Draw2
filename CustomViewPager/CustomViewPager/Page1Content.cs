using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace CustomViewPager
{
    class Page1Content : View
    {
        public Page1Content(Context context) : base(context, null, 0)
        {
            List<Patient> list  = new List<Patient> {
                new Patient("Victoria1", "Figurska1", DateTime.Now),
                new Patient("Victoria2", "Figurska2", DateTime.Now),
                new Patient("Victoria3", "Figurska3", DateTime.Now),
                new Patient("Victoria4", "Figurska4", DateTime.Now),
            };
            ListView listView = FindViewById<ListView>(Resource.Id.listView1);

            List<string> listString = new List<string>();
            foreach(Patient p in list)
            {
                listString.Add(string.Format(p.FirstName + " " + p.LastName));
            }
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(context, Android.Resource.Layout.SimpleListItem1, listString);
            listView.Adapter = adapter;
        }
        public Page1Content(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

    }
}