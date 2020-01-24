using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneApplication.Models;

namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {
            var phoneList = new List<Phone>
            {
                new Phone {PhoneName = "Iphone XS", Manufacturer = "Apple", MSRP = 1300, ScreenSize = 145.11, DateReleased = new DateTime(2018,08,01) },
                new Phone {PhoneName = "Iphone XS Max", Manufacturer = "Apple", MSRP = 1400, ScreenSize = 165.51, DateReleased = new DateTime(2018,08,01) },
                new Phone {PhoneName = "Iphone XS", Manufacturer = "Apple", MSRP = 2200, ScreenSize = 155.00, DateReleased = new DateTime(2019,10,01) },
            };
            return View(phoneList);
        }
}
}