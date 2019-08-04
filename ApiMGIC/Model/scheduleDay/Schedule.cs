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
        public int id { get; set; }

        [Required]
        public int idUsuarioFV { get; set; }

        [Required]
        public int idUsuarioMM { get; set; }

        [Required]
        public string fecha { get; set; }

        [Required]
        public string tipoAgenda { get; set; }

        [Required]
        public string estatus { get; set; }
    }
}
