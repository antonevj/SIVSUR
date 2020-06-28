using ISVSUR.DATA;
using ISVSUR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVSUR.Logic
{
  public  class LVentas
    {
        public IEnumerable<EVentas> GetAll(bool Reservado)
        {
            return new DVentas().GetAll(Reservado);
        }
        public int Create(EVentas t)
        {
            return new DVentas().Create(t);
        }
      
    }
}
