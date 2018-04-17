using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Institucion : Cliente
    {
        public Institucion(String Rut)
        {
            this.Rut = Rut;
        }
        public override bool Municipalidad(Vehiculo vehiculo)
        {


            if (vehiculo.TipoDeVehiculo == "Bus")
            {
                Random rnd = new Random();
                int posibilidad = rnd.Next(1, 100);
                if (posibilidad > 42)
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
                    else
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
            else
            {
                Console.WriteLine("Lo siento su petición no fue aprobada");
                return false;
            }
        }
        public override Boolean LicenciaOAutorizacion(Vehiculo vehiculo)
        {

            if (vehiculo.TipoDeVehiculo == "Bus")
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
            if (vehiculo.TipoDeVehiculo == "MaquinariaPesada")
            {
                Console.WriteLine("Lo lamento usted no puede arrendar este tipo de vehiculo");
                return false;
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
