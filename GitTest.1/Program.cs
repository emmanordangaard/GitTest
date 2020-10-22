using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("2^{0} = {1}", i, Math.Pow(2,i));
            }
            Console.ReadKey();
        }
    }
}
