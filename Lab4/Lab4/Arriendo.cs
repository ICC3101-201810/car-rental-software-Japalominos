using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Arriendo
    {
        List<string> ListaAccesorio;
        string vehiculo;
        string sucursal;
        public Cliente cliente;
        DateTime Fecha;
        int Total;
        string FechaDeTermino;
        bool Tarjeta;

        public Arriendo(string vehiculo, string sucursal, Cliente cliente, DateTime Fecha, int Total, string FechaDeTermino,bool Tarjeta)
        {
            this.vehiculo = vehiculo;
            this.sucursal = sucursal;
            this.cliente = cliente;
            this.Fecha = Fecha;
            this.FechaDeTermino = FechaDeTermino;
            this.Total = Total;
            this.Tarjeta = Tarjeta;

        }

        public Arriendo(string vehiculo, string sucursal, Cliente cliente, DateTime Fecha, int Total, string FechaDeTermino,string Tarjeta, List<string> ListaAccesorio)
        {

            this.ListaAccesorio = ListaAccesorio;
            this.vehiculo = vehiculo;
            this.cliente = cliente;
            this.sucursal = sucursal;
            this.Fecha = Fecha;
            this.FechaDeTermino = FechaDeTermino;
            this.Total = Total;

        }
       
    }    
        
}
