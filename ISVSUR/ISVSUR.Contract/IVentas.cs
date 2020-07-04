using ISVSUR.Contract.Base;
using ISVSUR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVSUR.Contract
{
   public interface IVentas : IRead<EVentas>, TCreate<EVentas>
    {
        IEnumerable<EVentas> Search(int campo, string valor, bool status);
        IEnumerable<EVentas> pasajeros(string destino, string horasalida,DateTime fechaviaje, bool reservado);
        IEnumerable<EVentas> Modificar( bool Reservado);
    }
}
