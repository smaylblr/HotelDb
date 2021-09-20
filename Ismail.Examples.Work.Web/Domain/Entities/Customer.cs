using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ismail.Examples.Work.Web.Domain.Entities
{
    public class Customer
    {
        internal string lastName;

        [Required]
        public Guid Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }
      
        public int Age { get; set; }

        public bool IsDeleted { get; set; }

        [MaxLength(11)]
        [Required]
        public string TcNO { get; set; }

        [MaxLength(50)]
        [Required]
        public string Sehir { get; set; }


    }
}
