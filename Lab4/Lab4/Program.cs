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
            while (true)
            {
                Console.WriteLine("Ingrese 1 si quiere inscribir un vehiculo auto, 2 si es acuatico, 3 si es bus, 4  si es moto, 5 si es camión , 6 si es maquinaria pesada, 0 si terminó: ");
                string nombreVeh = Console.ReadLine();                
                if (nombreVeh == "1")
                {
                    Console.WriteLine("Su marca:");
                    string marca = Console.ReadLine();
                    Console.WriteLine("Su stock:");
                    int stock = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Su precio:");
                    int precio = Convert.ToInt32(Console.ReadLine());
                    Vehiculo vehi = new Vehiculo("Auto", stock, marca,precio);
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
            int[] repe =new int[] {0,0,0,0,0};
            while (true)
            {
                Console.WriteLine("Ingrese los accesorios:");
                Console.WriteLine("1.- Si es radios con bluetooth");
                Console.WriteLine("2.- Si es GPS");
                Console.WriteLine("3.- Si es ruedas de repuesto");
                Console.WriteLine("4.- Si es cortinas para ventanas");
                Console.WriteLine("5.- Si es sillas para infante");
                Console.WriteLine("0.- Si ya Terminó");
                string numAcc = Console.ReadLine();
                if (numAcc =="1")
                {
                    Accesorios accesorio = new Accesorios("RadioConBluetooth");
                    Accesorios.Add(accesorio);
                    repe[0]= 1 ;
                    Console.WriteLine("ola");
                    
                    
                }
                else if (numAcc == "2" && repe[0] == 0)
                {
                    Accesorios accesorio = new Accesorios("GPS");
                    Accesorios.Add(accesorio);
                    repe[1] = 2;
                
                }
                else if (numAcc == "3" && repe[0] == 0)
                {
                    Accesorios accesorio = new Accesorios("RuedasDeRepuesto");
                    Accesorios.Add(accesorio);
                    repe[2] = 3;
                   
                }
                else if (numAcc == "4" && repe[0] == 0)
                {
                    Accesorios accesorio = new Accesorios("CortinasParaVentanas");
                    Accesorios.Add(accesorio);
                    repe[3] = 4;
                    
                }
                else if (numAcc == "5" && repe[0] == 0)
                {
                    Accesorios accesorio = new Accesorios("SillasParaInfantes");

                    Accesorios.Add(accesorio);
                    repe[4] = 5;
                    

                }
                else if (numAcc =="0")
                {
                    break;
                }
                else
                {
                  
                    
                }

            }

            List<Arriendo> Arriendos = new List<Arriendo>();
            List<Cliente> Clientes = new List<Cliente>();
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
            
            
            
            Console.WriteLine("Que vehiculo quiere arrendar:");
            int igg = 0;
            foreach( Vehiculo i in Vehiculos)
            {
                Console.WriteLine("Inscriba "+igg+" si quiere el vehiculo: "+i.TipoDeVehiculo+", Marca: "+i.Marca+", con un precio de: "+i.Precio+"$." );
                igg++;
            }
            int ArriendoVeh=Convert.ToInt32(Console.ReadLine());
       
            
            if (Vehiculos[ArriendoVeh].Stock>0)
            {
                Vehiculos[ArriendoVeh].Stock--;

            }
            Vehiculo vehiculoo = Vehiculos[ArriendoVeh];
            
            Console.WriteLine("Escriba Fecha de Termino");
            Console.WriteLine("Asi: DD/MM/AA");
            string FTermi = Console.ReadLine().ToString();
            DateTime Inicio = new DateTime();
            if (Arriendos.Any(x => x.cliente == clientee[0]) == true)
            {

            }
            else
            {
                Clientes.Add(clientee[0]);

            }
            if (clientee[0].LicenciaOAutorizacion(vehiculoo) == true)
            {
                int[] repet = new int[] { 0, 0, 0, 0, 0 };
                while (true)
                {
                    int iggg = 1;
                    foreach (Accesorios i in Accesorios)
                    {
                        Console.WriteLine("Ingrese:" + iggg + ", si quiere el accesorio: " + i);
                    }
                    Console.WriteLine("Ingrese: 0, si ya Terminó");
                    string numAcc = Console.ReadLine();
                    if (numAcc == "1" && repet[0] == 0)
                    {
                        Accesorios accesorio = new Accesorios("RadioConBluetooth");
                        AcceCliente.Add(accesorio);
                        repe[0] = 1;


                    }
                    else if (numAcc == "2" && repe[0] == 0)
                    {
                        Accesorios accesorio = new Accesorios("GPS");
                        AcceCliente.Add(accesorio);
                        repe[1] = 2;

                    }
                    else if (numAcc == "3" && repe[0] == 0)
                    {
                        Accesorios accesorio = new Accesorios("RuedasDeRepuesto");
                        AcceCliente.Add(accesorio);
                        repe[2] = 3;

                    }
                    else if (numAcc == "4" && repe[0] == 0)
                    {
                        Accesorios accesorio = new Accesorios("CortinasParaVentanas");
                        AcceCliente.Add(accesorio);
                        repe[3] = 4;

                    }
                    else if (numAcc == "5" && repe[0] == 0)
                    {
                        Accesorios accesorio = new Accesorios("SillasParaInfantes");

                        AcceCliente.Add(accesorio);
                        repe[4] = 5;


                    }
                    else if (numAcc == "0")
                    {
                        break;
                    }
                    else
                    {
                       

                    }
                }
                Arriendo arriendo = new Arriendo(vehiculoo,Sucursal,clientee[0],Inicio,FTermi,AcceCliente);
                Arriendos.Add(arriendo);
                Console.WriteLine("Felicidades, su arriendo fue un exito.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Upps, algo salio lam.");
                Console.ReadKey();
            }
            
            



            



            
            

 
        }
    }
}
