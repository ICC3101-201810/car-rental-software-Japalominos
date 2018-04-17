using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Bus:Vehiculo
    {
        public Bus(string Marca, int Stock)
        {
            this.Marca = Marca;
            this.Stock = Stock;
        }
    }
}
