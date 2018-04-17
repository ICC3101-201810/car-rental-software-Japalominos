using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        
        public enum Clientes {Persona,Empresa,Organizacion,Institucion };
        static void Main(string[] args)
        {
            List<Sucursal> Sucursales = new List<Sucursal>();
            List<Vehiculo> Vehiculos = new List<Vehiculo>();
            List<Accesorios> Accesorios = new List<Accesorios>();
            List<Arriendo> Arriendos = new List<Arriendo>();
            List<Cliente> Clientes = new List<Cliente>();
            Console.WriteLine("Aprete 0 si es Persona, 1 si es una Empresa, 2 si es una Organización, 3 si es una Institución:");
            string num = Console.ReadLine().ToString();            
            int tipo=Convert.ToInt32(num) ;
            
            Console.WriteLine("Ingrese su Rut:");
            string rut = Console.ReadLine().ToString();
           

            if (num == "0")
            {
                Persona clientex = new Persona(rut);
               
            }
            if (num=="1")
            {
                Empresa clientex = new Empresa(rut);

            }
            if (num=="2")
            {
                Organizacion clientex = new Organizacion(rut);
            }
            if (num=="3")
            {
                Institucion clientex = new Institucion(rut);
            }
            
            
            
            Console.WriteLine("Que vehiculo quiere arrendar:");
            string vehiculo = Console.ReadLine().ToString();
            Console.WriteLine("En que sucursal lo quiere arreglar");
            string sucursal = Console.ReadLine().ToString();
            Console.WriteLine("Escriba el total:");
            int total = Convert.ToInt32(Console.ReadLine().ToString());
            Console.WriteLine("Escriba la licencia (en el caso de ser persona) al vehiculo correspondiente , y autorizacion (en todo lo demás) al vehiculo correspondiente ");
            Console.WriteLine("Ejemplo de como ingresar una licencia: LicenciaDeConducirDeAuto, y un ejemplo de autorización: AutorizacionDeBote");
            string tarjeta = Console.ReadLine().ToString();
            Console.WriteLine("Escriba Fecha de Termino");
            Console.WriteLine("Asi: DD/MM/AA");
            string FTermi = Console.ReadLine().ToString();
            DateTime Inicio = new DateTime();
            if (Arriendos.Any(x => x.cliente == clientex) == true)
            {
                Arriendo arriendox1 = new Arriendo(vehiculo, sucursal, clientex, Inicio, total , FTermi, tarjeta);
                if (arriendox1.AutorizacionA() == true)
                {
                    Console.WriteLine("Escriba si, si quiere incluir accesorios,al contrario escriba no");
                    string dec = Console.ReadLine().ToString();
                    if (dec == "si")
                    {
                        List<string> AccesoriosCliente = new List<string>();
                        while (true)
                        {
                            Console.WriteLine("Escriba el accesorio que quiere, si ya termino escriba no");
                            string acc = Console.ReadLine().ToString();
                            if (acc == "no")
                            {
                                break;
                            }
                            else
                            {
                                AccesoriosCliente.Add(acc);

                            }

                        }
                        Arriendo arriendox2 = new Arriendo(vehiculo, sucursal, clientex, Inicio, total, FTermi, tarjeta,AccesoriosCliente);


                    }
                    if (dec == "no")
                    {

                        Arriendos.Add(arriendox1);
                    }
                   

                }
                else
                {
                    


                }

            }
            else
            {
                Clientes.Add(clientex);

                Arriendo arriendox1 = new Arriendo(vehiculo, sucursal, clientex, Inicio, total, FTermi, tarjeta);
                if (arriendox1.AutorizacionA() == true)
                {
                    Console.WriteLine("Escriba si, si quiere incluir accesorios,al contrario escriba no");
                    string dec = Console.ReadLine().ToString();
                    if (dec == "si")
                    {
                        List<string> AccesoriosCliente = new List<string>();
                        while (true)
                        {
                            Console.WriteLine("Escriba el accesorio que quiere, si ya termino escriba no");
                            string acc = Console.ReadLine().ToString();
                            if (acc == "no")
                            {
                                break;
                            }
                            else
                            {
                                AccesoriosCliente.Add(acc);

                            }

                        }
                        Arriendo arriendox2 = new Arriendo(vehiculo, sucursal, clientex, Inicio, total, FTermi, tarjeta, AccesoriosCliente);


                    }
                    if (dec == "no")
                    {

                        Arriendos.Add(arriendox1);
                    }


                }
                else
                {

                

                }
            }
            
            



            



            
            

 
        }
    }
}
