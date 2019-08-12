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
        public string Storeid { get; set; }

        [Required]
        public string Assignedid { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string Datevisit { get; set; }

        [Required]
        public string Hoursstart { get; set; }

        [Required]
        public string Hoursend { get; set; }

        [Required]
        public string Enabled { get; set; }

        [Required]
        public string LatitudeIn { get; set; }

        [Required]
        public string LongitudeIn { get; set; }

        [Required]
        public string LatitudeEnd { get; set; }

        [Required]
        public string LongituteEnd { get; set; }

        [Required]
        public string DistanceStart { get; set; }

        [Required]
        public string DistanceEnd { get; set; }

        [Required]
        public string TypeofEntry { get; set; }

        [Required]
        public string TypeHomeWorks { get; set; }

        [Required]
        public string CheckInOut { get; set; }

        [Required]
        public string TypeProcess { get; set; }

        [Required]
        public string Interlocutor { get; set; }

        [Required]
        public string Segment { get; set; }

        [Required]
        public string Creatorid { get; set; }

        [Required]
        public string Profile { get; set; }
    }
}
