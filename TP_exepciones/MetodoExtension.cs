using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_exepciones
{
    public static class MetodoExtension
    {
        public static void DividePorCero(this int numero)
        {
            try
            {

                int resultado = numero / 0;
                Console.WriteLine(resultado);
               
               
               
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Intendo dividir por 0 ");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Termino la operacion");
            }


        }
        public static void DividendoyDivisor(this int dividendo ,int divisor )
        {
            try
            {
                int resultado = dividendo / divisor;
                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Solo Emilio puede dividir por 0...:) ");
                Console.WriteLine(ex.Message);
            }
            
            catch(Exception ex)
            {
                Console.WriteLine("UY la cagaste...."+ex.Message);
            }
        }
    }
}
