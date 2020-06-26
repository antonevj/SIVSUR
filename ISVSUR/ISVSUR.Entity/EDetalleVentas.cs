using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVSUR.Entity
{
 public   class EDetalleVentas
    {

        public int IDVenta { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }

        public string Ciudad_De_Origen { get; set; }
        public string Ciudad_De_Destino { get; set; }
        public DateTime Fecha_De_Viaje { get; set; }
        public string Hora_De_Salida { get; set; }
        public decimal precio { get; set; }
    

        public int Asiento { get; set; }
        public string LugarAsiento { get; set; }

        public string Vendedor { get; set; }

        public DateTime Fecha_De_Venta { get; set; }
    }
}
