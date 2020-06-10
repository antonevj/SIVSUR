using ISVSUR.DATA;
using ISVSUR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVSUR.Logic
{
    public class LCliente
    {
        public IEnumerable<ECliente> GetAll()
        {
            return new DCliente().GetAll();
        }

        public int Create(ECliente t)
        {
            return new DCliente().Create(t);
        }

        public int Update(ECliente t)
        {
            return new DCliente().Update(t);
        }

        public int Delete(int IDCliente)
        {
            return new DCliente().Delete(IDCliente);
        }
    }
}
