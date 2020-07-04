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
    public class LCliente
    {
        public IEnumerable<ECliente> GetAll(bool status)
        {
            return new DCliente().GetAll(status);
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

        public IEnumerable<ECliente> Buscar(string DNI,bool Estado)
        {
            return new DCliente().Buscar(DNI,Estado);
        }

        public IEnumerable<ECliente> Search(int campo, string valor, bool status)
        {
            return new DCliente().Search(campo, valor, status);
        }

    }
}
