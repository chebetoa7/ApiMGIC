using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.Store
{
    public class store
    {
        [Key, Required]
        public int id { get; set; }

        [Required]
        public int idBD { get; set; }

        [Required]
        public string nombreCliente { get; set; }

        [Required]
        public string latitud { get; set; }

        [Required]
        public string longitud { get; set; }

        [Required]
        public string direccion { get; set; }

        [Required]
        public string canalDistribucion { get; set; }

        [Required]
        public string zonaVenta { get; set; }

        [Required]
        public string region { get; set; }

        [Required]
        public string segmento { get; set; }

        [Required]
        public string codigoPostal { get; set; }

        [Required]
        public string poblacion { get; set; }


    }
}
