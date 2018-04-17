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
        public override  bool Municipalidad(Vehiculo vehiculo)
        {
            

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
                    Console.ReadKey();
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
                    Console.WriteLine("Felicidades su peticion fue aprobada");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public override Boolean LicenciaOAutorizacion(Vehiculo vehiculo)
        {
            
            if (vehiculo.TipoDeVehiculo == "Bus" || vehiculo.TipoDeVehiculo=="MaquinariaPesada")
            {
                bool permiso = Municipalidad(vehiculo);
                if (permiso == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Aprete 0 si tiene la autorización para operar:" + vehiculo.TipoDeVehiculo + ", si no aprete 1");

                while (true)
                {
                    string decc = Console.ReadLine();
                    if (decc == "0")
                    {
                        return true;
                    }
                    if (decc == "1")
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
