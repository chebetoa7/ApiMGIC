using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.scheduleDay
{
    interface IScheduleRepository
    {
        void Save(Schedule sct);

        void Update(Schedule sct);

        Schedule Remove(string key);

        IEnumerable<Schedule> GetSchedule();
    }
}
