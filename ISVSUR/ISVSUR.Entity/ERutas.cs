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
        public DateTime Duracion { get; set; }
        public string Chofer { get; set; }
    }
}
