﻿using System;
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
                id = 1,
                idBD = 1001,
                nombre = "CDISMONETERREY",
                estado = "Nuevo Leon",
                latitud = "25.752433",
                longitud = "-100.393991"
            });
            Save(new cedis
            {
                id = 2,
                idBD = 1002,
                nombre = "CDISSALTILLO",
                estado = "Cuahuila",
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
            cedis_.TryGetValue(key, out cdi);
            return cdi;
            //throw new NotImplementedException();
        }

        public void Save(cedis cdi)
        {
            cedis_[cdi.id.ToString()] = cdi;
            //throw new NotImplementedException();
        }

        public void Update(cedis cdi)
        {
            cedis_[cdi.id.ToString()] = cdi;
            //throw new NotImplementedException();
        }
    }
}