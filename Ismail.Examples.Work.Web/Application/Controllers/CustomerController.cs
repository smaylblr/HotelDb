using Ismail.Examples.Work.Web.Domain.Entities;
using Ismail.Examples.Work.Web.Infrastructure.Contexts.WorkEntity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Ismail.Examples.Work.Web.Application
{
    public class CustomerController : Controller
    {
        private readonly WorkContext db;

        public Guid Id { get; private set; }

        public CustomerController(WorkContext db)
        {
            this.db = db;
        }

        [HttpGet("{id}/GetCustomer")]
        public string GetCustomer(Guid id)
        {

            var dto = db.Customer
                .FirstOrDefault(s => s.Id.Equals(id));




            return JsonConvert.SerializeObject(dto);
        }

        [HttpGet("GetAllCustomers")]
        public string GetAllCustomers()
        {
            var dto = db.Customer.ToList();


            return JsonConvert.SerializeObject(dto);
        }
        [HttpPost("CreatCustomer")]
        public IActionResult CreatCustomer([FromBody] Customer Customer)
        {



            db.Add(Customer);


            db.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id}/UpdateCustomer")]
        public IActionResult UpdateCustomer(Guid id, string FirsName, string LastName, int Aqe, string Sehir)
        {
            var dto = db.Customer
                .FirstOrDefault(s => s.Id.Equals(id));
            dto.FirstName = FirsName;
            dto.LastName = LastName;
            dto.Age = Aqe;
            dto.Sehir = Sehir;


            db.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}/DeleteCustomer")]
        public IActionResult DeleteCustomer(Guid id)
        {
            var dto = db.Customer
                .FirstOrDefault(s => s.Id.Equals(id));
            dto.IsDeleted = true;



            db.SaveChanges();
            return NoContent();
        }
       
    }
}
