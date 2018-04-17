using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Organizacion : Cliente
    {
        public Organizacion(string Rut)
        {
            this.Rut = Rut;
        }
        public override bool Municipalidad(Vehiculo vehiculo)
        {


            if (vehiculo.TipoDeVehiculo == "Bus")
            {
                Random rnd = new Random();
                int posibilidad = rnd.Next(1, 100);
                if (posibilidad > 65)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Felicidades su petición fue aprobada");
                    Console.Beep();
                    vehiculo.TipoDeVehiculo = "BusNormal";
                    return true;


                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lo siento su petición no fue aprobada");
                    Console.Beep();
                    Console.Beep();


                    return false;
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lo siento su petición no fue aprobada");
                Console.Beep();
                Console.Beep();

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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lo lamento usted no puede arrendar este tipo de vehiculo");
                Console.Beep();
                Console.Beep();


                return false;
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
