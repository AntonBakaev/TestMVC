using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public string Index()
        {
            return "This is <b>Index</b>";
        }

        public string Welcome(string name = "You", int ID = 1)
        {
            return HttpUtility.HtmlEncode(string.Format("Hello {0}, ID: {1}", name, ID));
        }
    }
}