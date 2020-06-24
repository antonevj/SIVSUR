using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVSUR.Entity
{
 public   class ERutas
    {

        public int IDRuta { get; set; }
        public string Ciudad_De_Origen { get; set; }
        public string Ciudad_De_Destino { get; set; }
        public decimal precio { get; set; }
        public string Duracion { get; set; }
        public string Chofer { get; set; }
        public DateTime Fecha_De_Viaje { get; set; }
        public string Hora_De_Salida { get; set; }
        public bool Estado { get; set; }
    }
}
