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


        public IEnumerable<EVentas> Search(int campo, string valor, bool status)
        {
            return new DVentas().Search(campo, valor, status);
        }



        public IEnumerable<EVentas> pasajeros(string destino, string horasalida, DateTime fechaviaje, bool reservado)
        {
            return new DVentas().pasajeros(destino,horasalida,fechaviaje,reservado);
        }



        public IEnumerable<EVentas> Modificar(bool Reservado)
        {
            return new DVentas().Modificar(Reservado);
        }

        }
}
