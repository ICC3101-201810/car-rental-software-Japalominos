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
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Felicidades su peticion fue aprobada. Aprete 1 si quiere un Bus Liviano, 2 por un Bus Normal y 3 por uno de Lujo:");
                    Console.Beep();
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lo siento su petición no fue aprobada");
                    Console.Beep();
                    Console.Beep();
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
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Felicidades su peticion fue aprobada");
                    Console.Beep();
                    return true; 


                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lo siento su peticion no fue aprobada");
                    Console.Beep();
                    Console.Beep();
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
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Aprete 0 si tiene la autorización para operar:" + vehiculo.TipoDeVehiculo + ", si no aprete 1");

                while (true)
                {
                    string decc = Console.ReadLine();
                    if (decc == "0")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Muy bien, puede arrendar este vehiculo");
                        Console.Beep();
                        return true;
                    }
                    else if (decc == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Lo lamento usted no puede arrendar este tipo de vehiculo");
                        Console.Beep();
                        Console.Beep();
                        return false;
                    }
                    
                }

            }



        }
    }
}
