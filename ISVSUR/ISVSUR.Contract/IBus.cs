﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISVSUR.Contract.Base;
using ISVSUR.Entity;

namespace ISVSUR.Contract
{
    public interface IBus : IRead<EBus> ,TCreate<EBus>,IUpdate<EBus>,IDelete<EBus>
    {
        IEnumerable<EBus> BUscarPlaca(string placa,bool status);
    }
}
