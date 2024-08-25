using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_of_Programming
{
    internal class Exercises_2
    {
        static void Main(string[] args)
        {
            Baitap2_1();
            Baitap2_2();
            //Baitap2_3();
            //Baitap2_4();
            //Baitap2_5();
            //Baitap2_6();
            //Baitap2_7();
            //Baitap2_8();
            //Baitap2_9();
            //Baitap2_10();
        }
        static void Baitap2_1()
        {
            Console.WriteLine("Input a string and print it");
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine(str);
        }
        static void Baitap2_2()
        {
            Console.WriteLine("Find the length of a string without using a library function");
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            int str_len = str.Length;
            Console.WriteLine($"Length of the string is: {str_len}");
        }
        static void Baitap2_3()
        {
            Console.WriteLine("separate individual characters from a string");
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
            //foreach (char c in str)
            //{
            //    Console.Write(c + " ");
            //}
        }
        static void Baitap2_4()
        {
            Console.WriteLine("Individual characters of the string in reverse order");
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write($"{str[i]} ");
            }
        }
        static void Baitap2_5()
        {
            Console.WriteLine("Count the total number of words in a string ");
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            //dùng Ling
            string[] words = str.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;
            Console.WriteLine($"The total number of words in the string: {wordCount}");
            //duyệt từng ký tự trong chuõi
            /*
             int wordCount = 0;
            bool inword = false;
            foreach (char c in str)
            {
                if (char.iswhitespace(c))
                {
                    if (inword) //inword == false
                    {
                        wordcount++;
                        inword = false;
                    }
                }
                else
                {
                    inword = true;
                }
            }
            if (inword)
            {
                wordcount++;
            }
            console.writeline($"the total number of words in the string: {wordcount}"); 
            */
        }
        static void Baitap2_6()
        {
            Console.WriteLine("Compare two strings without using a string library functions");
            // kiểm tra độ dài hai chuỗi => duyệt từng ký tự
            Console.Write("Enter the 1st string: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter the 2nd string: ");
            string str2 = Console.ReadLine();
            bool compare = true;
            if (str1.Length != str2.Length)
            {
                compare = false;
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        compare = false;
                        break;
                    }
                }
            }
            if (compare)
            {
                Console.WriteLine("The strings are equal");
            }
            else
            {
                Console.WriteLine("The strings are not equal");
            }
        }
        static void Baitap2_7()
        {
            Console.WriteLine("Count the number of alphabets, digits and special characters in a string.");
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            int alphaCount = 0;
            int digitCount = 0;
            int speCharCount = 0;
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    alphaCount++;
                }
                else if (char.IsDigit(c))
                {
                    digitCount++;
                }
                else
                {
                    speCharCount++;
                }
            }
            Console.WriteLine($"The number of Alphabets: {alphaCount}");
            Console.WriteLine($" The number of Digits: {digitCount}");
            Console.WriteLine($"The number of Special character: {speCharCount}");
        }
        static void Baitap2_8()
        {
            Console.WriteLine("Copy one string to another string");
            Console.WriteLine("Enter a string: ");
            string str1 = Console.ReadLine();
            string str2 = str1;
            int num_str = str1.Length;
            Console.WriteLine($"The 1st String: {str1}");
            Console.WriteLine($"The 2nd String: {str2}");
            Console.WriteLine($"Number of characters copied: {num_str}");
        }
        static void Baitap2_9()
        {
            Console.WriteLine("Count the number of vowels or consonants in a string");
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            int vowelCount = 0;
            int consonantCount = 0;
            // chuyển sang chữ lower hết cho dễ so sánh
            string lower_str = str.ToLower();
            char[] vowels = { 'a', 'e', 'u', 'i', 'o' };
            foreach (char c in lower_str)
            {
                if (char.IsLetter(c))
                {
                    if (Array.Exists(vowels, vowel => vowel == c))
                    // <parameter> => <expression> là <biểu thức hoặc phép toán để kiểm tra từng ptu đại diện của mảng>
                    // <tên mảng chứa ký tự cần kiểm tra>, <ĐK kiểm tra> 
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }
            Console.WriteLine($"The number of vowels: {vowelCount}");
            Console.WriteLine($"The number of consonants:{consonantCount}");
        }
        static void Baitap2_10()
        {
            Console.WriteLine("Find the maximum number of characters in a string");
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            string lower_str = str.ToLower();
            //dùng mảng hoặc tạo từ điển để lưu

            int[] freq = new int[256];
            //tạo mảng int có 256 phần tử để lưu trữ tần suất của các ký tự ASCII
            foreach (Char c in lower_str)
            {
                freq[(int)c]++; //(int)c => chuyển ký tự sang mã ascii
            }
            char maxChar = '\0';
            int maxCount = 0;
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] > maxCount)
                {
                    maxCount = freq[i];
                    maxChar = (char)i;
                }
            }
            Console.WriteLine($"The highest frequency of character '{maxChar}' ");
            Console.WriteLine($"appears number of times: {maxCount}");
        }
        static void Baitap2_11()
        {
            Console.WriteLine("Sort a string array in ascending order");
        }
    }
}
