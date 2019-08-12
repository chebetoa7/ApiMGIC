using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.Task
{
    public class Task
    {
        [Key, Required]
        public string taskId { get; set; }

        [Required]
        public string idS { get; set; }

        [Required]
        public string DayId { get; set; }

        [Required]
        public string ScheduleId { get; set; }

        [Required]
        public string AssignedId { get; set; }

        [Required]
        public string TaskTemplateId { get; set; }

        [Required]
        public string StoreId { get; set; }

        [Required]
        public string HomeworkDescription { get; set; }

        [Required]
        public string DescripcionCoordinator { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public string Colour { get; set; }

        [Required]
        public string DayHome { get; set; }

        [Required]
        public string DayStart { get; set; }

        [Required]
        public string DayEnd { get; set; }

        [Required]
        public string Created_Date { get; set; }

        [Required]
        public string Updated_Date { get; set; }

    }
}
