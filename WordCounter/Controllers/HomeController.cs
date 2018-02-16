using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RepeatCounter.Models;

namespace RepeatCounter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View("Index", "");
        }

        [HttpPost("/result")]
        public ActionResult Result()
        {
            string phraseVal = Request.Form["phrase"];
            string checkVal = Request.Form["check"];
            RepeatCounterCreator newRepeatCounterCreator = new RepeatCounterCreator(phraseVal, checkVal);
            int model = RepeatCounterCreator.CountTool.CountStringOccurences(phraseVal, checkVal);
            return View("Index", model);
        }
    }
}
