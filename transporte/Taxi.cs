using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transporte
{
    class Taxi : TransportePublico
    {
        public Taxi() : base()
        {
            this.limite = 3;
        }

        // en un taxi aunque se suba un pasajero ya esta ocupado
        public override bool AgregarPasajero(int pasajeros)
        {
            if (this.pasajeros > 0) return false;       
            if (pasajeros > this.limite) return false;

            this.pasajeros = pasajeros;
            return true;
        }

        public override string ToString()
        {
            return "vehiculo: Taxi, cantidad pasajeros: " 
                + this.pasajeros.ToString();
        }
    }
}
