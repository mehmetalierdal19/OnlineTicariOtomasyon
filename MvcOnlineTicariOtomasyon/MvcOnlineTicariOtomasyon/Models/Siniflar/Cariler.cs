using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Cariler
    {
        [Key]
        public int CariID { get; set; }
        [StringLength(50)]
        public string CariAd { get; set; }
        [StringLength(50)]
        public string CariSoyad { get; set; }
        [StringLength(50)]
        public string CariSehir { get; set; }
        [StringLength(50)]
        public string CariMail { get; set; }
        public bool Durum { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}