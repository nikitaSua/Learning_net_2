using Learning_net_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Learning_net_2.Controllers
{
    public class FootballController: Controller
    {
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            var players = db.Players.Include(p => p.Team);

            return View(players.ToList());
            //return View();
        }
    }
}