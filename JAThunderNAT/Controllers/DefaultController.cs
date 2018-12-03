using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using JAThunderNAT.Models;

namespace JAThunderNAT.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string txtTotalAmount)
        {
            try
            {
                ViewBag.OriginalAmt = txtTotalAmount;
                ViewBag.CountedChange = ThunderChange.MakeChange(txtTotalAmount);
            }
            catch(FormatException ex)
            {
                ViewBag.ErrorMsg = "* Please enter a valid dollar amount in the box below.";
            }

            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            return View("About");
        }
        
    }
}