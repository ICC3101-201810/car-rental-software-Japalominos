using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Arriendo
    {
        List<Accesorios> ListaAccesorio;
        Vehiculo vehiculo;
        Sucursal sucursal;
        public Cliente cliente;
        DateTime Fecha;
        string FechaDeTermino;

        

        public Arriendo(Vehiculo vehiculo, Sucursal sucursal, Cliente cliente, DateTime Fecha, string FechaDeTermino, List<Accesorios> ListaAccesorio)
        {

            this.ListaAccesorio = ListaAccesorio;
            this.vehiculo = vehiculo;
            this.cliente = cliente;
            this.sucursal = sucursal;
            this.Fecha = Fecha;
            this.FechaDeTermino = FechaDeTermino;


        }
       
    }    
        
}
