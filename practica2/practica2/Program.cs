using System;

namespace practica2
{
    internal class Practica
    {
        static void Main(string[] args)
        {
            int Par;

            Console.WriteLine("Inserte un número");

            Par = int.Parse(Console.ReadLine());

            if (Par % 2 == 0)
            {

                Console.WriteLine("El número " + Par + " es par");
            }
            else
                Console.WriteLine("El número " + Par + " es impar");


        }
    }
}

