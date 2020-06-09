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

        public IEnumerable<EAdmin> GetAll()
        {
            return new DAdmin().GetAll();
        }
    }
}
