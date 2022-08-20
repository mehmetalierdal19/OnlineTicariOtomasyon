using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyon.Models.Siniflar;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class DepartmanController : Controller
    {
        Context c = new Context();
        // GET: Departman
        public ActionResult Index()
        {
            var degerler = c.Departmans.Where(x => x.Durum == true).ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult DepartmanEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DepartmanEkle(Departman d)
        {
            c.Departmans.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanSil(int id)
        {
            var deger = c.Departmans.Find(id);
            deger.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanGetir(int id)
        {
            var deger = c.Departmans.Find(id);
            return View("DepartmanGetir", deger);
        }
        public ActionResult DepartmanGuncelle(Departman p)
        {
            var deger = c.Departmans.Find(p.DepartmanID);
            deger.DepartmanAd = p.DepartmanAd;
            deger.Durum = p.Durum;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanDetay(int id)
        {
            var deger = c.Personels.Where(x => x.Departmanid == id).ToList();
            var dad = c.Departmans.Find(id);
            ViewBag.ad = dad.DepartmanAd;
            return View(deger);
        }
        public ActionResult DepartmanPersonelSatis(int id)
        {
            var deger = c.SatisHarekets.Where(x => x.Personelid == id).ToList();
            var ad = c.Personels.Find(id);
            ViewBag.dper = ad.PersonelAd + " " + ad.PersonelSoyad;
            return View(deger);
        }
    }
}