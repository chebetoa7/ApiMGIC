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
        public IEnumerable<Schedule> GetScheduleAll()
        {
            var scheduleidAssigne =
                schedulerepo.GetSchedule();
            return scheduleidAssigne;
            //return new string[] { "value1", "value2" };
        }
        [HttpGet]
        [Route("schedule_Id")]
        public IEnumerable<Schedule> GetSchedule(string assigneid_)
        {
            var scheduleidAssigne = 
                schedulerepo.GetSchedule().Where(m => m.Assignedid == assigneid_);
            return scheduleidAssigne;
            //return new string[] { "value1", "value2" };
        }

        [HttpPost]
        [Route("schedule_post")]
        public IActionResult PostSchedule([FromBody]Schedule scheduleitem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                try
                {
                    schedulerepo.Save(scheduleitem);
                    return Ok(scheduleitem);
                }
                catch
                {
                    throw;
                }
            }
            //var scheduleidAssigne =
            //    schedulerepo.GetSchedule().Where(m => m.Assignedid == assigneid_);
            //return scheduleidAssigne;
            //return new string[] { "value1", "value2" };
        }

        [HttpDelete]
        [Route("schedule_delete")]
        public void scheduleDelete(string id)
        {
            try
            {
                schedulerepo.Remove(id);
            }
            catch
            {
                throw;
            }
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
