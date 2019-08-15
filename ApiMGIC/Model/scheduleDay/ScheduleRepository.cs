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
            Save(new Schedule
            {
                idS = "7238732783287238",
                Storeid = "0000123456",
                Assignedid = "00080334",
                Status = "Activo",
                Color = "Red",
                Datevisit = DateTime.Now.ToString(),
                Hoursstart = "09:00",
                Hoursend = "11:00",
                Enabled = "False",
                LatitudeIn = "13.23232",
                LongitudeIn = "-93.28374",
                LatitudeEnd = "0",
                LongituteEnd = "0",
                DistanceStart = "100",
                DistanceEnd = "100",
                TypeofEntry = "False",
                TypeHomeWorks = "Abordage",
                CheckInOut = "True",
                TypeProcess = "Nuevo",
                Interlocutor = "DET",
                Segment = "U012",
                Creatorid = "0000123456",
                Profile = "Supervisor MG"
            });
            
        }
        public IEnumerable<Schedule> GetSchedule()
        {
            return schedule.Values;
            //throw new NotImplementedException();
        }

        public Schedule Remove(string key)
        {
            Schedule sct;
            schedule.TryRemove(key, out sct);
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
