using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMGIC.Model.CEDIS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMGIC.Controllers
{
   // [Route("api/[controller]")]
    //[ApiController]
    public class CEDISController : ControllerBase
    {
        cedisRepository cdiRepository = new cedisRepository();
        // GET: api/CEDIS
        [HttpGet]
        [Route("cdis")]
        public IEnumerable<cedis> Get()
        {
            var cedisAll = cdiRepository.GetCedi();
            return cedisAll;
            //return new string[] { "value1", "value2" };
        }

        /*
        // GET: api/CEDIS/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        *///
        //POST: api/CEDIS
        [HttpPost]
        [Route("cdis_post")]
        public IActionResult Post([FromBody] cedis cdi_)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                try
                {
                    cdiRepository.Save(cdi_);
                    return Ok(cdi_);
                }
                catch
                {
                    throw;
                }
            }
        }

        [HttpDelete]
        [Route("cedis_delete")]
        public void cdisDelete(string id)
        {
            try
            {
                cdiRepository.Remove(id);
            }
            catch
            {
                throw;
            }
        }
        /*
        // PUT: api/CEDIS/5
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
