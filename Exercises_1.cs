using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Exercise_1
    {
        static void Main(string[] args)
        {
            Baitap01();
            Baitap02();
            Baitap03();
            Baitap04();
            Baitap05();
            Baitap06();
            Baitap07();
            Baitap08();
            Baitap09();
            Baitap10();
        }
        static void Baitap01()
        {
            Console.WriteLine("Enter two number to sum up");
            Console.Write("Enter 1st number: ");
            int number1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            int number2 = Convert.ToInt16(Console.ReadLine());
            int sum = number1 + number2;
            Console.WriteLine($"SUM: {number1} + {number2} = {sum}");
        }

        static void Baitap02()
        {
            Console.WriteLine("Swap Value of Two Variable");
            Console.Write("Enter 1st number: ");
            int number1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            int number2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"BEFORE SWAP: 1st number is {number1} and 2nd number is {number2}");
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine($"AFTER SWAP: 1st number is {number1} and 2nd number is {number2}");
        }
        static void Baitap03()
        {
            Console.WriteLine("Multiply two Floating Point Number");
            Console.Write("Enter 1st number: ");
            float number1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            float number2 = Convert.ToSingle(Console.ReadLine());
            double multiply = number1 * number2;
            Console.WriteLine($"MULTIPLY: {number1} * {number2} = {multiply}");
        }
        static void Baitap04()
        {
            Console.Write("Enter a number to convert from feet to meter: ");
            float numberft = Convert.ToSingle(Console.ReadLine());
            double numberm = numberft * 0.3048000;
            Console.WriteLine($"CONVERT: {numberft} ft = {numberm} m");
        }
        static void Baitap05()
        {
            Console.Write("Enter a number to convert from Celsius to Fahrenhelt: ");
            float c1 = Convert.ToSingle(Console.ReadLine());
            float f1 = (9 / 5 * c1) + 32;
            Console.WriteLine($"{c1} °C = {f1} °F");
            Console.Write("Enter a number to convert form Fahrenhelt to Celsius: ");
            float f2 = Convert.ToSingle(Console.ReadLine());
            float c2 = (f2 - 32) * 5 / 9;
            Console.WriteLine($"{f2} °F = {c2} °C");
        }
        static void Baitap06()
        {
            Console.WriteLine(" Find the Size of data types: ");
            Console.WriteLine($"sizeof(bool)     :  {sizeof(bool)}");
            Console.WriteLine($"sizeof(byte)     :  {sizeof(byte)}");
            Console.WriteLine($"sizeof(sbyte)    :  {sizeof(sbyte)}");
            Console.WriteLine($"sizeof(char)     :  {sizeof(char)}");
            Console.WriteLine($"sizeof(short)    :  {sizeof(short)}");
            Console.WriteLine($"sizeof(ushort)   :  {sizeof(ushort)}");
            Console.WriteLine($"sizeof(float)    :  {sizeof(float)}");
            Console.WriteLine($"sizeof(int)      :  {sizeof(int)}");
            Console.WriteLine($"sizeof(double)   :  {sizeof(double)}");
        }
        static void Baitap07()
        {
            Console.WriteLine("Print ASCII Value");
            Console.Write("Enter character: ");
            char c_value = Convert.ToChar(Console.ReadLine());
            int value = (int)c_value;
            Console.WriteLine($"{c_value} in ASCII Value is: {value} ");
        }
        static void Baitap08()
        {
            Console.WriteLine("Calculate Area of Circle");
            Console.Write("Enter the radius: ");
            int r = Convert.ToInt16(Console.ReadLine());
            double a = r * r * 3.14;
            Console.WriteLine($"Area of Circle: {a}");
        }
        static void Baitap09()
        {
            Console.WriteLine("Calculate Area of Square");
            Console.Write("Enter the size: ");
            int size = Convert.ToInt16(Console.ReadLine());
            double a = size * size;
            Console.WriteLine($"Area of Square: {a} ");
        }
        static void Baitap10()
        {
            Console.WriteLine("Convert Days to Years, Weeks, Days");
            Console.Write("Enter the Days: ");
            int number_days = Convert.ToInt16(Console.ReadLine());
            int year = number_days / 365;
            int week = (number_days % 365) / 7;
            int day = (number_days % 365) % 7;
            Console.WriteLine($"{number_days} days = {year} years, {week} weeks, {day} days");
        }
    }
}