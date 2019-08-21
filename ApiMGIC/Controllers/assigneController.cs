using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMGIC.Model.Assigne;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMGIC.Controllers
{
    /*[Route("api/[controller]")]
    [ApiController]*/
    public class assigneController : ControllerBase
    {
        Model.Assigne.assigneRepository assigneRepo = new 
            Model.Assigne.assigneRepository();

        [EnableCors("MyPolicy")]
        [HttpGet]
        [Route("assigne")]
        public IEnumerable<assigne> GetAssine()
        {
            var assigneName = assigneRepo.GetAssigne();//.Where(m => m.nombre == nombre);
            return assigneName;
            //return new string[] { "value1", "value2" };
        }

        // GET: api/assigne
        [HttpGet]
        [Route("assigne_name")]
        public IEnumerable<assigne> GetAssineName(string nombre)
        {
            var assigneName = assigneRepo.GetAssigne().Where(m  => m.nombre == nombre);
            return assigneName;
            //return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("assigne_cvpuesto")]
        public IEnumerable<assigne> GetAssineCVPuesto(string cvpuesto)
        {
            var assigneName = assigneRepo.GetAssigne().Where(m => m.cvepuesto == cvpuesto);
            return assigneName;
            //return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("assigne_numero")]
        public IEnumerable<assigne> GetAssineNumero(string numero_)
        {
            var assigneName = assigneRepo.GetAssigne().Where(m => m.numero == numero_);
            return assigneName;
            //return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("assigne_celula")]
        public IEnumerable<assigne> GetAssineCelula(string celula_)
        {
            var assigneName = assigneRepo.GetAssigne().Where(m => m.celula == celula_);
            return assigneName;
            //return new string[] { "value1", "value2" };
        }

        [HttpPost]
        [Route("assigne_post")]
        public IActionResult assignePost([FromBody] assigne assigne_)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            } else
            {
                try
                {
                    assigneRepo.Save(assigne_);
                    return Ok(assigne_);
                } catch
                {
                    throw;
                }
            }
        }

        [HttpDelete]
        [Route("assigne_delete")]
        public void assigneDelete( string id)
        {
            try
            {
                assigneRepo.Remove(id);
            } catch
            {
                throw;
            }
        }

        /*
        // GET: api/assigne/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/assigne
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/assigne/5
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
