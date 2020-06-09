using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISVSUR.DATA;
using ISVSUR.Entity;
namespace ISVSUR.Logic
{
  public  class LBus
    {
        public IEnumerable<EBus> GetAll()
        {
            return new DBus().GetAll();
        }

    }
}
