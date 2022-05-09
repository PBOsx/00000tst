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
            int e = 0;
            int aux;
            int[] ord = new int[5];

            ord[0] = int.Parse(Console.ReadLine());
            ord[1] = int.Parse(Console.ReadLine());
            ord[2] = int.Parse(Console.ReadLine());
            ord[3] = int.Parse(Console.ReadLine());
            ord[4] = int.Parse(Console.ReadLine());
            
                    for (i = 0; i < 5; i++)
                    {
                        for (e = 0; e < 5; e++)
                        {
                            if (ord[i] < ord[e])
                            {
                            aux = ord[i];
                            ord[i] = ord[e];
                            ord[e] = aux;
                            }
                        }
                    }
            
            Console.WriteLine("oioi");
            Console.WriteLine(ord[0]);
            Console.WriteLine(ord[1]);
            Console.WriteLine(ord[2]);
            Console.WriteLine(ord[3]);
            Console.WriteLine(ord[4]);
            Console.ReadKey();
            
           }
    } //Só fiz um teste
}
