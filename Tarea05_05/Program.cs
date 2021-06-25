using System;

namespace Tarea05_05
{
    class Program
    {
        static String decToBin(int num)
        {
            String binario = "";
            //int numero = num;
            if (num > 0)
            {
                while (num > 0)
                {
                    if (num%2 == 0)
                    {
                        binario = "0" + binario;
                    }else
                    {
                        binario = "1" + binario;
                    }
                    num = (int)num / 2;
                }
            }
            else
            {
                binario = "0";
            }

            return binario;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero ");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero >= 0)
            {
            String binario = decToBin(numero);
            Console.WriteLine("El número decimal {0} en binario es: {1}", numero, binario);
            Console.ReadKey();
            }
            else
            {
                Console.WriteLine("ERROR: Debe introducir un número entero positivo.");

            }


        }
    }
}
