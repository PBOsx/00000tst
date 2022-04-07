using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int aux;
            int[] ord = new int[5];

            ord[0] = int.Parse(Console.ReadLine());
            ord[1] = int.Parse(Console.ReadLine());
            ord[2] = int.Parse(Console.ReadLine());
            ord[3] = int.Parse(Console.ReadLine());
            ord[4] = int.Parse(Console.ReadLine());

            do
            {
                for (i = 0; i < 4; i++)
                {
                    if (ord[i] < ord[i + 1])
                    {
                        aux = ord[i];
                        ord[i] = ord[i + 1];
                        ord[i + 1] = aux;
                    }
                    else
                    {
                        aux = ord[i + 1];
                        ord[i + 1] = ord[i];
                        ord[i] = aux;
                    }
                }
            } while (ord[0] != 1);

            Console.WriteLine(ord[0]);
            Console.WriteLine(ord[1]);
            Console.WriteLine(ord[2]);
            Console.WriteLine(ord[3]);
            Console.WriteLine(ord[4]);
            Console.ReadKey();
            
           }
    }
}
