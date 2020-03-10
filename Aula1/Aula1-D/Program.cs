using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_D
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            for (int z = 0; z < 10; z++)
            {
                Console.WriteLine(z);
            }

            Console.ReadKey();

        }
    }

}