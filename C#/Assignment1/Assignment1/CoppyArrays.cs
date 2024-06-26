using System;
namespace Assignment1
{
	public class CoppyArrays
	{
		public void DisplayCoppyArrays()
		{
            int[] originalArray = new int[10];
            for (int i = 0; i < originalArray.Length; i++)
            {
                originalArray[i] = i + 1; 
            }

            
            int[] copiedArray = new int[originalArray.Length];

          
            for (int i = 0; i < originalArray.Length; i++)
            {
                copiedArray[i] = originalArray[i];
            }

            
            Console.WriteLine("Original Array: ");
            for (int i = 0; i < originalArray.Length; i++)
            {
                Console.Write(originalArray[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Copied Array: ");
            for (int i = 0; i < copiedArray.Length; i++)
            {
                Console.Write(copiedArray[i] + " ");
            }
        }
	}
}

