using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVSUR.DATA
{
    public class MiCadena
    {
        public static string CadenaCnx()
        {
            return ConfigurationManager.ConnectionStrings["micadena"].ConnectionString;
        }
    }
}
