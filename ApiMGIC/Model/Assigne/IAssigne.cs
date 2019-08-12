using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.Assigne
{
    interface IAssigne
    {
        void Save(assigne sck);

        void Update(assigne sck);

        assigne Remove(string key);

        IEnumerable<assigne> GetAssigne();

    }
}
