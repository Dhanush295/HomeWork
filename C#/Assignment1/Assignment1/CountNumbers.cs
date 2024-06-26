using System;
namespace Assignment1
{
    public class CountNumbers
    {
        public void DisplayCountNumbers(int start, int end, int step)
        {
            for (int i = start; i <= end; i += step)
            {
                Console.Write(i);
                if (i + step <= end)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }

        
    }
}
