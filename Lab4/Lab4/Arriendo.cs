using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Arriendo
    {
        List<Accesorio> ListaAccesorio;
        Vehiculo vehiculo;
        Sucursal sucursal;
        Cliente cliente;
        DateTime Fecha;
        int Total;
        string FechaDeTermino;


        public Arriendo(Vehiculo MiVehiculo, Sucursal Misucursal, Cliente MiCliente, List<Accesorio> MiListaAccesorio,DateTime MiFecha,string Termino,int MiTotal)
        {
            ListaAccesorio = MiListaAccesorio;
            vehiculo = MiVehiculo;
            cliente = MiCliente;
            sucursal = Misucursal;
        }
    }
}
