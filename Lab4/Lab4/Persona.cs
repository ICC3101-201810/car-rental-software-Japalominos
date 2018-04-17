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
        public override  Boolean LicenciaOAutorizacion(Vehiculo vehiculo)
        {
            
            if (vehiculo.TipoDeVehiculo == "Bus")
            {
                Console.WriteLine("Lo lamento usted no puede arrendar este tipo de vehiculo");
                return false;
               

            }
            else
            {
                Console.WriteLine("Aprete 0 si tiene la licencia para operar:" + vehiculo.TipoDeVehiculo+ ", si no aprete 1");

                while (true)
                {
                    string decc = Console.ReadLine();
                    if (decc == "0")
                    {
                        return true;
                    }
                    if (decc=="1")
                    {
                        return false;
                    }
                    else
                    {
                        
                    }
                }
                
            }
            
            
            
        }
        
    }
}
