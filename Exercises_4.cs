using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_of_Programming
{
    internal class Exercises_4
    {
        static void _Main()
        {
            int[] arr = GenerateRandomArray(10, 1, 100);

            Console.WriteLine("Initial array: ");
            PrintArray(arr);

            double average = CalculateAverage(arr);
            Console.WriteLine("Average value: " + average);

            int searchValue = 50;
            bool containsValue = ContainsValue(arr, searchValue);
            Console.WriteLine("Array contains " + searchValue + ": " + containsValue);

            int index = FindIndex(arr, searchValue);
            Console.WriteLine("Index of " + searchValue + ": " + (index == -1 ? "Not found" : index.ToString()));

            arr = RemoveElement(arr, searchValue);
            Console.WriteLine("Array after removing " + searchValue + ": ");
            PrintArray(arr);

            int maxValue = FindMaxValue(arr);
            int minValue = FindMinValue(arr);
            Console.WriteLine("Max value: " + maxValue);
            Console.WriteLine("Min value: " + minValue);

            arr = ReverseArray(arr);
            Console.WriteLine("Array after reversing: ");
            PrintArray(arr);

            int[] duplicates = FindDuplicates(arr);
            Console.WriteLine("Duplicate values: ");
            PrintArray(duplicates);

            arr = RemoveDuplicates(arr);
            Console.WriteLine("Array after removing duplicates: ");
            PrintArray(arr);
        }

        static int[] GenerateRandomArray(int length, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = random.Next(minValue, maxValue);
            }
            return arr;
        }

        static void PrintArray(int[] arr)
        {
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }

        static double CalculateAverage(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }

        static bool ContainsValue(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        static int FindIndex(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        static int[] RemoveElement(int[] arr, int value)
        {
            int newLength = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != value)
                {
                    newLength++;
                }
            }

            int[] newArr = new int[newLength];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != value)
                {
                    newArr[j] = arr[i];
                    j++;
                }
            }
            return newArr;
        }

        static int FindMaxValue(int[] arr)
        {
            int maxValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }
            return maxValue;
        }

        static int FindMinValue(int[] arr)
        {
            int minValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }
            }
            return minValue;
        }

        static int[] ReverseArray(int[] arr)
        {
            int[] reversedArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversedArr[i] = arr[arr.Length - 1 - i];
            }
            return reversedArr;
        }

        static int[] FindDuplicates(int[] arr)
        {
            int[] duplicates = new int[arr.Length];
            int duplicatesCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        duplicates[duplicatesCount] = arr[i];
                        duplicatesCount++;
                        break;
                    }
                }
            }

            int[] result = new int[duplicatesCount];
            for (int i = 0; i < duplicatesCount; i++)
            {
                result[i] = duplicates[i];
            }
            return result;
        }

        static int[] RemoveDuplicates(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            int newArrCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < newArrCount; j++)
                {
                    if (arr[i] == newArr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    newArr[newArrCount] = arr[i];
                    newArrCount++;
                }
            }

            int[] result = new int[newArrCount];
            for (int i = 0; i < newArrCount; i++)
            {
                result[i] = newArr[i];
            }
            return result;
        }
    }
}
