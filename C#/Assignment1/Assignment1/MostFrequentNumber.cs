using System;
namespace Assignment1
{
    public class MostFrequentNumber
    {
        public void DisplayMostFrequentNumber()
        {
            Console.WriteLine("Enter the sequence of numbers (space-separated):");
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int num in numbers)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            int maxFrequency = frequencyMap.Values.Max();
            List<int> mostFrequentNumbers = frequencyMap.Where(pair => pair.Value == maxFrequency)
                                                        .Select(pair => pair.Key)
                                                        .ToList();

            // Find the leftmost number with max frequency
            int resultNumber = mostFrequentNumbers.First();

            Console.Write("The number");
            if (mostFrequentNumbers.Count == 1)
            {
                Console.WriteLine($" {resultNumber} is the most frequent (occurs {maxFrequency} times)");
            }
            else
            {
                Console.Write("s");
                Console.Write(" ");
                Console.Write(string.Join(", ", mostFrequentNumbers));
                Console.WriteLine($" have the same maximal frequency (each occurs {maxFrequency} times). The leftmost of them is {resultNumber}.");

            }
        }
    }
}

