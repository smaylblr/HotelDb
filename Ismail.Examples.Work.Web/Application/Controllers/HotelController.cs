using Ismail.Examples.Work.Web.Domain.Entities;
using Ismail.Examples.Work.Web.Infrastructure.Contexts.WorkEntity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Ismail.Examples.Work.Web.Application
{
    public class HotelController : Controller
    {
        private readonly WorkContext db;

        public Guid Id { get; private set; }

        public HotelController(WorkContext db)
        {
            this.db = db;
        }

        [HttpGet("{id}/GetHotel")]
        public string GetHotel(Guid id)
        {

            var dto = db.Hotel
                .FirstOrDefault(s => s.Id.Equals(id));




            return JsonConvert.SerializeObject(dto);
        }

        [HttpGet("GetAllHotels")]
        public string GetAllHotels()
        {
            var dto = db.Hotel.ToList();


            return JsonConvert.SerializeObject(dto);
        }
        [HttpPost("CreatHotel")]
        public IActionResult CreatHotel([FromBody] Hotel Hotel)
        {



            db.Add(Hotel);


            db.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id}/UpdateHotel")]
        public IActionResult UpdateHotel(Guid id, string Yemeksekli, int YıldızSayısı, int ÜcretGünlük, string Sehir)
        {
            var dto = db.Hotel
                .FirstOrDefault(s => s.Id.Equals(id));
            dto.Sehir = Sehir;
            dto.YemekSekli = Yemeksekli;
            dto.YıldızSayısı = YıldızSayısı;
            dto.ÜcretGünlük = ÜcretGünlük;


            db.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}/DeleteHotel")]
        public IActionResult DeleteHotel(Guid id)
        {
            var dto = db.Hotel
                .FirstOrDefault(s => s.Id.Equals(id));
            dto.IsDeleted = true;



            db.SaveChanges();
            return NoContent();
        }

    }
}
