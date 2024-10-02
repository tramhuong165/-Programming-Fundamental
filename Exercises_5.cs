using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_of_Programming
{
    internal class Exercises_5
    {
        static void _Main(string[] args)
        {
            //viết chương trình cho user chọn dạng menu
            //Console.Write("Enter the No rows: ");
            //int rows = int.Parse(Console.ReadLine());
            int rows = 0;
            int[][] a = new int[rows][];
            init_random(a,rows);
            print(a);
            Console.WriteLine();
            while (true)
            {
                int cho = menu();
                switch (cho)
                {
                    case 0: Console.WriteLine("Bye bye!");return;
                    case 1: biggest_number(a,rows); break;
                    case 2: sort_rows(a); break;
                    case 3: print_prime(a); break;
                    case 4: print_positions(a); break;
                }
            }
        }
        static int menu()
        {
            Console.WriteLine("1. Print the biggest number of each row and the largest number of the whole array.");
            Console.WriteLine("2. Sort values ascending of each row");
            Console.WriteLine("3. Print items of the array that are prime.");
            Console.WriteLine("4. Search and print all positions of a number (enter from the user).");
            Console.WriteLine("0. Exit");
            Console.WriteLine();
            Console.WriteLine("You need to enter <1..4> to select the task to performed");
            Console.WriteLine("If you have done all task, please enter '0' to Exit");
            int cho = 0;
            while (true)
            {
                bool c = int.TryParse(Console.ReadLine(), out cho);
                if (c && cho >= 0 && cho <= 6)
                    break;
                else Console.WriteLine("Please enter a valid choice!");
            }
            return cho;
        }
        static void init_random(int[][] a, int rows)
        {     
            Random rnd = new Random();
            int row = rnd.Next(3, 10);
            for (int i = 0; i < row; i++)
            {
                //Console.Write($"Enter the No columns of the row {i} th: ");
                //int cols = int.Parse(Console.ReadLine()); 

                a[i] = new int[row];
                for (int j = 0; j < row; j++)
                    a[i][j] = rnd.Next(10, 50);
            }
        }
        static void init_from_user(int[][] a)
        {

        }
        static void print(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                    Console.Write(a[i][j] + " ");
                Console.WriteLine();
            }
        }
        static void biggest_number(int[][] a, int rows )
        {

        }
        static void sort_array(int[] a)
        {
            for(int i = 0;i < a.Length;i++)
                for(int j = 0; j<a.Length;j++)
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
        }
        static void sort_rows(int[][] a)
        {
            for(int i = 0;i < a.Length; i++)
                sort_array(a[i]);
        }
        static bool isPrime(int num)
        {
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
        static void print_prime(int[][] a)
        {
            for (int i = 0; i <= a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                    if (isPrime(a[i][j]))
                    Console.WriteLine($"{a[i][j]} appears at row [{i}], col [{j}]");
            }
        }
        static void positions(int[][] a)
        {

        }     
        static void print_positions(int[][] a)
        {

        }
    }
}

