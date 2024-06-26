using System;
namespace Assignment1
{
	public class ArrayRotation
	{
		public void DisplayArrayRotation()
		{
            Console.WriteLine("Enter the array of integers:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int[] array = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }

            Console.WriteLine("Enter the value of k:");
            int k = int.Parse(Console.ReadLine());

            int n = array.Length;
            int[][] rotatedArrays = new int[k][];
            int[] sum = new int[n];

            for (int r = 0; r < k; r++)
            {
                rotatedArrays[r] = new int[n];
                for (int i = 0; i < n; i++)
                {
                    rotatedArrays[r][(i + r) % n] = array[i];
                }

                Console.WriteLine($"rotated{r + 1}[] = " + string.Join(" ", rotatedArrays[r]));

                
                for (int i = 0; i < n; i++)
                {
                    sum[i] += rotatedArrays[r][i];
                }
            }

            Console.WriteLine("sum[] = " + string.Join(" ", sum));
        }
	}
}

