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
        Context c = new Context();
        // GET: Cari
        public ActionResult Index()
        {
            var degerler = c.Carilers.Where(x => x.Durum == true).ToList();
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
            cari.Durum = true;
            c.Carilers.Add(cari);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CariSil(int id)
        {
            var deger = c.Carilers.Find(id);
            deger.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CariGetir(int id)
        {
            var deger = c.Carilers.Find(id);
            return View(deger);
        }
        public ActionResult CariGuncelle(Cariler cari)
        {
            if (!ModelState.IsValid)
            {
                return View("CariGetir");
            }
            else
            {
                var deger = c.Carilers.Find(cari.CariID);
                deger.CariAd = cari.CariAd;
                deger.CariMail = cari.CariMail;
                deger.CariSehir = cari.CariSehir;
                deger.CariSoyad = cari.CariSoyad;
                c.SaveChanges();
                return RedirectToAction("Index");
            }

        }
        public ActionResult CariSatis(int id)
        {
            var degerler = c.SatisHarekets.Where(x => x.Cariid == id).ToList();
            var ad = c.Carilers.Find(id);
            ViewBag.cariad = ad.CariAd + " " + ad.CariSoyad;
            return View(degerler);
        }
    }
}