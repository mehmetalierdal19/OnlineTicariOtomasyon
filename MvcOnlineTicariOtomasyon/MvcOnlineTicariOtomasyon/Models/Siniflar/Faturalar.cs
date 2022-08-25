using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Faturalar
    {
        [Key]
        public int FaturaID { get; set; }
        [StringLength(5)]
        public string FaturaSeriNo { get; set; }
        [StringLength(10)]
        public string FaturaSiraNo { get; set; }
        [Column(TypeName ="Date")]
        public DateTime Tarih { get; set; }
        [StringLength(100)]
        public string VergiDairesi { get; set; }
        
        public TimeSpan Saat { get; set; }
        [StringLength(50)]
        public string TeslimEden { get; set; }
        [StringLength(50)]
        public string TeslimAlan { get; set; }
        public decimal ToplamTutar { get; set; }
        public ICollection<FaturaKalem> FaturaKalems { get; set; } 
    }
}