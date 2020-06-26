using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISVSUR.UI
{
    static class Program
    {

        //datos de la ruta
        public static int IDRuta;
        public static string Ciudad_De_Origen;
        public static string Ciudad_De_Destino;
        public static decimal Precio;     
        public static DateTime Fecha_De_Viaje;
        public static string Hora_De_Salida;


        //datos de cliente
        public static int IDCliente;
        public static string DNI;
        public static string Apellidos;
        public static string Nombres;
        public static string sexo;
        public static int edad;


       
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formulario_de_Venta());
        }
    }
}
