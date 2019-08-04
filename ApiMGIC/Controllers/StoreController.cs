using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMGIC.Model.Store;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMGIC.Controllers
{
    /*[Route("api/[controller]")]
    [ApiController]*/
    public class StoreController : ControllerBase
    {
        storeRepository storeRepository = new storeRepository();
        // GET: api/Schedule
        [HttpGet]
        [Route("store")]
        public IEnumerable<store> Get()
        {
            var storeAll = storeRepository.GetStore();// = new scheduleRepository();
            return storeAll;
           // return new string[] { "value1", "value2" };
        }

        /*

        // GET: api/Schedule/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Schedule
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Schedule/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
