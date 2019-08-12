using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.TaskTemplate
{
    interface ITaskTemplate
    {
        void Save(TaskTemplate sck);

        void Update(TaskTemplate sck);

        TaskTemplate Remove(string key);

        IEnumerable<TaskTemplate> GetTaskTemplate();
    }
}
