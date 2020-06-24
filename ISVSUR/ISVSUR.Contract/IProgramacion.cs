using ISVSUR.Contract.Base;
using ISVSUR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVSUR.Contract
{
  public  interface IProgramacion : IRead<EProgramacion>, TCreate<EProgramacion>, IUpdate<EProgramacion>, IDelete<EProgramacion>
    {



    }
}
