using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneApplication.Models
{
    public class Phone
    {
        public Phone()
        {
            PhoneName = "";
            Manufacturer = "";
            DateReleased = new DateTime();
        }

        public int PhoneID { get; set; }
        public String PhoneName { get; set; }
        public String Manufacturer { get; set; }
        public double MSRP { get; set; }
        public double ScreenSize { get; set; }
        public DateTime DateReleased { get; set; }

    }
}