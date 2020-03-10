using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis
            String nome = "Bruno ";
            String sobrenome = "Sousa";
            bool isValid = true;

            string nomeCompleto = nome + sobrenome;

            Console.WriteLine(nomeCompleto);

            //connverter dados
            string valor1 = "1";
            int v1 = Convert.ToInt32(valor1);
            int v2 = int.Parse(valor1);

            //concaternar variaveis

            


            Console.ReadKey();
        }
    }
}
