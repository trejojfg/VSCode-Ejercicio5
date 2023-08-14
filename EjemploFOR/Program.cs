using System;

namespace EjemploFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            // FOR -> es un ciclo EXACTO,
            // 
            // Ejemplo de un for para mostrar n veces un mensaje: 
            // int N = 5;
            // for (int x = 0; x < N; x++){
            //    Console.WriteLine( (x + 1) + " - Hola que tal mundillo!!!!!!!!!!");
            // }

            int n = 0, promedio, suma = 0;

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese una nota: ");
                n = int.Parse(Console.ReadLine());
                suma += n;
            }

            promedio = suma / 5;
            Console.WriteLine("El promedio de notas es: " + promedio);
            

            Console.WriteLine("Fin del ejemplo");
        }
    }
}
