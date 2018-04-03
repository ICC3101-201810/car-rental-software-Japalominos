using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Cliente
    {
        string TipoCliente;
        string Tarjeta;
        Vehiculo vehiculo;


        public Cliente(string MiTipoCliente, string MiTarjeta,Vehiculo mivehiculo)
        {
            
            if(MiTipoCliente=="persona")
            {
                if (MiTarjeta == "Licencia de conducir")
                {
                    TipoCliente = MiTipoCliente;
                    Tarjeta = MiTarjeta;
                }
            }
            if (MiTipoCliente=="empresa"||MiTipoCliente == "organización"||MiTipoCliente == "institución")
                if (MiTarjeta==)

        }
    }
}



    
