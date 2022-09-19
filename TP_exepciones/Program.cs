using System.Security.Cryptography.X509Certificates;
using TP_exepciones;

internal class Program
{
     static void Main(string[] args)
    {
        //Console.WriteLine("Ingrese Numero:");
        //int numero = Convert.ToInt32(Console.ReadLine());


        //MetodoExtension.DividePorCero(numero);

        //try
        //{
        //   Console.WriteLine("Ingrese dividendo: ") ;
        //    int dividendo=Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Ingrese divisor: ");
        //int divisor=Convert.ToInt32(Console.ReadLine());

        //    MetodoExtension.DividendoyDivisor(dividendo, divisor);

        //}
        //catch (FormatException ex)
        //{
        //    Console.WriteLine("Ingrese un numero no una letra...");
        //    Console.WriteLine(ex.Message);
        //}
        //try
        //{
        //    Logic logic = new Logic();
        //    logic.Ejercicio3();
        //}
        //catch (Exception ex) 
        //{

        //    Console.WriteLine("Surgio un error:"+ ex.Message);
        //    Console.ReadKey();
        //}

        try
        {

            throw new Logic();
        }
        catch ( Logic ex)
        {

            Console.WriteLine(ex.Message(ex));
            Console.ReadKey();
        }

    }

    
    





}