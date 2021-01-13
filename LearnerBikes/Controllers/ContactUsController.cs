﻿using LearnerBikes.Helpers;
using LearnerBikes.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnerBikes.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index (Contact contact)
        {
            ContactHelper helper = new ContactHelper();
            helper.sendEmail(contact);
            return RedirectToAction("FormSubmitted", "ContactUs");
        }

        public IActionResult FormSubmitted()
        {
            return View();
        }

    }
}
