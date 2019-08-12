using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.Assigne
{
    public class assigne
    {
        [Key, Required]
        public string idS { get; set; }

        [Required]
        public string numero { get; set; }

        [Required]
        public string nombre { get; set; }

        [Required]
        public string idpuesto { get; set; }

        [Required]
        public string cvepuesto { get; set; }

        [Required]
        public string puesto { get; set; }

        [Required]
        public string unidadorg { get; set; }

        [Required]
        public string subdiv { get; set; }

        [Required]
        public string nivel { get; set; }

        [Required]
        public string site { get; set; }

        [Required]
        public string jefeinm { get; set; }

        [Required]
        public string nombre_ji { get; set; }

        [Required]
        public string fialfa { get; set; }

        [Required]
        public string fipuesto { get; set; }

        [Required]
        public string celula { get; set; }
    }
}
