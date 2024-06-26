using System;
namespace Assignment1
{
	public class CalculateAge
	{
		public void DisplayAgeCalculator()
		{
            Console.WriteLine("Enter your birth date (YYYY-MM-DD): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

           
            DateTime currentDate = DateTime.Now;
            TimeSpan ageTimeSpan = currentDate - birthDate;
            int ageInDays = (int)ageTimeSpan.TotalDays;

            Console.WriteLine("You are {0} days old.", ageInDays);

           
            int daysToNextAnniversary = 10000 - (ageInDays % 10000);
            DateTime nextAnniversaryDate = currentDate.AddDays(daysToNextAnniversary);

            Console.WriteLine("Your next 10,000-day anniversary will be in {0} days, on {1}.", daysToNextAnniversary, nextAnniversaryDate.ToShortDateString());

        }
    }
}

