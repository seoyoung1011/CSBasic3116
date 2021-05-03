using System;

namespace CSBasic3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 반복문과 배열 */
            int[] intArray = { 19, 27, 28, 26, 24 };
            intArray[2] = 0;
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);
            Console.WriteLine(intArray[4]);
            Console.WriteLine(intArray.Length + "\n\n");

            int[] intArray2 = new int[100];
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[99]);


        }
    }
}
