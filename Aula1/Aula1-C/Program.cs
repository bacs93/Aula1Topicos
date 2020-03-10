using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Entre com o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nOperação (+  -  *  /)");
            string operacao = Console.ReadLine();

            int resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = a + b;
                    break;

                case "-":
                    resultado = a - b;
                    break;

                case "*":
                    resultado = a * b;
                    break;

                case "/":
                    resultado = a / b;
                    break;

                default:
                    Console.Write("Operação Inválida!");
                    break;
                   
            }

            Console.WriteLine(resultado);
            Console.ReadKey();

        }
    }
}
