using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Persona:Cliente
    {
        public Persona(string Rut)
        {
            this.Rut = Rut;
        }
        public  Boolean LicenciaOAutorizacion(Vehiculo vehiculo,bool Tarjeta)
        {
            base.LicenciaOAutorizacion();
            if (vehiculo.TipoDeVehiculo == "Bus")
            {
                return false;
               

            }
            else
            {
                if (Tarjeta == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            
            
        }
        
    }
}
