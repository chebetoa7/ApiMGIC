using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.CEDIS
{
    interface ICedis
    {
        void Save(cedis cdi);

        void Update(cedis cdi);

        cedis Remove(string key);

        IEnumerable<cedis> GetCedi();
    }
}
