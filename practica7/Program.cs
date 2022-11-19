using System;

namespace practica7
{
    class Program
    {
        static void Main(string[] args)
        {


            int variable1;
            int variable2;
            int variable3;

            char respuesta;

            do
            {
                Console.WriteLine("Ingrese el primer lado");
                variable1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nIngrese el segundo lado");
                variable2 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nIngrese el tercer lado");
                variable3 = int.Parse(Console.ReadLine());
                Console.WriteLine("\n\n\n");


                if ((variable1 + variable2 > variable3) && (variable1 + variable3 > variable2) && (variable2 + variable3) > variable1)
                {

                    if (variable1 == variable2 && variable1 == variable3) Console.WriteLine("Equilátero");

                    else

                    if (variable1 == variable2 || variable1 == variable3 || variable2 == variable3) Console.WriteLine("Isósceles");

                    else Console.WriteLine("Escaleno");
                }
                else

                    Console.WriteLine("Esos números no forman un triángulo");

                Console.WriteLine("\n¿Desea continuar (S/N)?)");

                respuesta = (Console.ReadLine()[0]);



            } while (respuesta != 'N' && respuesta != 'n');
        }
    }
}


