using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.CEDIS
{
    public class cedis
    {
        [Key, Required]
        public int id { get; set; }

        [Required]
        public int idBD { get; set; }

        [Required]
        public string nombre { get; set; }

        [Required]
        public string estado { get; set; }

        [Required]
        public string ciudad { get; set; }

        [Required]
        public string latitud { get; set; }

        [Required]
        public string longitud { get; set; }
    }
}
