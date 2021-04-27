using Learning_net_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learning_net_2.Controllers
{
    public class BookShopController : Controller
    {
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            return View();
        }
    }
}