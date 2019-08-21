using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.Assigne
{
    public class assigneRepository
    {
        private static ConcurrentDictionary<string, assigne> asignado =
        new ConcurrentDictionary<string, assigne>();

        public assigneRepository()
        {
            Save(new assigne
            {
                idS = "d82f102d-41f9-4495-88a2-4f944391d60a",
                numero = "00080222",
                nombre = "Chaidez Cepeda, Jorge",
                idpuesto = "50190207",
                cvepuesto = "13V548",
                puesto = "VAMS",
                unidadorg = "50189917",
                subdiv = "LOS MOCHIS",
                nivel = "NIVEL_52",
                site = "CDISDURANGO",
                jefeinm = "00080333",
                nombre_ji = "Juarez Avila, David",
                fialfa = "19920319",
                fipuesto = "20131001",
                celula = "U011"
            });
            Save(new assigne
            {
                idS = "dee9bc88-c481-4ce4-ba7a-7faea3769371",
                numero = "00080333",
                nombre = "Juarez Avila, David",
                idpuesto = "50190207",
                cvepuesto = "05V565",
                puesto = "JEFE DE OPERACION COMERCIAL",
                unidadorg = "12345678",
                subdiv = "PUEBLA",
                nivel = "NIVEL_52",
                site = "CDISPUEBLA",
                jefeinm = "00081178",
                nombre_ji = "JESUS MARIO OCHOA",
                fialfa = "19920319",
                fipuesto = "20131001",
                celula = "U012"
            });
            Save(new assigne
            {
                idS = "dee9bc88-c481-4ce4-ba7a-7faea37690010",
                numero = "00080334",
                nombre = "De la cruz Solano, José Alberto",
                idpuesto = "50190207",
                cvepuesto = "05V565",
                puesto = "JEFE DE OPERACION COMERCIAL",
                unidadorg = "50189917",
                subdiv = "OAXACA",
                nivel = "NIVEL_52",
                site = "CDISOAXACA",
                jefeinm = "00081178",
                nombre_ji = "JESUS MARIO OCHOA",
                fialfa = "19920319",
                fipuesto = "20131001",
                celula = "U012"
            });
            Save(new assigne
            {
                idS = "dee9bc88-c481-4ce4-ba7a-7faea2w369231",
                numero = "00080414",
                nombre = "Perez Tecol, Aaron",
                idpuesto = "5019009",
                cvepuesto = "TPM3D",
                puesto = "VAMT3",
                unidadorg = "50189917",
                subdiv = "PUEBLA",
                nivel = "NIVEL_51",
                site = "CDISPUEBLA",
                jefeinm = "00081178",
                nombre_ji = "JESUS MARIO OCHOA",
                fialfa = "19920319",
                fipuesto = "20131001",
                celula = "U011"
            });
        }
        public IEnumerable<assigne> GetAssigne()
        {
            return asignado.Values;
        }

        public assigne Remove(string key)
        {
            assigne asi;
            asignado.TryRemove(key, out asi);

            return asi;
        }

        public void Save(assigne sck)
        {
            asignado[sck.idS.ToString()] = sck;
            //throw new NotImplementedException();
        }

        public void Update(assigne sck)
        {
            asignado[sck.idS.ToString()] = sck;
            //throw new NotImplementedException();
        }
    }
}
