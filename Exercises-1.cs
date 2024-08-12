using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session02_hnt
{
    internal class Baitap01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers to sum up");
            Console.Write("Enter your first number: ");
            string string_a= Console.ReadLine();
            int a = Convert.ToInt32(string_a);
            Console.Write("Enter your second number: ");
            string string_b = Console.ReadLine();          
            int b = Convert.ToInt32(string_b);
            Console.WriteLine($"Sum: {a+b}");
        }
    }
}
