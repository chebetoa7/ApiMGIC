using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMGIC.Model.Days;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMGIC.Controllers
{/*[Route("api/[controller]")]
    [ApiController]*/
    public class DaysController : ControllerBase
    {
        Model.Days.DaysRepository daysRepo = new
            Model.Days.DaysRepository();
        // GET: api/Days
        [HttpGet]
        [Route("Days")]
        public IEnumerable<Days> GetDays()
        {
            var days_ = daysRepo.GetDays();
            return days_;
            //return new string[] { "value1", "value2" };
        }

        /*
        // GET: api/Days/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Days
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Days/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
