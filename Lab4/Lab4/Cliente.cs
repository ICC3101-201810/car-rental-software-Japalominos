﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{



    abstract class Cliente
    {
        public string Rut;
        public virtual Boolean Municipalidad()
        {
            return true;
        }
        public virtual Boolean LicenciaOAutorizacion()
        {
            return true;

        }




    }
}
    