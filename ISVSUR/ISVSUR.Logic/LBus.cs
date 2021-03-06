﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISVSUR.DATA;
using ISVSUR.Entity;
/*using System.Windows.Forms;*/

namespace ISVSUR.Logic
{
    public class LBus
    {
        public IEnumerable<EBus> GetAll(bool status)
        {
            return new DBus().GetAll(status);
        }

        public int Create(EBus t)
        {
            return new DBus().Create(t);
        }

        public int Update(EBus t)
        {
            return new DBus().Update(t);
        }

        public int Delete(int IDBus)
        {
            return new DBus().Delete(IDBus);
        }

        public IEnumerable<EBus> BUscarPlaca(string placa,bool status)
        {
            return new DBus().BUscarPlaca(placa,status);
        }
    }
}
