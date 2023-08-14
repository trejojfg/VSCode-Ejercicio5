using System;

namespace Ejercicio5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite el ingreso de 10 números y 
            // que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

            int n, max = 0, pos = 0;

            for (int x = 0; x < 5; x++){
                Console.WriteLine("Introduce un numero:");
                n = int.Parse(Console.ReadLine());
                // este if es para inicializar el max en n, ya que el max = 0 solo sirve para que no de error de lectura
                if (x == 0){
                    max = n;
                }else{
                    if (n > max){
                        max = n;
                        pos = x+1;
                    }
                }
            }

            Console.WriteLine("El mayor de los numeros es: " + max);
            Console.WriteLine("Esta en la posicion: " + pos);

            Console.WriteLine("Fin del programa");
        }
    }
}
