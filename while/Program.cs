using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int loops = 0;
            int x = 0;

            while (i <= 14 )
            {
                
                i++;

                loops++;

                if (i==6)
                {
                    x = 200;
                    Console.WriteLine($"the value of x is now {x}");
                    continue;
                }
                Console.WriteLine($"value of i ={i}");
            }
            Console.WriteLine("\n out off loop ");
            Console.WriteLine($"\n you went thru the loop {loops} times");
            Console.ReadLine();
        }
    }
}
