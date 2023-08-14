using System;

namespace EjemploDO_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            // DO WHILE -> es un ciclo INEXACTO al igual que el WHILE.
            // pero la diferencia es que siempre va a dar 1 vuelta mínimo antes de cortar:
            // 
                       
            int n, cont = 0;

            do{
                Console.WriteLine("Ingrese un numero:");
                n = int.Parse(Console.ReadLine());
                cont++;        
            } while (n != 0);

            
            Console.WriteLine("Ingresaste: " + cont + " numeros.");

            Console.WriteLine("Fin del programa");
        }
    }
}
