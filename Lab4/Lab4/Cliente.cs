using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class Cliente
    {
        public enum clientes { Persona,Empresa,Organizacion,Institucion};
        public enum tarjeta {LicenciaDeConducir,Autorizacion}

        public clientes TipoCliente;

        public tarjeta Tarjeta;

        public Cliente( clientes MiTipoCliente, tarjeta MiTarjeta)
        {
            TipoCliente = MiTipoCliente;
            Tarjeta = MiTarjeta;
            
            
        }

        public abstract Boolean AutorizacionA();
    }
    class Persona : Cliente
    {
        
        public new Boolean AutorizacionA()
        {
            if (TipoCliente == clientes.Persona && Tarjeta==tarjeta.LicenciaDeConducir)

            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
   
    }
    class Empresa : Cliente
    {
        public new Boolean AutorizacionA()
        {
            if (TipoCliente == clientes.Empresa && Tarjeta == tarjeta.Autorizacion)

            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Organizacion : Cliente
    {
   
        
        public new Boolean AutorizacionA()
        {
            if (TipoCliente == clientes.Organizacion && Tarjeta == tarjeta.Autorizacion)

            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Institucion : Cliente
    {
        public new Boolean AutorizacionA()
        {
            if (TipoCliente == clientes.Institucion && Tarjeta == tarjeta.Autorizacion)

            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}



    
