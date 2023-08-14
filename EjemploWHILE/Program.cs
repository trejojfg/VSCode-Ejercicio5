using System;

namespace EjemploWHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            // WHILE -> es un ciclo INEXACTO.
            // es muy parecido al FOR y se pueden solicitar tambien un numero de registros exacto:
            // 
            // int cont = 0;
            // while (cont < 10){
            //     cont++;
            //     Console.WriteLine( cont );
            // }


            // y para cargar registros hasta que alguien pare, lo más habitual es poner la condicion de
            // ingresar un 0 ó un '.'  :
            
            int n, cont = 0;

            Console.WriteLine("Ingrese un numero:");
            n = int.Parse(Console.ReadLine());

            while (n != 0){
                cont++;
                Console.WriteLine("Ingrese un numero:");
                n = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Ingresaste: " + cont + " numeros.");

            Console.WriteLine("Fin del programa");
        }
    }
}
