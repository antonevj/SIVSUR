using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ISVSUR.Util
{
    public class MisConstantes
    {
        public static readonly Color COLOR_CELDA_FONDO_GRID = Color.White;
        public static readonly Color COLOR_CELDA_FONDO_GRID_ALTER = Color.LightGoldenrodYellow;


        //public static readonly byte INSERCION = 1;
        //public static readonly byte MODIFICACION = 2;



        public enum OPERACION

        {
            Insercion = 1,
            Modificacion = 2


        }
    }
}
