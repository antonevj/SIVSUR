﻿using ISVSUR.DATA;
using ISVSUR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISVSUR.Logic
{
    public class LChofer
    {
        public IEnumerable<EChofer> GetAll()
        {
            return new DChofer().GetAll();
        }

        public int Create(EChofer t)
        {
            return new DChofer().Create(t);
        }

        public int Update(EChofer t)
        {
            return new DChofer().Update(t);
        }

        public int Delete(int IDChofer)
        {
            return new DChofer().Delete(IDChofer);
        }

        public void Buscar(DataGridView data, string DNICh)
        {
            new DCliente().Buscar(data, DNICh);
        }

       
    }
}
