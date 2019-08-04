using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.Store
{
    interface IStore
    {

        void Save(store sck);

        void Update(store sck);

        store Remove(string key);

        IEnumerable<store> GetStore();
    }
}
