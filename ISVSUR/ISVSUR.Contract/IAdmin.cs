using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISVSUR.Contract.Base;
using ISVSUR.Entity;


namespace ISVSUR.Contract
{
   public interface IAdmin : IRead<EAdmin>,TCreate<EAdmin>, IUpdate<EAdmin>, IDelete<EAdmin>
    {

    }
}
