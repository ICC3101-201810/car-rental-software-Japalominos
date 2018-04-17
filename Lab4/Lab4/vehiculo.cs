using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Vehiculo : General
    {
        public string TipoDeVehiculo;
        public int Stock;
        public Vehiculo( string TipoDeVehiculo, int Stock)
        {
            this.TipoDeVehiculo = TipoDeVehiculo;
            this.Stock = Stock;
        } 
        
       

    }
}
