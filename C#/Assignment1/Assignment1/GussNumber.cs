using System;
namespace Assignment1
{
	public class GussNumber
	{
		public void DisplayGuessNumber()
		{
			int randomNumber = new Random().Next(3) + 1;

			Console.WriteLine("Enter The Number Btw 1 to 3: ");
			int guessedNumber = int.Parse(Console.ReadLine());

			if (randomNumber == guessedNumber)
			{
				Console.WriteLine("YaY You guessed Correct!");
			}
			else if (randomNumber > guessedNumber)
			{
				Console.WriteLine("Guessed Number is Low");
			}
			else
			{
				Console.WriteLine("Guessed Number is High!");
			}
		}
	}
}

