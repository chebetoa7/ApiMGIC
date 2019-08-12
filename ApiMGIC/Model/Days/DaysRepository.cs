using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMGIC.Model.Days
{
    public class DaysRepository 
    {

        private static ConcurrentDictionary<string, Days> days_ =
        new ConcurrentDictionary<string, Days> ();

        public DaysRepository()
        {
            Save(new Days
            {
                idS = "098eec48-d622-45cc-b541-c96c1bcdf329",
                NameDay = "LUNES",
                Values =  "0",
                Status = "Inactivo"
            });
            Save(new Days
            {
                idS = "90531444-0116-4030-8c88-AFc55de83199",
                NameDay = "MARTES",
                Values = "1",
                Status = "Inactivo"
            });
            Save(new Days
            {
                idS = "67531444-7816-4330-8c88-dcc55de83188",
                NameDay = "MIÉRCOLES",
                Values = "2",
                Status = "Inactivo"
            });
            Save(new Days
            {
                idS = "9c3b414c-672e-457b-8f2b-820085a6fb41",
                NameDay = "JUEVES",
                Values = "3",
                Status = "Inactivo"
            });
            Save(new Days
            {
                idS = "1a8af5db-5364-4de9-babf-2b819ecdb1b1",
                NameDay = "VIERNES",
                Values = "4",
                Status = "Inactivo"
            });
            Save(new Days
            {
                idS = "83725a84-ad74-4a52-bcee-b353c7b4a8ce",
                NameDay = "SÁBADO",
                Values = "5",
                Status = "Inactivo"
            });
            Save(new Days
            {
                idS = "f0069232-938c-4ad5-b8cd-50c6b7effd55",
                NameDay = "DOMINGO",
                Values = "6",
                Status = "Inactivo"
            });
        }
        public IEnumerable<Days> GetDays()
        {
            return days_.Values;
            //throw new NotImplementedException();
        }

        public Days Remove(string key)
        {
            Days dys;
            days_.TryGetValue(key, out dys);
            return dys;
            //throw new NotImplementedException();
        }

        public void Save(Days dys)
        {
            days_[dys.idS.ToString()] = dys;
            //throw new NotImplementedException();
        }

        public void Update(Days dys)
        {
            days_[dys.idS.ToString()] = dys;
            //throw new NotImplementedException();
        }
    }
}
