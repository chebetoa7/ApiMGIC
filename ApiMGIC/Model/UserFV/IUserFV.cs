using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.UserFV
{
    interface IUserFV
    {

        void Save(userFV usfv);

        void Update(userFV usfv);

        userFV Remove(string Key);

        IEnumerable<userFV> GetUserFV();
    }
}
