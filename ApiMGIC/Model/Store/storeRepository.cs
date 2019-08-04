using ApiMGIC.Model.Store;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.Store
{
    public class storeRepository
    {

        private static ConcurrentDictionary<string, store> tienda =
        new ConcurrentDictionary<string, store>();

        public storeRepository()
        {
            Save(new store
            {
                id = 1,
                idBD = 0000311185,
                nombreCliente = "BODEGA COM MEX (129 TOL II)",
                latitud = "19.453020",
                longitud = "-99.247784",
                direccion = "LOPEZ MATEOS 1415 Y LAG DE COL ., .",
                canalDistribucion = "AU",
                zonaVenta = "CENTR",
                region = "T28",
                segmento = "U011",
                codigoPostal = "03730",
                poblacion = "Toluca"
            });
            
            Save(new store
            {
                id = 2,
                idBD = 0000311185,
                nombreCliente = "PITICO CD OAX (130 OAX I)",
                latitud = "19.453020",
                longitud = "-99.247784",
                direccion = "ZAPATA 9001 Y AV. P21., .",
                canalDistribucion = "AU",
                zonaVenta = "CENTR",
                region = "O01",
                segmento = "U011",
                codigoPostal = "03730",
                poblacion = "Oaxaca"
            });
        }

        public IEnumerable<store> GetStore()
        {
            return tienda.Values;
        }

        public store Remove(string key)
        {
            store shk;
            tienda.TryGetValue(key,out shk);
            return shk;
        }

        public void Save(store sck)
        {
            //throw new NotImplementedException();
            tienda[sck.id.ToString()] = sck;
        }

        public void Update(store sck)
        {
            tienda[sck.id.ToString()] = sck;
        }
    }
}
