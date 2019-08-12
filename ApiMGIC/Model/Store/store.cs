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
        public string idS { get; set; }

        [Required]
        public string customernumber { get; set; }

        [Required]
        public string RutaSOL { get; set; }

        [Required]
        public string OficinadeVentas { get; set; }

        [Required]
        public string name1 { get; set; }

        [Required]
        public string name2 { get; set; }

        [Required]
        public string Poblacion { get; set; }

        [Required]
        public string zipcode { get; set; }

        [Required]
        public string streetandnumber { get; set; }

        [Required]
        public string Dirección { get; set; }

        [Required]
        public string salesorganization { get; set; }

        [Required]
        public string distributionchannel { get; set; }

        [Required]
        public string Sector { get; set; }

        [Required]
        public string Gpoclientes { get; set; }

        [Required]
        public string Zonadeventas { get; set; }


        [Required]
        public string region { get; set; }

        [Required]
        public string latitud { get; set; }

        [Required]
        public string longitud { get; set; }

        [Required]
        public string Interlocutor { get; set; }

        [Required]
        public string Segment { get; set; }


    }
}
