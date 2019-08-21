using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.Task
{
    public class Task
    {
        [Required]
        public string TaskId { get; set; }

        [Key,Required]
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

       
        public string HomeworkDescription { get; set; }

      
        public string DescripcionCoordinator { get; set; }

     
        public string DescriptionSeller { get; set; }


        public string Status { get; set; }

   
        public string Colour { get; set; }

   
        public string DayHome { get; set; }


        public string DayStart { get; set; }


        public string DayEnd { get; set; }


        public string Description { get; set; }


        public string Created_Date { get; set; }

    
        public string Updated_Date { get; set; }


        public string Enabled { get; set; }

 
        public string Celula { get; set; }

    }
}
