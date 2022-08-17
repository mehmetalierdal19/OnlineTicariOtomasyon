﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Departman
    {
        [Key]
        public int DepartmanID { get; set; }
        [StringLength(50)]
        public string DepartmanAd { get; set; }
        public ICollection<Personel> Personels { get; set; }
    }
}