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
            Console.WriteLine("Ingrese el nombre de la sucursal:");
            string nombreSuc = Console.ReadLine();

            Sucursal Sucursal = new Sucursal(nombreSuc);
            List<Accesorios> AcceCliente = new List<Accesorios>();
            List<Vehiculo> Vehiculos = new List<Vehiculo>();
            Vehiculo vehiculo1 = new Vehiculo("Auto", 1, "Cherry", 19000);
            Vehiculos.Add(vehiculo1);
            while (true)
            {
                Console.WriteLine("Ingrese 1 si quiere inscribir un vehiculo auto, 2 si es acuatico, 3 si es bus, 4  si es moto, 5 si es camión , 6 si es maquinaria pesada, 0 si terminó: ");
                string nombreVeh = Console.ReadLine();                
                if (nombreVeh == "1")
                {
                    string auto = "Auto";
                    Console.WriteLine("Ingrese 1 si viene con DvD");
                    string opc1 = Console.ReadLine();
                    if (opc1 == "1")
                    {
                        auto = auto.Insert(4,"+DvD+");
                    }
                    Console.WriteLine("Ingrese 1 si es Electrico");
                    string opc2 = Console.ReadLine();
                    if (opc2 == "1")
                    {
                        auto = auto.Insert(4, "+Elec+");
                    }
                    Console.WriteLine("Su marca:");
                    string marca = Console.ReadLine();
                    Console.WriteLine("Su stock:");
                    int stock = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Su precio:");
                    int precio = Convert.ToInt32(Console.ReadLine());
                    Vehiculo vehi = new Vehiculo(auto, stock, marca,precio);
                    Vehiculos.Add(vehi);
                }
                else if (nombreVeh == "2")
                {
                    Console.WriteLine("Su marca:");
                    string marca = Console.ReadLine();
                    Console.WriteLine("Su stock:");
                    int stock = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Su precio:");
                    int precio = Convert.ToInt32(Console.ReadLine());
                    Vehiculo vehi = new Vehiculo("Acuatico", stock, marca,precio);
                    Vehiculos.Add(vehi);
                }
                else if (nombreVeh == "3")
                {
                    Console.WriteLine("Su marca:");
                    string marca = Console.ReadLine();
                    Console.WriteLine("Su stock:");
                    int stock = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Su precio:");
                    int precio = Convert.ToInt32(Console.ReadLine());
                    Vehiculo vehi = new Vehiculo("Bus", stock, marca,precio);
                    Vehiculos.Add(vehi);
                }
                else if (nombreVeh == "4")
                {
                    Console.WriteLine("Su marca:");
                    string marca = Console.ReadLine();
                    Console.WriteLine("Su stock:");
                    int stock = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Su precio:");
                    int precio = Convert.ToInt32(Console.ReadLine());
                    Vehiculo vehi = new Vehiculo("Moto", stock, marca,precio);
                    Vehiculos.Add(vehi);
                }
                else if (nombreVeh == "5")
                {
                    Console.WriteLine("Su marca:");
                    string marca = Console.ReadLine();
                    Console.WriteLine("Su stock:");
                    int stock = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Su precio:");
                    int precio = Convert.ToInt32(Console.ReadLine());
                    Vehiculo vehi = new Vehiculo("Camion", stock, marca,precio);
                    Vehiculos.Add(vehi);
                }
                else if (nombreVeh == "6")
                {
                    Console.WriteLine("Su marca:");
                    string marca = Console.ReadLine();
                    Console.WriteLine("Su stock:");
                    int stock = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Su precio:");
                    int precio = Convert.ToInt32(Console.ReadLine());
                    Vehiculo vehi = new Vehiculo("MaquinariaPesada", stock, marca,precio);
                    Vehiculos.Add(vehi);
                }
                else if (nombreVeh == "0")
                {
                    break;
                }
                else
                {
                    
                }
            }
            List<Accesorios> Accesorios = new List<Accesorios>();
            
            int tii1 = 0;
            int tii2 = 0;
            int tii3 = 0;
            int tii4 = 0;
            int tii5 = 0;
            int tii6 = 0;
            int tii7 = 0;
            while (true)
            {
                
                    
                Console.WriteLine("Ingrese los accesorios:");
                Console.WriteLine("1.- Si es radios con bluetooth");
                Console.WriteLine("2.- Si es GPS");
                Console.WriteLine("3.- Si es ruedas de repuesto");
                Console.WriteLine("4.- Si es cortinas para ventanas");
                Console.WriteLine("5.- Si es sillas para infante");
                Console.WriteLine("6.- Si es corrida de asientos extras");
                Console.WriteLine("7.- Si es maletero mas grande");
                Console.WriteLine("0.- Si ya Terminó");
                string numAcc = Console.ReadLine();
                if (numAcc =="1" && tii1==0 )
                {
                    Accesorios accesorio = new Accesorios("RadioConBluetooth");
                    Accesorios.Add(accesorio);
                    tii1 = 1;
                   
                    
                    
                    
                }
                else if (numAcc == "2" && tii2 == 0)
                {
                    Accesorios accesorio = new Accesorios("GPS");
                    Accesorios.Add(accesorio);
                    tii2 = 1;


                }
                else if (numAcc == "3" && tii3 == 0)
                {
                    Accesorios accesorio = new Accesorios("RuedasDeRepuesto");
                    Accesorios.Add(accesorio);
                    tii3 = 1;
                }
                else if (numAcc == "4" && tii4 == 0) 
                {
                    Accesorios accesorio = new Accesorios("CortinasParaVentanas");
                    Accesorios.Add(accesorio);
                    tii4 = 1;

                }
                else if (numAcc == "5" && tii5 == 0)
                {
                    Accesorios accesorio = new Accesorios("SillasParaInfantes");
                    Accesorios.Add(accesorio);
                    tii5 = 1;


                }
                else if (numAcc == "6" && tii6 == 0)
                {
                    Accesorios accesorio = new Accesorios("CorridasDeAsientos");
                    Accesorios.Add(accesorio);
                    tii6 = 1;


                }
                else if (numAcc == "7" && tii7 == 0)
                {
                    Accesorios accesorio = new Accesorios("MaleterosMasGrandes");
                    Accesorios.Add(accesorio);
                    tii7 = 1;


                }
                else if (numAcc =="0")
                {
                    break;
                }
                

            }

            List<Arriendo> Arriendos = new List<Arriendo>();
            List<Cliente> Clientes = new List<Cliente>();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Buenas.");
            Console.WriteLine("Aprete 0 si es Persona, 1 si es una Empresa, 2 si es una Organización, 3 si es una Institución:");
            string num = Console.ReadLine().ToString();           
            int tipo=Convert.ToInt32(num) ;
          
            Console.WriteLine("Ingrese su Rut:");
            string rut = Console.ReadLine().ToString();
            List<Cliente> clientee = new List<Cliente>();

            if (num == "0")
            {
                Persona clientex = new Persona(rut);
                clientee.Add(clientex);
            }
            else if (num =="1")
            {
                Empresa clientex = new Empresa(rut);
                clientee.Add(clientex);
            }
            else if (num=="2")
            {
                Organizacion clientex = new Organizacion(rut);
                clientee.Add(clientex);
            }
            else if (num=="3")
            {
                Institucion clientex = new Institucion(rut);
                clientee.Add(clientex);
            }
            
            Console.WriteLine("Ingrese 0 si quiere arrendar un auto, 1 si quiere devolver un auto, 2 si quiere salir:");
            string men0 = Console.ReadLine();

            if (men0 == "0")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Ingrese el tipo de vehiculo que quiere devolver:");
                string vehi1 = Console.ReadLine();
                Console.WriteLine("Ingrese la marca del vehiculo:");
                string marca1 = Console.ReadLine();
                foreach (Arriendo ij in Arriendos)
                {
                    if (ij.cliente.Rut == rut && ij.vehiculo.Marca==marca1 && ij.vehiculo.TipoDeVehiculo==vehi1)
                    {
                        ij.vehiculo.Stock++;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("El vehiculo ha sido devuelto exitosamente");

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Upss, al parecer no ha sido encontrado en la base de datos");
                    }
                    
                }
                




            }
            else if (men0 == "1")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Ingrese 1 si quiere arrendar un auto, 2 si es un acuatico, 3 si es un bus, 4 si es una moto, 5 si es un camión , 6 si es una maquinaria pesada");
                int ArriendoVeh = Convert.ToInt32(Console.ReadLine());
               
               
                int igg = 0;
            
                foreach (Vehiculo i in Vehiculos)
                {

                    Console.WriteLine("Inscriba " + igg + " si quiere el vehiculo: " + i.TipoDeVehiculo + ", Marca: " + i.Marca + ", con un precio de: " + i.Precio + "$.");
                    igg++;
                }
                


                if (Vehiculos[ArriendoVeh].Stock > 0)
                {
                    Vehiculos[ArriendoVeh].Stock--;

                }
                Vehiculo vehiculoo = Vehiculos[ArriendoVeh];
                
                Console.WriteLine("Escriba Fecha de Termino");
                Console.WriteLine("Asi: DD/MM/AA");
                string FTermi = Console.ReadLine().ToString();
                DateTime Inicio = new DateTime();
                if (Arriendos.Any(x => x.cliente == clientee[0]) == false)
                {
                    Clientes.Add(clientee[0]);
                }             
                if (clientee[0].LicenciaOAutorizacion(vehiculoo) == true)
                {
                    
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        int iggg = 1;
                        foreach (Accesorios i in Accesorios)
                        {
                            Console.WriteLine("Ingrese:" + iggg + ", si quiere el accesorio: " + i);
                        }
                        Console.WriteLine("Ingrese: 0, si ya Terminó");
                        string numAcc = Console.ReadLine();
                        if (numAcc == "1" )
                        {
                            Accesorios accesorio = new Accesorios("RadioConBluetooth");
                            AcceCliente.Add(accesorio);
                            


                        }
                        else if (numAcc == "2" )
                        {
                            Accesorios accesorio = new Accesorios("GPS");
                            AcceCliente.Add(accesorio);
                            

                        }
                        else if (numAcc == "3")
                        {
                            Accesorios accesorio = new Accesorios("RuedasDeRepuesto");
                            AcceCliente.Add(accesorio);
                            

                        }
                        else if (numAcc == "4" )
                        {
                            Accesorios accesorio = new Accesorios("CortinasParaVentanas");
                            AcceCliente.Add(accesorio);
                            

                        }
                        else if (numAcc == "5" )
                        {
                            Accesorios accesorio = new Accesorios("SillasParaInfantes");

                            AcceCliente.Add(accesorio);
                            


                        }
                        else if (numAcc == "0")
                        {
                            break;
                        }
                        else if (numAcc == "6" && vehiculoo.TipoDeVehiculo=="auto")
                        {
                            Accesorios accesorio = new Accesorios("CorridasDeAsientos");

                            AcceCliente.Add(accesorio);
                        }
                        else if (numAcc == "7" && vehiculoo.TipoDeVehiculo == "auto")
                        {
                            Accesorios accesorio = new Accesorios("MaleterosMasGrandes");

                            AcceCliente.Add(accesorio);
                        }

                    }
                    Arriendo arriendo = new Arriendo(vehiculoo, Sucursal, clientee[0], Inicio, FTermi, AcceCliente);
                    Arriendos.Add(arriendo);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Beep();
                    Console.WriteLine("Felicidades, su arriendo fue un exito.");
                    Console.ReadKey();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep();
                    Console.Beep();
                    Console.WriteLine("Upps, algo salio lam.");
                    Console.ReadKey();
                }

            }
            else if (men0=="2")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Adios");
            }


            
            
            



            



            
            

 
        }
    }
}
