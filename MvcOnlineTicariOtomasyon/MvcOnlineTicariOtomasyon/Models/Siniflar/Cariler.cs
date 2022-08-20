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
        [Required(ErrorMessage ="Bu alanı boş geçemezsiniz!")]
        public string CariAd { get; set; }
        [StringLength(50, ErrorMessage ="En fazla 50 karakter girebilirsiniz.")]
        public string CariSoyad { get; set; }
        [StringLength(50)]
        public string CariSehir { get; set; }
        [StringLength(50)]
        public string CariMail { get; set; }
        public bool Durum { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}