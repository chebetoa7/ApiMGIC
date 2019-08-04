using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.UserMM
{
    public class usuariomm
    {
        [Key, Required]
        public int id { get; set; }

        [Required]
        public int idBD { get; set; }

        [Required]
        public string tipoUsuario { get; set; }

        [Required]
        public string canal { get; set; }

        [Required]
        public int idCedi { get; set; }

        [Required]
        public string estado { get; set; }
    }
}
