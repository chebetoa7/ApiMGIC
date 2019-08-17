using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.CEDIS
{
    public class cedisRepository 
    {
        private static ConcurrentDictionary<string, cedis> cedis_ =
            new ConcurrentDictionary<string, cedis>();

        public cedisRepository()
        {
            Save(new cedis
            {
                idS = "101010",
                nombre = "CDISMONETERREY",
                estado = "Nuevo Leon",
                latitud = "25.752433",
                longitud = "-100.393991"
            });
            Save(new cedis
            {
                idS = "101011",
                nombre = "CDISSALTILLO",
                estado = "Cuahuila",
                latitud = "25.752433",
                longitud = "-100.393991"
            });
            Save(new cedis
            {
                idS = "101012",
                nombre = "CDISPUEBLA",
                estado = "Puebla",
                latitud = "25.752433",
                longitud = "-100.393991"
            });
            Save(new cedis
            {
                idS = "101013",
                nombre = "CDISOAXACA",
                estado = "Oaxaca",
                latitud = "25.752433",
                longitud = "-100.393991"
            });
        }
        public IEnumerable<cedis> GetCedi()
        {
            return cedis_.Values;
            //throw new NotImplementedException();
        }

        public cedis Remove(string key)
        {
            cedis cdi;
            cedis_.TryRemove(key, out cdi);
            return cdi;
            //throw new NotImplementedException();
        }

        public void Save(cedis cdi)
        {
            cedis_[cdi.idS.ToString()] = cdi;
            //throw new NotImplementedException();
        }

        public void Update(cedis cdi)
        {
            cedis_[cdi.idS.ToString()] = cdi;
            //throw new NotImplementedException();
        }
    }
}
