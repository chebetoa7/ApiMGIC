using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.Days
{
    public class Days
    {
        [Key, Required]
        public string idS { get; set; }

        [Required]
        public string NameDay { get; set; }

        [Required]
        public string Values { get; set; }

        [Required]
        public string Status { get; set; }

    }
}
