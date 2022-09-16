using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transporte
{
    abstract class TransportePublico
    {
        protected int pasajeros { get; set; }
        protected int limite { get; set; }
        private bool enMovimiento { get; set; }

        // Constructor
        public TransportePublico()
        {
            this.pasajeros = 0;
        }

        public void Avanzar()
        {
            this.enMovimiento = true;
        }

        public void Detenerse()
        {
            this.enMovimiento = false;
        }

        public void MostrarActidad()
        {
            if (this.enMovimiento)
                Console.WriteLine("El vehiculo esta en movimiento");
            else
                Console.WriteLine("El vehiculo esta en reposo");
        }

        public int CantidadPasajeros()
        {
            return this.pasajeros;
        }

        // Como se llena el vehiculo es una propiedad propia de
        // cada clase, es por eso que el resto de atributos y
        // metodos son iguales 
        public abstract bool AgregarPasajero(int pasajeros);
    }
}
