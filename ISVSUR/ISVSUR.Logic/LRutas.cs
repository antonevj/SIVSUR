using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISVSUR.DATA;
using ISVSUR.Entity;
namespace ISVSUR.Logic
{
  public  class LRutas
    {

        public IEnumerable<ERutas> GetAll(bool status)
        {
            return new DRutas().GetAll(status);
        }

        public int Create(ERutas t)
        {
            return new DRutas().Create(t);
        }

        public int Update(ERutas t)
        {
            return new DRutas().Update(t);
        }

        public int Delete(int IDRuta)
        {
            return new DRutas().Delete(IDRuta);
        }

        public IEnumerable<ERutas> Buscar( string Destino, bool status)
        {
            return new DRutas().Buscar(Destino, status);
        }
    }


}
