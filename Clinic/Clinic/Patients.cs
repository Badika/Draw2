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
    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegistrationDay { get; private set; }
        public DateTime B_Day { get; set; }

        public Patient()
        {
            
        }

        public Patient(string FirstName, string LastName, DateTime B_Day)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.B_Day = B_Day;
            this.RegistrationDay = DateTime.Now;
        }

        public Patient(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.B_Day = DateTime.Now;
            this.RegistrationDay = DateTime.Now;
        }
    }
}