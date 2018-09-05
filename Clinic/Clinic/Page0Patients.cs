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

namespace Clinic
{
    public class Page1Doctors : FragmentBase
    {
 
        public Page1Doctors(Activity parent)
           : base(parent)
        {
          
        }

        List<string> patients;
        View view;
        ListView listView;

        

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.doctors_page, container, false);
            listView = view.FindViewById<ListView>(Resource.Id.patients_list);

            AddPatientsList();

            listView.ItemClick += ListView_ItemClick;
            return view;
        }

        private void AddPatientsList()
        {
            patients = new List<string>();
            for (int i = 0; i < 40; i++)
            {
                patients.Add("Vika Doctor " + i);
            }

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this.Context, Android.Resource.Layout.SimpleListItem1, patients);
            listView.Adapter = adapter;
        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            ListView lv = (ListView)sender;
            
            
            System.Diagnostics.Debug.WriteLine("lv.SelectedItemId = " + lv.SelectedItemId + "\n" +
                                               "lv.Selected = " + lv.Selected + "\n" +
                                               "lv.SelectedItem = " + lv.SelectedItem + "\n" +
                                               "lv.SelectedItemPosition = " + lv.SelectedItemPosition);
            System.Diagnostics.Debug.WriteLine("e.Id = " + e.Id + "\n" +
                                               "e.Position = " + e.Position);
                                              
            Toast.MakeText(this.Context, patients[e.Position], ToastLength.Short).Show();
        
        }   
    }
}