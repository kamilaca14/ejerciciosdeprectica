
using System;

namespace practica6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 0;
            int sum = 0;


            do
            {

                Console.WriteLine("Dijite un numero entero");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;


            } while (num != 0);


            Console.WriteLine("  El resultado de la suma de los numeros es  :  " + sum);




        }
    }
}
