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
                nombre = "ALBERTO CASTRO PACHECO",
                idpuesto = "50190207",
                cvepuesto = "13V548",
                puesto = "VAMT",
                unidadorg = "50189917",
                subdiv = "LOS MOCHIS",
                nivel = "NIVEL_52",
                site = "CEDI LOS MOCHIS",
                jefeinm = "00081178",
                nombre_ji = "JESUS MARIO OCHOA",
                fialfa = "19920319",
                fipuesto = "20131001",
                celula = "U011"
            });
            Save(new assigne
            {
                idS = "dee9bc88-c481-4ce4-ba7a-7faea3769371",
                numero = "00080333",
                nombre = "MONSE LISO MAITE",
                idpuesto = "50190207",
                cvepuesto = "13V548",
                puesto = "VAMT",
                unidadorg = "50189917",
                subdiv = "LOS MOCHIS",
                nivel = "NIVEL_52",
                site = "CEDI LOS MOCHIS",
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
            asignado.TryGetValue(key, out asi);
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
