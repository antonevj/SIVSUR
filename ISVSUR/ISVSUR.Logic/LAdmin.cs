using ISVSUR.DATA;
using ISVSUR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVSUR.Logic
{
   public class LAdmin
    {

        public IEnumerable<EAdmin> GetAll(bool status)
        {
            return new DAdmin().GetAll(status);
        }
        public int Create(EAdmin t)
        {
            return new DAdmin().Create(t);
        }

        public int Update(EAdmin t)
        {
            return new DAdmin().Update(t);
        }

        public int Delete(int IDAdmin)
        {
            return new DAdmin().Delete(IDAdmin);
        }
    }
}
