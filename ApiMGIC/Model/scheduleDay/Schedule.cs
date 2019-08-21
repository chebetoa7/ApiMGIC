using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.scheduleDay
{
    public class Schedule
    {
        
        [Key, Required]
        public string idS { get; set; }

        [Required]
        public string Scheduleid { get; set; }

        [Required]
        public string Storeid { get; set; }

        [Required]
        public string Assignedid { get; set; }

        public string Status { get; set; }

        public string Color { get; set; }

        public string Datevisit { get; set; }

        public string Dayid { get; set; }

        public string Hoursstart { get; set; }

        public string Hoursend { get; set; }

        public string Enabled { get; set; }

        public string LatitudeIn { get; set; }

        public string LongitudeIn { get; set; }

        public string LatitudeEnd { get; set; }

        public string LongituteEnd { get; set; }

        public string DistanceStart { get; set; }

        public string DistanceEnd { get; set; }

        public string TypeofEntry { get; set; }

        public string TypeHomeWorks { get; set; }

        public string CheckInOut { get; set; }

        public string TypeProcess { get; set; }

        public string Interlocutor { get; set; }

        public string Segment { get; set; }

        public string Creatorid { get; set; }

        public string Profile { get; set; }

        public string Celula { get; set; }
    }
}
