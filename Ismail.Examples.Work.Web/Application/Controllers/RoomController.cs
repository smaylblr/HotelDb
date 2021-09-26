using Ismail.Examples.Work.Web.Domain.Entities;
using Ismail.Examples.Work.Web.Infrastructure.Contexts.WorkEntity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ismail.Examples.Work.Web.Application.Controllers
{
    public class RoomController : Controller
    {
        private readonly WorkContext db;

        public Guid Id { get; private set; }

        public RoomController(WorkContext db)
        {

            this.db = db;
        }

        [HttpGet("{id}/GetRoom")]
        public  string GetRoom(Guid id)
        {

            var dto = db.Room
                .FirstOrDefault(s => s.Id.Equals(id));




            return JsonConvert.SerializeObject(dto);
        }

        [HttpGet("GetAllRooms")]
        public string GetAllRooms()
        {
            var dto = db.Room.ToList();


            return JsonConvert.SerializeObject(dto);
        }
        [HttpPost("CreatRoom")]
        public IActionResult CreatRoom([FromBody] Room room)
        {



            db.Add(room);


            db.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id}/UpdateRoom")]
        public IActionResult UpdateRoom(Guid id, int bedNumber, int Number)
        {
            var dto = db.Room
                .FirstOrDefault(s => s.Id.Equals(id));
            dto.BedNumber = bedNumber;
            dto.Number = Number;



            db.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}/DeleteRoom")]
        public IActionResult DeleteRoom(Guid id)
        {
            var dto = db.Room
                .FirstOrDefault(s => s.Id.Equals(id));
            dto.IsDeleted = true;



            db.SaveChanges();
            return NoContent();
        }
        //[HttpDelete("{id}/relationship")]
        //public IActionResult DeleteRelationships(Guid id)
        //{
        //    var asd = db.Customer

        //        .FirstOrDefault(s => s.Id.Equals(id));

        //    asd.IsDeleted = true;

        //    db.SaveChanges();
        //    return NoContent();
        //}

    }
}
