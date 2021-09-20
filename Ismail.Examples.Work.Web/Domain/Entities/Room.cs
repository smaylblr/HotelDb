using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ismail.Examples.Work.Web.Domain.Entities
{
    public class Room
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public int BedNumber { get; set; }

        public bool IsDeleted { get; set; }
    }
}
