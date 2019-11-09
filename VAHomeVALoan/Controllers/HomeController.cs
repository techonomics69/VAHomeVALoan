﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VAHomeVALoan.Models;

namespace VAHomeVALoan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Results(Calculations model)
        {
            //ViewBag.Test = (int) model.LoanPeriod;
            ViewBag.MonthlyPayment = String.Format("Your Monthly Payment: {0}",
                       model.GetMonthlyPayment((int)model.LoanPeriod));  


            return PartialView();

        }
    }
}