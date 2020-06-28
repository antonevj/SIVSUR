﻿using ISVSUR.Contract.Base;
using ISVSUR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVSUR.Contract
{
   public interface IVentas : IRead<EVentas>, TCreate<EVentas>
    {

    }
}