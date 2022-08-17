using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [StringLength(50)]
        public string KullaniciAd { get; set; }
        [StringLength(50)]
        public string Sifre { get; set; }
        [StringLength(5)]
        public string Yetki { get; set; }
    }
}