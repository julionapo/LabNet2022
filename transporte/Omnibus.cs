using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transporte
{
    class Omnibus : TransportePublico
    {
        public Omnibus() : base()
        {
            this.limite = 45;
        }

        // el colectivo se puede llenar mientras haya capacidad
        public override bool AgregarPasajero(int pasajeros)
        {
            if(pasajeros > this.limite) return false;
            if(this.pasajeros + pasajeros > this.limite) return false;
            this.pasajeros += pasajeros;
            return true;
        }

        public override string ToString()
        {
            return "vehiculo: Omnibus, cantidad pasajeros: "
                + this.pasajeros.ToString();
        }
    }
}
