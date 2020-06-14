using ISVSUR.Contract.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISVSUR.Entity;

namespace ISVSUR.Contract
{
   public interface IRutas:IRead<ERutas>, TCreate<ERutas>,IUpdate<ERutas>,IDelete<ERutas>
    {

    }
}
