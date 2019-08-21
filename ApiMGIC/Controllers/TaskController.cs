using System;
using System.Collections.Generic;
using System.Linq;
using ApiMGIC.Model.Task;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMGIC.Controllers
{
    /*[Route("api/[controller]")]
    [ApiController]*/
    public class TaskController : ControllerBase
    {
        Model.Task.TaskRepository taskRepository = new Model.Task.TaskRepository();
        // GET: api/Task
        [HttpGet]
        [Route("tasks")]
        public IEnumerable<Model.Task.Task> GetTasks()
        {
            var taskAll = taskRepository.GetTask();
            return taskAll;
           // return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("task_celula")]
        public IEnumerable<Model.Task.Task> GetStoreCelula(string celula_)
        {
            var taskR = taskRepository.GetTask().Where(m => m.Celula == celula_);
            return taskR;
            //return new string[] { "value1", "value2" };
        }

        [HttpPost]
        [Route("Task_Post")]
        public IActionResult taskPost([FromBody]Task task_)
        {
            task_.idS = Guid.NewGuid().ToString("D");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                try
                {
                    taskRepository.Save(task_);
                    return Ok(task_);
                }
                catch
                {
                    throw;
                }
            }

        }


        [HttpPut]
        [Route("Task_Put")]
        public IActionResult PutTask([FromBody]Task task_)
        {
            //scheduleitem.idS = Guid.NewGuid().ToString("D");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                try
                {
                    //schedulerepo.Save(scheduleitem);
                    taskRepository.Update(task_);
                    return Ok();
                }
                catch
                {
                    throw;
                }
            }
        }

        /*
        // GET: api/Task/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Task
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Task/5
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
