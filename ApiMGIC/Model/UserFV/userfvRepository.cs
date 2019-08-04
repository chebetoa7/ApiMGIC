using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.UserFV
{
    public class userfvRepository 
    {

        private static ConcurrentDictionary<string, userFV> userFV =
            new ConcurrentDictionary<string, userFV>();


        public userfvRepository()
        {
            Save(new UserFV.userFV
            {
                id = 1,
                idBD = 00080222,
                tipo = "VAMT",
                nombre = "ALBERTO CASTRO PACHECO",
                numeronomina = "00080222",
                estado = "LOS MOCHIS",
                idPuesto = "50190207",
                cvPuesto = "05V565",
                puesto = "JEFE OPERACION COMERCIAL"
            });
            Save(new UserFV.userFV
            {
                id = 2,
                idBD = 00080223,
                tipo = "VAMT",
                nombre = "JESUS GOMEZ MARTINEZ",
                numeronomina = "00080223",
                estado = "SALTILLO",
                idPuesto = "50190208",
                cvPuesto = "05V565",
                puesto = "JEFE OPERACION COMERCIAL"
            });
            Save(new UserFV.userFV
            {
                id = 3,
                idBD = 00080224,
                tipo = "VAMT",
                nombre = "SALOMON CATILLO MONTERO",
                numeronomina = "00080224",
                estado = "MONTERREY",
                idPuesto = "50190209",
                cvPuesto = "05V565",
                puesto = "JEFE OPERACION COMERCIAL"
            });
            Save(new UserFV.userFV
            {
                id = 4,
                idBD = 00080225,
                tipo = "VAMT",
                nombre = "JOSE CAY CRUZ",
                numeronomina = "00080225",
                estado = "LOS MOCHIS",
                idPuesto = "50190210",
                cvPuesto = "05V565",
                puesto = "JEFE OPERACION COMERCIAL"
            });
            Save(new UserFV.userFV
            {
                id = 5,
                idBD = 00080226,
                tipo = "VAMT",
                nombre = "MOISES GUERRERO LÓPEZ",
                numeronomina = "00080226",
                estado = "LOS MOCHIS",
                idPuesto = "50190211",
                cvPuesto = "05V565",
                puesto = "JEFE OPERACION COMERCIAL"
            });
            Save(new UserFV.userFV
            {
                id = 6,
                idBD = 00080227,
                tipo = "VAMT",
                nombre = "ROBERTO CASTAÑEDA DURAN",
                numeronomina = "00080227",
                estado = "LOS MOCHIS",
                idPuesto = "50190212",
                cvPuesto = "05V565",
                puesto = "JEFE OPERACION COMERCIAL"
            });
        }

        public IEnumerable<userFV> GetUserFV()
        {
            return userFV.Values;
        }

        public userFV Remove(string Key)
        {
            userFV usfv;
            userFV.TryGetValue(Key, out usfv);
            return usfv;
        }

        public void Save(userFV usfv)
        {
            userFV[usfv.id.ToString()] = usfv;
        }

        public void Update(userFV usfv)
        {
            throw new NotImplementedException();
        }
    }
}
