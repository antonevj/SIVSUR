using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVSUR.Contract.Base
{
    public interface TCreate<T> where T: class 
    {
        //Insertar registros en la BD

        int Create(T t);
    }
}
