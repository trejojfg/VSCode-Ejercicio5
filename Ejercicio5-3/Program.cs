using System;

namespace Ejercicio5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite 20 edades y 
            // luego calcule el promedio de edad de aquellas personas mayores a 18 años.

            int edad, contEdad = 0, acuEdad = 0, promedio = 0;

            for (int x = 0; x < 20; x++){
                Console.WriteLine("introduce una edad:");
                edad = int.Parse(Console.ReadLine());
                    if (edad > 18){
                        contEdad++;
                        acuEdad += edad;
                    }
            }
            promedio = acuEdad / contEdad;
            Console.WriteLine("El promedio de edad mayores de 18 años es: " + promedio);

            Console.WriteLine("Fin del programa");
        }
    }
}
