using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.UserFV
{
    public class userFV
    {
        [Key, Required]
        public int id { get; set; }

        [Required]
        public int idBD { get; set; }

        [Required]
        public string tipo { get; set; }

        [Required]
        public string nombre { get; set; }

        [Required]
        public string numeronomina { get; set; }

        [Required]
        public string estado { get; set; }

        [Required]
        public string idPuesto { get; set; }

        [Required]
        public string cvPuesto { get; set; }

        [Required]
        public string puesto { get; set; }


    }
}
