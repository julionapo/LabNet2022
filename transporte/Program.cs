using System.Security.Cryptography;
using transporte;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Listado de vehiculos:");

        List<TransportePublico> Lista = new List<TransportePublico>();
        Random r = new Random();
        int cT = 5, cO = 5, n;
        // para evitar el trabajo del profesor, lo hacemos random
        for (int i = 0; i < 10; ++i)
        {
            TransportePublico vehiculo;
            // elegimos al azar cual seria el siguiente vehiculo
            // y lo sacamos de la "pila" de pendientes, 0 es taxis
            // y 1 es colectivos
            n = r.Next(0, 2);
            // chequeamos que todavia queden elementos pendientes
            // si no hay mas Taxis, elegimos Omnibus
            if (cT == 0) n = 1;
            // si no hay mas Omnibus, elegimos Taxis
            if (cO == 0) n = 0;

            if (n == 0)
            {
                cT -= 1;
                vehiculo = new Taxi();
                vehiculo.AgregarPasajero(r.Next(1, 4));
            }
            else
            {
                cO -= 1;
                vehiculo = new Omnibus();
                vehiculo.AgregarPasajero(r.Next(1, 46));
            }
            Lista.Add(vehiculo);
        }

        // Ahora recorro la lista, a pesar de que podia ser
        // mas eficiente e imprimir cuando se lo agrega, no
        // tendria razon de existir la lista, asi que la recorro
        for (int i = 0; i < 10; ++i)
        {
            Console.WriteLine(Lista[i]);
        }


    }
}