using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Vehiculo
    {
        public enum vehiculo { Auto, Acuatico, Moto, Camion, Bus, MaquinariaPesada };
        public vehiculo TVehiculo;

        public Vehiculo(vehiculo miTVehiculo)
        {
            TVehiculo = miTVehiculo;           
           
        }
        



    }
}
