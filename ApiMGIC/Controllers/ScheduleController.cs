using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMGIC.Model.scheduleDay;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMGIC.Controllers
{
    /*[Route("api/[controller]")]
    [ApiController]*/
    public class ScheduleController : ControllerBase
    {
        Model.scheduleDay.ScheduleRepository schedulerepo =
            new Model.scheduleDay.ScheduleRepository();
        // GET: api/Schedule
        [HttpGet]
        [Route("schedule")]
        public IEnumerable<Schedule> GetSchedule()
        {
            var scheduleAll = schedulerepo.GetSchedule();
            return scheduleAll;
            //return new string[] { "value1", "value2" };
        }

        //// GET: api/Schedule/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Schedule
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Schedule/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
