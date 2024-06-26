using System;
namespace Assignment1
{
	public class FizzBuzz
	{
		public void DisplayFizzBuzz()
		{
			int max = 100;

			for (byte i=0; i<max; i++)
			{
				if(i %3 ==0 && i%5 == 0)
				{
					Console.WriteLine("FizzBuzz");
				}
				else if (i %3 == 0)
				{
					Console.WriteLine("Fizz");
				}
				else if (i %5 == 0)
				{
					Console.WriteLine("Buzz");
				}

				Console.WriteLine(i);			}
		}
	}
}

