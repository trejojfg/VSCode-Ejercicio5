using System;

namespace Ejercicio5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para mostrar los números del 1 al 10. 
            // No se debe realizar ningún pedido de datos.
            

            for (int x = 0; x < 10; x++){
                Console.WriteLine( x + 1 );
            }

            //  se puede hacer con WHILE usando un contador:
            //  int cont = 0;
            //  while (cont < 10){
            //      Console.WriteLine((cont + 1));
            //      cont++;
            //  }


            Console.WriteLine("Fin del programa");
        }
    }
}
