//Write program to enter an integer number of centuries and convert it to years, days, hours,
//minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
//type for every data conversion. Beware of overflows!

using System;
namespace Assignment1
{
	public class CalculateYears
	{
		public void DisplayYears()
		{
			Console.WriteLine("Enter Century Number: ");
			int century = int.Parse(Console.ReadLine());

			int years = century * 100;
			long days = (long) (years * 365.2425);
			long hours = days * 24;
			long minutes = hours * 60;
			long secons = minutes * 60;
			long milliseconds = secons * 1000 ;
			long microseconds = milliseconds * 1000;
			double nanoseconds = (double) microseconds * 1000;

            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {secons} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        

		}
	}
}

