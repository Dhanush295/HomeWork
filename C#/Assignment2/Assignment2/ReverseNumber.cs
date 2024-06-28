using System;
namespace Assignment2
{
	public class ReverseNumber
	{
        static int[] GenerateNumbers(int length)
        {
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = i + 1; 
            }
            return numbers;
        }

        static void Reverse(int[] array)
        {
            int arrayLength = array.Length;
            for (int i = 0; i < arrayLength / 2; i++)
            {
                int temp = array[i];
                array[i] = array[arrayLength - i - 1];
                array[arrayLength - i - 1] = temp;
            }
        }

        static void PrintNumbers(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers(10); 
            Reverse(numbers);
            PrintNumbers(numbers);

        }
    }
}

