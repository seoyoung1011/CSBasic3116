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
            Console.WriteLine(intArray2[0]);
            Console.WriteLine(intArray2[99]);


            /* while / do while 반복문 */
            int i = 0;
            int[] intArray3 = { 19, 27, 28, 26, 24 };
            while(i < intArray3.Length)
            {
                Console.WriteLine((i+1) + "번째 출력: " + intArray3[i]);
                i++;
            }

            string input;
            do
            {
                Console.Write("exit를 입력하면 종료 : ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("=> 공지사항");
                        break;
                    case "2":
                        Console.WriteLine("=> 오늘의 점심");
                        break;
                    case "input":
                        Console.WriteLine("do while문을 종료합니다.");
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }
            } while (input == "exit");


        }
    }
}
