using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "y";

            while (input.ToLower() == "y")
            {
                Console.WriteLine("what is your name");
                string name = Console.ReadLine();
                Console.WriteLine("what is your birthday");
                int birthyear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("do you want to continue y/n");
                input = Console.ReadLine();
                Console.Clear();

            }
        }
    }
}
