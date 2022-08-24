using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyon.Models.Siniflar;
namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class SatisController : Controller
    {
        Context c = new Context();
        // GET: Satis
        public ActionResult Index()
        {
            var deger = c.SatisHarekets.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniSatis()
        {
            List<SelectListItem> urun = (from x in c.Uruns.Where(a => a.Durum == true).ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.UrunID.ToString() + "- " + x.UrunAd,
                                             Value = x.UrunID.ToString()
                                         }).ToList();
            List<SelectListItem> cari = (from x in c.Carilers.Where(a => a.Durum == true).ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.CariAd + " " + x.CariSoyad,
                                             Value = x.CariID.ToString()
                                         }).ToList();
            List<SelectListItem> personel = (from x in c.Personels.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.PersonelAd + " " + x.PersonelSoyad,
                                                 Value = x.PersonelID.ToString()
                                             }).ToList();
            ViewBag.personel = personel;
            ViewBag.cari = cari;
            ViewBag.urun = urun;
            return View();
        }
        [HttpPost]
        public ActionResult YeniSatis(SatisHareket sh)
        {
            sh.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.SatisHarekets.Add(sh);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SatisGetir(int id)
        {
            List<SelectListItem> urun = (from x in c.Uruns.Where(a => a.Durum == true).ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.UrunID.ToString() + "- " + x.UrunAd,
                                             Value = x.UrunID.ToString()
                                         }).ToList();
            List<SelectListItem> cari = (from x in c.Carilers.Where(a => a.Durum == true).ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.CariAd + " " + x.CariSoyad,
                                             Value = x.CariID.ToString()
                                         }).ToList();
            List<SelectListItem> personel = (from x in c.Personels.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.PersonelAd + " " + x.PersonelSoyad,
                                                 Value = x.PersonelID.ToString()
                                             }).ToList();
            ViewBag.personel = personel;
            ViewBag.cari = cari;
            ViewBag.urun = urun;
            var deger = c.SatisHarekets.Find(id);
            return View("SatisGetir", deger);
        }
        public ActionResult SatisGuncelle(SatisHareket sh)
        {
            sh.Tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            var deger = c.SatisHarekets.Find(sh.SatisID);
            deger.Cariid = sh.Cariid;
            deger.Fiyat = sh.Fiyat;
            deger.Personelid = sh.Personelid;
            deger.ToplamTutar = sh.ToplamTutar;
            deger.Urunid = sh.Urunid;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SatisDetay(int id)
        {
            var deger = c.SatisHarekets.Where(x => x.SatisID == id).ToList();
            return View("SatisDetay", deger);
        }
        public ActionResult SatisYazdir(int id)
        {
            var deger = c.SatisHarekets.Where(x => x.SatisID == id).ToList();
            return View("SatisYazdir", deger);
        }
    }
}