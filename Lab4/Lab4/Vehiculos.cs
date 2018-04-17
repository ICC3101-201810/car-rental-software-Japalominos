using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class Vehiculo : General
    {
        public string Marca;
        public int Stock;
        
        public virtual Boolean Municipalidad(Cliente cliente)
        {
            return true;
        }
        public virtual Boolean LicenciaOAutorizacion(Cliente cliente)
        {
            return true;
        }

    }
}
