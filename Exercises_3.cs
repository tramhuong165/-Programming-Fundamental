using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_of_Programming
{
    internal class Exercises_3
    {
        static void Main(string[] args)
        {
            Baitap3_1();
            Baitap3_2();
            Baitap3_3();
            Baitap3_4();
            Baitap3_5();
            Baitap3_7();
            Baitap3_8();
            Baitap3_9();
            Baitap3_10();
        }
        static void Baitap3_1()
        {
            Console.WriteLine("Check whether a given number is even or nodd");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
            Console.ReadLine();
        }
        static void Baitap3_2()
        {
            Console.WriteLine("Find the largest of three numbers");
            Console.Write("Enter 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int max = num1;
            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }
            Console.WriteLine($"The largest number is: {max}");
            Console.ReadLine();
        }
        static void Baitap3_3()
        {
            Console.WriteLine("Determine the quadrant of a coordinate point.");
            Console.Write("Enter the X coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Y coordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());

            string quadrant = (x > 0 && y > 0) ? "First quadrant" :
                               (x < 0 && y > 0) ? "Second quadrant" :
                               (x < 0 && y < 0) ? "Third quadrant" :
                               (x > 0 && y < 0) ? "Fourth quadrant" :
                               (x == 0 && y != 0) ? "Y-axis" :
                               (y == 0 && x != 0) ? "X-axis" :
                               "Origin";

            Console.WriteLine($"The point is in the {quadrant}.");
            Console.ReadLine();
        }
        static void Baitap3_4()
        {
            Console.WriteLine("Check whether a triangle is Equilateral, Isosceles or Scalene.");
            Console.Write("Enter the length of side 1: ");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the length of side 2: ");
            int side2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the length of side 3: ");
            int side3 = Convert.ToInt32(Console.ReadLine());

            string triangleType = (side1 == side2 && side2 == side3) ? "Equilateral" :
                                  (side1 == side2 || side2 == side3 || side1 == side3) ? "Isosceles" : "Scalene";

            Console.WriteLine($"The triangle is {triangleType}.");
            Console.ReadLine();
        }
        static void Baitap3_5()
        {
            Console.WriteLine("Read 10 numbers and find their average and sum");
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Enter number {i}: ");
                sum += Convert.ToInt32(Console.ReadLine());
            }
            double average = sum / 10.0;

            Console.WriteLine($"The sum of the 10 numbers is: {sum}");
            Console.WriteLine($"The average of the 10 numbers is: {average}");
            Console.ReadLine();
        }
        static void Baitap3_6()
        {
            Console.WriteLine("Display the multiplication table of a given integer.");
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiplication table of {number}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
            Console.ReadLine();
        }
        static void Baitap3_7()
        {
            Console.WriteLine("Display a pattern like triangles with a number");
            Console.Write("Enter the number of rows for the triangle: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void Baitap3_8()
        {
            Console.WriteLine("Display the n terms of harmonic series and their sum");
            Console.Write("Enter the number of terms: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0.0;
            Console.Write("Harmonic Series: ");
            for (int i = 1; i <= n; i++)
            {
                double term = 1.0 / i;
                Console.Write($"{term} ");
                sum += term;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum of the series: {sum}");
            Console.ReadLine();
        }
        static void Baitap3_9()
        {
            Console.WriteLine("Find the ‘perfect’ numbers within a given number range");
            Console.Write("Enter the lower bound of the range: ");
            int lower = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the upper bound of the range: ");
            int upper = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Perfect numbers between {lower} and {upper}:");

            for (int num = lower; num <= upper; num++)
            {
                int sum = 0;
                for (int i = 1; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == num && num != 0)
                {
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine($"There no'perfect' numbers between {lower} and {upper}:");
                };
            }
            Console.ReadLine();
        }
        static void Baitap3_10()
        {
            Console.WriteLine("Check a number if it is prime");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 1)
            {
                Console.WriteLine($"{number} is not a prime number.");
                return;
            }

            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
            Console.ReadLine();
        }
    }
}

