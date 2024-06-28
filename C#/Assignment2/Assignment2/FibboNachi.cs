using System;
namespace Assignment2
{
	public class FibboNachi
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number: ");
            int terms = int.Parse(Console.ReadLine());

            Console.Write("Fibonaci series is:");

            for(int i=0; i<terms;i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            Console.WriteLine();

        }

        static int Fibonacci(int num)
        {
            if(num <= 1) 
                return num;
            else
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
    }
}

