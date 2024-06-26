//Create a console application project named /02UnderstandingTypes/ that outputs the
//number of bytes in memory that each of the following number types uses, and the
//minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
//ulong, float, double, and decimal.


using System;
namespace Assignment1
{
	public class PrintDataTypesValues
	{
        public void DisplayValues()
        {
            Console.WriteLine("Type    : sbyte");
            Console.WriteLine("Size    : {0} bytes", sizeof(sbyte));
            Console.WriteLine("Min     : {0}", sbyte.MinValue);
            Console.WriteLine("Max     : {0}", sbyte.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Type    : byte");
            Console.WriteLine("Size    : {0} bytes", sizeof(byte));
            Console.WriteLine("Min     : {0}", byte.MinValue);
            Console.WriteLine("Max     : {0}", byte.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Type    : short");
            Console.WriteLine("Size    : {0} bytes", sizeof(short));
            Console.WriteLine("Min     : {0}", short.MinValue);
            Console.WriteLine("Max     : {0}", short.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Type    : ushort");
            Console.WriteLine("Size    : {0} bytes", sizeof(ushort));
            Console.WriteLine("Min     : {0}", ushort.MinValue);
            Console.WriteLine("Max     : {0}", ushort.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Type    : int");
            Console.WriteLine("Size    : {0} bytes", sizeof(int));
            Console.WriteLine("Min     : {0}", int.MinValue);
            Console.WriteLine("Max     : {0}", int.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Type    : uint");
            Console.WriteLine("Size    : {0} bytes", sizeof(uint));
            Console.WriteLine("Min     : {0}", uint.MinValue);
            Console.WriteLine("Max     : {0}", uint.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Type    : long");
            Console.WriteLine("Size    : {0} bytes", sizeof(long));
            Console.WriteLine("Min     : {0}", long.MinValue);
            Console.WriteLine("Max     : {0}", long.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Type    : ulong");
            Console.WriteLine("Size    : {0} bytes", sizeof(ulong));
            Console.WriteLine("Min     : {0}", ulong.MinValue);
            Console.WriteLine("Max     : {0}", ulong.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Type    : float");
            Console.WriteLine("Size    : {0} bytes", sizeof(float));
            Console.WriteLine("Min     : {0}", float.MinValue);
            Console.WriteLine("Max     : {0}", float.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Type    : double");
            Console.WriteLine("Size    : {0} bytes", sizeof(double));
            Console.WriteLine("Min     : {0}", double.MinValue);
            Console.WriteLine("Max     : {0}", double.MaxValue);
            Console.WriteLine();

            Console.WriteLine("Type    : decimal");
            Console.WriteLine("Size    : {0} bytes", sizeof(decimal));
            Console.WriteLine("Min     : {0}", decimal.MinValue);
            Console.WriteLine("Max     : {0}", decimal.MaxValue);
            Console.ReadLine();
        }
    }
}

