using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace first.Controllers
{
    public class HalloController : Controller
    {
        // GET: Hallo
        public string Index()
        {
            return "hallo mvc";
        }
    }
}