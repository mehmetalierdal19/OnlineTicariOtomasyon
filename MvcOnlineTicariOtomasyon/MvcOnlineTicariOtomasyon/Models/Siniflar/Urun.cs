using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Urun
    {
        [Key]
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public string Marka { get; set; }
        public int Stok { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
        public bool Durum { get; set; }
        public string Gorsel { get; set; }
        public Kategori Kategori { get; set; }
        public SatisHareket SatisHareket { get; set; }
    }
}