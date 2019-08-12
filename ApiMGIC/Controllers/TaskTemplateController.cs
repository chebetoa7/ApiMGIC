using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMGIC.Model.TaskTemplate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMGIC.Controllers
{
    /*[Route("api/[controller]")]
    [ApiController]*/
    public class TaskTemplateController : ControllerBase
    {
        Model.TaskTemplate.TaskTemplateRepository taskTRepo =
            new Model.TaskTemplate.TaskTemplateRepository();
        // GET: api/TaskTemplate
        [HttpGet]
        [Route("taskTemplate")]
        public IEnumerable<TaskTemplate> GetTaskTemplate()
        {
            var TakstAll = taskTRepo.GetTaskTemplate();
            return TakstAll;
            //return new string[] { "value1", "value2" };
        }

        /*
        // GET: api/TaskTemplate/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TaskTemplate
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/TaskTemplate/5
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
