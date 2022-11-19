using System;

namespace practica5
{
    internal class Program
    {
        static void Main(string[] args)
        {
         


            int num=0;
            int sum = 0;
            int i;

            Console.WriteLine(" Introduzca 8 numeros: ");
            for (i = 0; i < 8; i++)
            {
                Console.WriteLine("Introduce un numero entero");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine(" El resultado de la suma de los 8 numeros es :  " + sum);
            Console.ReadKey();


        }
    }
}
