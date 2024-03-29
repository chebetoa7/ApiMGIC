﻿using ApiMGIC.Data.Entities;
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

        private DataContext DataContext_;

        public storeRepository()
        {


            //this.DataContext_ = dataContext;
            Save(new store
            {
                idS = "10001",
                customernumber = "0000311185",
                RutaSOL = "AUTTOLT28",
                OficinadeVentas = "TOL",
                name1 = "BODEGA COM MEX (129 TOL II)",
                name2 = "",
                Poblacion = "TOLUCA",
                zipcode = "03730",
                streetandnumber = "LOPEZ MATEOS 1415 Y LAG DE COL ., .",
                Dirección = "0000144274",
                salesorganization = "AUCF",
                distributionchannel = "AU",
                Sector = "GE",
                Gpoclientes = "MS",
                Zonadeventas = "CENTR",
                region = "T28",
                latitud = "19.453020",
                longitud = "-99.247784",
                Interlocutor = "Z7",
                Segment = "U011"
            });

            Save(new store
            {
                idS = "10002",
                customernumber = "0000122179",
                RutaSOL = "AUTTOLT29",
                OficinadeVentas = "TOL",
                name1 = "SORIANA COM MEX (129 TOL III)",
                name2 = "",
                Poblacion = "TOLUCA",
                zipcode = "03730",
                streetandnumber = "ZAPATA 2010 Y LOPEZ DE COL ., .",
                Dirección = "0000144272",
                salesorganization = "AUCF",
                distributionchannel = "AU",
                Sector = "GE",
                Gpoclientes = "MS",
                Zonadeventas = "SUR",
                region = "T28",
                latitud = "19.453033",
                longitud = "-99.247389",
                Interlocutor = "Z7",
                Segment = "U011"
            });
            Save(new store
            {
                idS = "10003",
                customernumber = "0000123456",
                RutaSOL = "AUTTOLT28",
                OficinadeVentas = "PUE",
                name1 = "WALMART (110 PUE II)",
                name2 = "",
                Poblacion = "PUEBLA",
                zipcode = "72567",
                streetandnumber = "Boulevard Valsequillo #7654",
                Dirección = "0000144274",
                salesorganization = "AUCF",
                distributionchannel = "DET",
                Sector = "GE",
                Gpoclientes = "MS",
                Zonadeventas = "CENTR",
                region = "T28",
                latitud = "25.641505312725172",
                longitud = "-100.32079805644746",
                Interlocutor = "Z7",
                Segment = "U012"
            });

            Save(new store
            {
                idS = "10004",
                customernumber = "0000654321",
                RutaSOL = "AUTTOLT29",
                OficinadeVentas = "OAX",
                name1 = "PITICO",
                name2 = "",
                Poblacion = "OAXACA",
                zipcode = "70102",
                streetandnumber = "GONZALEZ 0091 COL. CENTRAL",
                Dirección = "0000144272",
                salesorganization = "AUCF",
                distributionchannel = "DET",
                Sector = "GE",
                Gpoclientes = "MS",
                Zonadeventas = "SUR",
                region = "T28",
                latitud = "19.453033",
                longitud = "-99.247389",
                Interlocutor = "Z7",
                Segment = "U012"
            });
        }

        public IEnumerable<store> GetStore()
        {
            return tienda.Values;
            //return DataContext_.stores;// tienda.Values;
        }

        public store Remove(string key)
        {
            store shk;
            tienda.TryRemove(key,out shk);
            return shk;
        }

        public void Save(store sck)
        {
            //throw new NotImplementedException();
            tienda[sck.idS.ToString()] = sck;
            //tienda[sck.idS.ToString()] = sck;
           //await  this.DataContext_.stores.AddAsync(sck);
            //await this.DataContext_.SaveChangesAsync();
        }

        public void Update(store sck)
        {
            tienda[sck.idS.ToString()] = sck;
        }
    }
}
