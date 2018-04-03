using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Vehiculo
    {
        string vehiculo;
        public Vehiculo(string mivehiculo)
        {
            if (mivehiculo == "auto" || mivehiculo == "acuático" || mivehiculo == "moto" || mivehiculo == "camión" || mivehiculo == "bus" || mivehiculo == "maquinaria pesada")
            {
                vehiculo = mivehiculo;
            }
           
        }



    }
}
