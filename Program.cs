using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[10] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            Console.WriteLine("\nOriginal Array Elements :");
            PrintIntegerArray(numbers);

            Console.WriteLine("\nSorted Array Elements :");
            PrintIntegerArray(bubbleSort(numbers));
            Console.WriteLine("\n");
        }
        static int[] bubbleSort(int[] inputArray)
        {
            {
                var n = inputArray.Length;
                bool swapRequired;
                for (int i = 0; i < n - 1; i++)//goes through whole list
                {
                    swapRequired = false;
                    for (int j = 0; j < n - i - 1; j++)// stops the loop before the sorted varables 
                        if (inputArray[j] > inputArray[j + 1])//swap the two varables
                        {
                            var tempVar = inputArray[j];
                            inputArray[j] = inputArray[j + 1];
                            inputArray[j + 1] = tempVar;
                            swapRequired = true;
                        }
                    if (swapRequired == false)//stops if no swap is performed
                        break;
                }
                return inputArray;
            }

        }

        // Method to print integer array elements
        public static void PrintIntegerArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i.ToString() + "  "); // Display each element followed by a space
            }
        }
    }
}