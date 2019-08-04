using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.UserMM
{
    public class usuarioRepository
    {
        private static ConcurrentDictionary<string, usuariomm> usuario =
       new ConcurrentDictionary<string, usuariomm>();

        public usuarioRepository()
        {
            Save(new usuariomm
            {
                id = 1,
                idBD = 1001,
                tipoUsuario = "SU",
                canal = "DET",
                idCedi = 1,
                estado = "Monterrey"
            });
            Save(new usuariomm
            {
                id = 2,
                idBD = 1002,
                tipoUsuario = "EJ",
                canal = "DET",
                idCedi = 2,
                estado = "Monterrey"
            });
            Save(new usuariomm
            {
                id = 3,
                idBD = 1003,
                tipoUsuario = "EJ",
                canal = "DET",
                idCedi = 2,
                estado = "Monterrey"
            });
            Save(new usuariomm
            {
                id = 4,
                idBD = 1004,
                tipoUsuario = "EJ",
                canal = "DET",
                idCedi = 2,
                estado = "Monterrey"
            });
        }
        public IEnumerable<usuariomm> GetUsuario()
        {
            return usuario.Values;
        }

        public usuariomm Remove(string id)
        {
            usuariomm umi;
            usuario.TryGetValue(id, out umi);
            return umi;
        }

        public void Save(usuariomm ust)
        {
            usuario[ust.id.ToString()] = ust;
        }

        public void Update(usuariomm ust)
        {
            usuario[ust.id.ToString()] = ust;
        }
    }
}
