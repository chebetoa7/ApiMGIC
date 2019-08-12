using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.Days
{
    public interface IDays
    {
        void Save(Days dys);

        void Update(Days dys);

        Days Remove(string key);

        IEnumerable<Days> GetDays();
    }
}
