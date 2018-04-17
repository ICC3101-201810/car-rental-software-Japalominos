using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Organizacion:Cliente
    {
        public Organizacion(string Rut)
        {
            this.Rut = Rut;
        }
        public bool Municipalidad(Vehiculo vehiculo)
        {
            base.Municipalidad();

            if (vehiculo.TipoDeVehiculo == "Bus")
            {
                Random rnd = new Random();
                int posibilidad = rnd.Next(1, 100);
                if (posibilidad > 65)
                {
                    vehiculo.TipoDeVehiculo = "BusNormal";
                    return true;


                }
                else
                {
                    Console.WriteLine("Lo siento su petición no fue aprobada");
                    return false;
                }

            }
            else
            {
                Console.WriteLine("Lo siento su petición no fue aprobada");
                return false;
            }
        }
    }
}
