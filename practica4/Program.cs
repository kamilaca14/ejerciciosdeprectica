using System;

namespace practica4
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor = 0;
            int adicion = 0;

            do
            {
                Console.WriteLine("Ingrese un  valor : ");


                valor = int.Parse(Console.ReadLine());


                adicion = adicion + valor;


            } while (valor != 0);


            Console.WriteLine("El resultado de la suma es : " + adicion);


            Console.ReadKey();




        }

    }
}

