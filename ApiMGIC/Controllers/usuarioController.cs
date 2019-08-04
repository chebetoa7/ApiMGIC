using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMGIC.Model.UserMM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMGIC.Controllers
{
    /*[Route("api/[controller]")]
    [ApiController]*/
    public class usuarioController : ControllerBase
    {

        usuarioRepository usuarioRepository = new usuarioRepository();
        // GET: api/usuarioMM
       /* [HttpGet]
        [Route("api/usuarioMM/GetUsuario")]
        public IEnumerable<usuariomm> Get()
        {

            var usuAll = usuarioRepository.GetUsuario();

            return usuAll;
        }*/
        
        // GET: api/usuariomm
        [HttpGet]
        [Route("user")]
        public IEnumerable<usuariomm> Get()
        {
            //return new string[] { "value1", "value2" };
            var usuAll = usuarioRepository.GetUsuario();

            return usuAll;
        }
        /*
        // GET: api/usuario/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/usuario
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/usuario/5
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
