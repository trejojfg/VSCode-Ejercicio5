using System;

namespace Ejercicio5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite 20 números y luego emitir por pantalla
            // el máximo de los números pares y el mínimo de los números impares.

            int n, max = 0, min = 0;
            bool BPar = false, BImpar = false;

            for (int x = 0; x < 7; x++){
                Console.WriteLine("Introduce un numero: ");
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0){
                    // lado PAR
                    if (BPar == false){
                        max = n;
                        BPar = true;
                    }else{
                        if (n > max){
                            max = n;
                        }
                    }
                    // lado IMPAR
                }else{
                    if (BImpar == false){
                        min = n;
                        BImpar = true;
                    }else{
                        if (n < min){
                            min = n;
                        }
                    }
                }
            }

            Console.WriteLine("El maximo de los pares es " + max);
            Console.WriteLine("El minimo de los impares es " + min);
            Console.WriteLine("Fin del programa");
        }
    }
}
