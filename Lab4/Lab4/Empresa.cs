using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Empresa:Cliente
    {
        public Empresa(string Rut)
        {
            this.Rut = Rut;
        }
        public  bool Municipalidad(Vehiculo vehiculo)
        {
            base.Municipalidad();

            if (vehiculo.TipoDeVehiculo == "Bus")
            {
                Random rnd = new Random();
                int posibilidad = rnd.Next(1, 100);
                if (posibilidad > 20)
                {
                    Console.WriteLine("Felicidades su peticion fue aprobada. Aprete 1 si quiere un Bus Liviano, 2 por un Bus Normal y 3 por uno de Lujo:");
                    string elecc = Console.ReadLine().ToString();
                    if (elecc == "1")
                    {
                        vehiculo.TipoDeVehiculo = "BusLiviano";
                        return true;
                    }
                    if (elecc == "2")
                    {
                        vehiculo.TipoDeVehiculo = "BusNormal";
                        return true;
                    }
                    if (elecc == "3")
                    {
                        vehiculo.TipoDeVehiculo = "BusLujo";
                        return true;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Lo siento su petición no fue aprobada");
                    return false;
                }

            }
            if (vehiculo.TipoDeVehiculo == "MaquinariaPesada")
            {
                Random rnd = new Random();
                int posibilidad = rnd.Next(1, 100);
                if (posibilidad < 37)
                {
                    Console.WriteLine("Felicidades su peticion fue aprobada");
                    return true; 


                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
