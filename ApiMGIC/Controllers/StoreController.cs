using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMGIC.Model.Store;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiMGIC.Data.Entities;

namespace ApiMGIC.Controllers
{
    /*[Route("api/[controller]")]
    [ApiController]*/
    public class StoreController : ControllerBase
    {

        Model.Store.storeRepository storeRepository = new
            Model.Store.storeRepository();

        //private readonly DataContext dg;//= new Data.Entities.DataContext();


        /*public StoreController(storeRepository context)
        {
            storeRepository = context;
        }*/
        // GET: api/Schedule
        [HttpGet]
        [Route("store")]
        public IEnumerable<store> Get()
        {
            
            var storeAll = storeRepository.GetStore();// = new scheduleRepository();
            return storeAll;
           // return new string[] { "value1", "value2" };
        }


        [HttpPost]
        [Route("store_post")]
        public IActionResult PostStore([FromBody] store store_)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }
            else
            {
                try
                {
                    storeRepository.Save(store_);
                    //dg.SaveChanges();
                    return Ok(store_);
                } catch (Exception exM)
                {
                    Console.WriteLine(exM.Message);
                    throw;
                }
            }
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
