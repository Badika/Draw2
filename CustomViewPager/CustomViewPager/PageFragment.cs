using System;
using System.Collections.Generic;
using Android;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace CustomViewPager
{
    class PageFragment : Fragment
    {
        const string ARG_PAGE = "ARG_PAGE";
        private int mPage;

        public static PageFragment newInstance(int page)
        {
            var args = new Bundle();
            args.PutInt(ARG_PAGE, page);
            var fragment = new PageFragment();
            fragment.Arguments = args;
            return fragment;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            mPage = Arguments.GetInt(ARG_PAGE);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view;
            TextView textView;
            ListView lv;
            if (mPage == 1)
            {
                view = inflater.Inflate(Resource.Layout.fragment_page2, container, false);
                textView = view.FindViewById<TextView>(Resource.Id.text_view2);
                lv = view.FindViewById<ListView>(Resource.Id.listView1);
                List<Patient> list = new List<Patient> {
                    new Patient("Victoria1", "Figurska1", DateTime.Now),
                    new Patient("Victoria2", "Figurska2", DateTime.Now),
                    new Patient("Victoria3", "Figurska3", DateTime.Now),
                    new Patient("Victoria4", "Figurska4", DateTime.Now),
                };

                List<string> listString = new List<string>();
                foreach (Patient p in list)
                {
                    listString.Add(string.Format(p.FirstName + " " + p.LastName));
                }
                ArrayAdapter<string> adapter = new ArrayAdapter<string>(this.Context, Android.Resource.Layout.SimpleListItem1, listString);
                lv.Adapter = adapter;
                textView.Text = "Page #" + mPage;
                return view;
            }



            if (mPage==2)
            {
                view = inflater.Inflate(Resource.Layout.fragment_page3, container, false);
                textView = view.FindViewById<TextView>(Resource.Id.doctors);
                lv = view.FindViewById<ListView>(Resource.Id.viewDoctors);
                List<string> doctorsList = new List<string>();
                doctorsList.Add("Vika Doctor 1");
                doctorsList.Add("Vika Doctor 2");
                doctorsList.Add("Vika Doctor 3");
                doctorsList.Add("Vika Doctor 4");
                doctorsList.Add("Vika Doctor 5");
                doctorsList.Add("Vika Doctor 6");
                ArrayAdapter<string> adapterDoctor = new ArrayAdapter<string>(this.Context, Android.Resource.Layout.SimpleListItem1, doctorsList);
                lv.Adapter = adapterDoctor;
                textView.Text = "Page #" + mPage;

                return view;
            }

            if (mPage == 3)
            {
                view = inflater.Inflate(Resource.Layout.fragment_page4, container, false);
                textView = view.FindViewById<TextView>(Resource.Id.appointments_text);
                lv = view.FindViewById<ListView>(Resource.Id.appointments_List);
                List<string> appList = new List<string>();
               for(int i = 0; i<40; i++)
                {
                    appList.Add(string.Format("appointmemt {0}", i));

                }
                ArrayAdapter<string> adapterApp = new ArrayAdapter<string>(this.Context, Android.Resource.Layout.SimpleListItem1, appList);
                lv.Adapter = adapterApp;
                textView.Text = "Page #" + mPage;

                return view;
            }

            view = inflater.Inflate(Resource.Layout.fragment_page, container, false);
            textView = (TextView)view;
            textView.Text = "Fragment #" + mPage;   
            return view;
        }

      
    }
}