using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ismail.Examples.Work.Web.Domain.Entities
{
    public class Hotel
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Sehir { get; set; }
        [Required]
        public int YıldızSayısı { get; set; }
        [Required]
        public int ÜcretGünlük { get; set; }
        [Required]
        public string YemekSekli { get; set; }
        [Required]
        public bool IsDeleted { get; set; }

    }
}
