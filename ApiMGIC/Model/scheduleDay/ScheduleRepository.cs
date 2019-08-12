using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.scheduleDay
{
    public class ScheduleRepository 
    {
        private static ConcurrentDictionary<string, Schedule> schedule =
      new ConcurrentDictionary<string, Schedule>();
        public ScheduleRepository()
        {
            /*Save(new Schedule
            {
                idS = Guid.NewGuid().ToString("D"),
                Storeid = "10001",
                Assignedid = 1,
                fecha = "2019-08-9",
                tipoAgenda = "AB",
                estatus = "Nueva"
            });*/
            
        }
        public IEnumerable<Schedule> GetSchedule()
        {
            return schedule.Values;
            //throw new NotImplementedException();
        }

        public Schedule Remove(string key)
        {
            Schedule sct;
            schedule.TryGetValue(key, out sct);
            return sct;
            //throw new NotImplementedException();
        }

        public void Save(Schedule sct)
        {
            schedule[sct.idS.ToString()] = sct;
            //throw new NotImplementedException();
        }

        public void Update(Schedule sct)
        {
            schedule[sct.idS.ToString()] = sct;
            //throw new NotImplementedException();
        }
    }
}
