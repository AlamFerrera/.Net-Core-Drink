﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Drinks_App.Controllers
{
    public class ContactController : Controller
    {
        // GET: /<controller>/
        public ViewResult Index()
        {
            return View();
        }
    }
}
