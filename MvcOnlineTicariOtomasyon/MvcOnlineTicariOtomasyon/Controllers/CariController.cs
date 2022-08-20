using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyon.Models.Siniflar;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class CariController : Controller
    {
        Context C = new Context();
        // GET: Cari
        public ActionResult Index()
        {
            var degerler = C.Carilers.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult CariEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CariEkle(Cariler cari)
        {
            C.Carilers.Add(cari);
            C.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}