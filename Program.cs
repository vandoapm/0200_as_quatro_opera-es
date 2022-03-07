using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0200_as_quatro_operações
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Calculo das quatro operações fundamentais +, -, * e /");

            Console.WriteLine();

            Console.Write("Insira o valor 1: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Insira o valor 2: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Valor 1 + Valor 2: ");
            float c = a + b;
            Console.Write(c);
            Console.WriteLine();

            Console.Write("Valor 1 - Valor 2: ");
            float d = a - b;
            Console.Write(d);
            Console.WriteLine();

            Console.Write("Valor 1 * Valor 2: ");
            float e = a * b;
            Console.Write(e);
            Console.WriteLine();

            if (b == 0)
            {

                Console.WriteLine("Você deve respeitar o 11º mandamento *NÃO DIVIDIRÁS POR ZERO* ");

            }
            else
            {

                Console.Write("Valor 1 / Valor 2: ");
                float f = (a / b);
                Console.Write(f);
                Console.WriteLine();

            }

            Console.ReadLine();


        }
    }
}
