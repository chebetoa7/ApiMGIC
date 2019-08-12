using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.Task
{
    interface ITask
    {
        void Save(Task sck);

        void Update(Task sck);

        Task Remove(string key);

        IEnumerable<Task> GetTask();
    }
}
