using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.TaskTemplate
{
    public class TaskTemplate
    {
        [Key, Required]
        public string idS { get; set; }

        [Required]
        public string key { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        public string type { get; set; }

        [Required]
        public string enable { get; set; }

        [Required]
        public string nomenclature { get; set; }

    }
}
