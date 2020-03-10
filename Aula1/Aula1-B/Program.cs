using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 18)
                Console.WriteLine("Menor de idade");
            else
                Console.WriteLine("Maior de idade");


            Console.WriteLine("O seu nome é: " + nome);
            Console.ReadKey();
        }
    }
}
