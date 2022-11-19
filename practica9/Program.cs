
using System;

namespace practica9
{
    class Program
    {
        static void Main(string[] args)
        {

            double num = 1;
            double sum = 0;

            double a = 0;
            do
            {

                Console.WriteLine("Ingresa un numero entero");
                num = double.Parse(Console.ReadLine());
                if (num != 0)
                {
                    sum = sum + num;

                    a = a + 1;
                }

            } while (num != 0);
        

            Console.WriteLine("EL PROMEDIO DE LOS NUMEROS INGRESADOS ES: " + sum / a);







        }
    }
}
