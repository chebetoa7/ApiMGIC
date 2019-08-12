using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.Task
{


    public class TaskRepository
    {

        private static ConcurrentDictionary<string, Task> task_ =
        new ConcurrentDictionary<string, Task>();

      

        public IEnumerable<Task> GetTask()
        {
            return task_.Values;
           //throw new NotImplementedException();
        }

        public Task Remove(string key)
        {
            Task tsk;
            task_.TryGetValue(key, out tsk);
            return tsk;
            //throw new NotImplementedException();
        }

        public void Save(Task sck)
        {
            task_[sck.idS.ToString()] = sck;
            //throw new NotImplementedException();
        }

        public void Update(Task sck)
        {
            task_[sck.idS.ToString()] = sck;
            //throw new NotImplementedException();
        }
    }
}
