using ISVSUR.DATA;
using ISVSUR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISVSUR.Logic
{
    public class LChofer
    {
        public IEnumerable<EChofer> GetAll(bool status)
        {
            return new DChofer().GetAll(status);
        }

        public int Create(EChofer t)
        {
            return new DChofer().Create(t);
        }

        public int Update(EChofer t)
        {
            return new DChofer().Update(t);
        }

        public int Delete(int IDChofer)
        {
            return new DChofer().Delete(IDChofer);
        }

        public IEnumerable<EChofer> Buscar(String DNI, bool Estado)
        {
          return  new DChofer().Buscar(DNI,Estado);
        }

       
    }
}
