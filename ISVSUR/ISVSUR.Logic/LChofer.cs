using ISVSUR.DATA;
using ISVSUR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVSUR.Logic
{
    public class LChofer
    {
        public IEnumerable<EChofer> GetAll()
        {
            return new DChofer().GetAll();
        }
    }
}
