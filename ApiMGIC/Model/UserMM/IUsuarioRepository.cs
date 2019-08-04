using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.UserMM
{
    interface IUsuarioRepository
    {
        void Save(usuariomm ust);

        void Update(usuariomm ust);

        usuariomm Remove(string key);

        IEnumerable<usuariomm> GetUsuario();
    }
}
