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
        public string Marca;
        public int Precio;
        public Vehiculo( string TipoDeVehiculo, int Stock, string Marca, int Precio )
        {
            this.TipoDeVehiculo = TipoDeVehiculo;
            this.Stock = Stock;
            this.Marca = Marca;
            this.Precio = Precio;
        } 
        
       

    }
}
