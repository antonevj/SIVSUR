using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVSUR.Contract.Base
{
    public interface IDelete<T> where T:class
    {

        //Eliminar registros de la base de datos
        int Delete(int IDCliente);

    }
}
