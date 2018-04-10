using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public enum accesorio {RadioConBluetooth,GPS,RuedasDeRepuesto,CortinasParaVentanas,SillasParaInfantes}
    public class Accesorio
    {
        public accesorio MAccesorio;

        public Accesorio(accesorio MiAccesorio)
        {
            MAccesorio = MiAccesorio;
        } 



    }
}
