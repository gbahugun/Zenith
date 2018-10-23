using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZenithWeb.Models;

namespace ZenithWeb.Controllers
{
    public class CompoundInterestController : Controller
    {
        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Index(CompoundInterest model)
        {
            model.Result = model.P * Math.Pow((1 + (model.R / model.N)), (model.N * model.T));
            return View(model);
        }
    }
}