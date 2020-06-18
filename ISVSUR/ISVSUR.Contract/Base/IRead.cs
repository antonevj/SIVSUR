using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVSUR.Contract.Base
{
    public interface IRead<T>where T:class
    {
        //Obtener todos los registros de la BD
        IEnumerable<T> GetAll(bool status);

        //Obtener un registro especifico 
        T Get(int IDCliente);
       
    }
}
