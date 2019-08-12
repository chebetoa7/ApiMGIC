using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.TaskTemplate
{
    public class TaskTemplateRepository
    {
        private static ConcurrentDictionary<string, TaskTemplate> taskTemplate_ =
        new ConcurrentDictionary<string, TaskTemplate>();

        public TaskTemplateRepository()
        {
            Save(new TaskTemplate
            {
                idS = "19214001",
                key = "1",
                description = "Revisar existencias",
                type = "E",
                enable = "",
                nomenclature = "E1"
            });
            Save(new TaskTemplate
            {
                idS = "19214112",
                key = "2",
                description = "Revisar precios (propios y competencia)",
                type = "E",
                enable = "",
                nomenclature = "E2"
            });
            Save(new TaskTemplate
            {
                idS = "19214111",
                key = "1",
                description = "Ganar espacios de exhibicion en tienda",
                type = "E",
                enable = "",
                nomenclature = "E3"
            });
            Save(new TaskTemplate
            {
                idS = "19214000",
                key = "1",
                description = "Montar exhibiciones adicionales",
                type = "E",
                enable = "",
                nomenclature = "E4"
            });
        }
        public IEnumerable<TaskTemplate> GetTaskTemplate()
        {
            var taskTemplateAll = taskTemplate_.Values;
            return taskTemplateAll;
            //throw new NotImplementedException();
        }

        
        public TaskTemplate Remove(string key)
        {
            TaskTemplate tskT;
            taskTemplate_.TryGetValue(key, out tskT);
            return tskT;
            //throw new NotImplementedException();
        }

        public void Save(TaskTemplate sck)
        {
            taskTemplate_[sck.idS.ToString()] = sck;
            //throw new NotImplementedException();
        }

        public void Update(TaskTemplate sck)
        {
            taskTemplate_[sck.idS.ToString()] = sck;
            //throw new NotImplementedException();
        }
    }
}
