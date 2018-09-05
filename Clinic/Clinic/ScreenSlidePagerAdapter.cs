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
    class ScreenSlidePagerAdapter : Android.Support.V4.App.FragmentStatePagerAdapter
    {
        List<FragmentBase> fragments;

        public ScreenSlidePagerAdapter(ref List<FragmentBase> fragments, Android.Support.V4.App.FragmentManager fm)
            : base(fm)
        {
            this.fragments = fragments;
        }

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return fragments[position];
        }

        public override int Count
        {
            get { return fragments.Count; }
        }
    }
}