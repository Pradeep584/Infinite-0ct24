using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assesment_MVC.Models;

namespace Assesment_MVC.Controllers
{
   
        public class CodeController : Controller
        {
            public northwindEntities db = new northwindEntities();


            public ActionResult CustomersList()
            {
                var customers = db.Customers.Where(c => c.Country == "Germany").ToList();
                return View(customers);
            }


            public ActionResult CustomerOrder()
            {
                var customerDetails = db.Orders
                                         .Where(o => o.OrderID == 10248)
                                         .Select(o => o.Customer)
                                         .FirstOrDefault();
                return View(customerDetails);
            }
        }
    }