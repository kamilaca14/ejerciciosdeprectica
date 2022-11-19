using System;

namespace practica10
{
    class Program
    {
        static void Main(string[] args)
        {


            int A;
            double factorial = 1;

            Console.WriteLine("INGRESE UN NUMERO ENTERO POR TECLADO: ");
            A = int.Parse(Console.ReadLine());
            while (A > 1) factorial *= A--;
            Console.WriteLine("EL FACTORIAL ES  = : " + factorial);

        }

    }
}

