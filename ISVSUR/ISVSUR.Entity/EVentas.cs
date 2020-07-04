using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVSUR.Entity
{
  public  class EVentas
    {

        public int IDVenta { get; set; }
        public int IDCliente { get; set; }
        public int IDRuta { get; set; }
        public int IDAdmin { get; set; }



        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string dni { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public DateTime fviaje { get; set; }
        public string hsalida { get; set; }
        public decimal precio { get; set; }
     



        public int Asiento { get; set; }
        public string LugarAsiento { get; set; }
        public string vendedor { get; set; }
        public DateTime Fecha_De_Venta { get; set; }
        public bool Reservado { get; set; }





    
    }
}
