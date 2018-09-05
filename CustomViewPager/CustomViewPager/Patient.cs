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
    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime B_Day { get; set; }

        public Patient()
        {

        }

        public Patient(string fn, string ln, DateTime rd, DateTime bd)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.RegistrationDate = rd;
            this.B_Day = bd;
        }

        public Patient(string fn, string ln, DateTime bd)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.RegistrationDate = DateTime.Now;
            this.B_Day = bd;
        }
    }
}