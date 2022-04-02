using BaithiMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaithiMVC.Controllers
{
    public class MarketController : Controller
    {
        public MyDbContext db = new MyDbContext();
        public ActionResult Index(string marketName, string coinName )
        {
            var market = db.Markets.ToList();
            ViewBag.Markets = new SelectList(db.Markets, "Name", "Name");
            var coinList = db.Coins.ToList();
            return View(coinList);
        }
    }
}