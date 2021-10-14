using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whilecomplex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "y";
            decimal price;
            decimal sum = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            while (input.ToLower() == "y")
            {
                Console.WriteLine("give the name of an artical");
                string artical = Console.ReadLine();

                Console.WriteLine("input the price of the artical");
                price =decimal.Parse(Console.ReadLine());
                sum = sum + price; // sum += price; is het zelfde
                Console.WriteLine("do you want to add more articals y/n");
                input = Console.ReadLine();

                if (input.ToLower() != "y")
                {
                    Console.Clear();
                    Console.WriteLine($"the sum of all the articals is {sum :c}");
                }
                else
                {
                    Console.Clear();
                }
                Console.ReadLine();
            }
        }
    }
}
