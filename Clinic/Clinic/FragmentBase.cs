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
    public class FragmentBase : Android.Support.V4.App.Fragment
    {
        protected Activity parent;

  //      protected ImageView overviewImg, accountsImg, cashFlowImg, payBillsImg, financialAdvisorImg, netWorthImg;

        public int FragmentIndex { get; set; }
        public int FID { get; internal set; }

        public FragmentBase(Activity parent)
            : base()
        {
            this.parent = parent;
        }

        public override void OnAttach(Activity activity)
        {
            base.OnAttach(activity);
        }

        public override void OnDetach()
        {
            base.OnDetach();
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // inflate layout here
            TextView t = new TextView(this.Context);
            t.Text = "test fragment " + FID;

            return t;
        }
    }
}