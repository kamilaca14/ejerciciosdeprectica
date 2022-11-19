
using System;

namespace practica1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 1 
            
            int num1, num2;
Console.WriteLine("Inserte el 1er número");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Inserte el 2do número");
num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{

    Console.WriteLine("El 1er número es el mayor");

}
else


if (num2 > num1)
{
    Console.WriteLine("El 2do número es el mayor");

}
			

		}
    }
}
