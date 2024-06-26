using System;
namespace Assignment1
{
	public class PyramidPattern
	{
		public void DisplayPyramidPattern()
		{
            Console.WriteLine("Enter the Value for Pyramid Layer: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (i * 2) + 1; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
		}
	}
}

