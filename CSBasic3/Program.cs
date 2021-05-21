using System;
using System.Threading;

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
            int ii = 0;
            int[] intArray3 = { 19, 27, 28, 26, 24 };
            while(ii < intArray3.Length)
            {
                Console.WriteLine((ii+1) + "번째 출력: " + intArray3[ii]);
                ii++;
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


            /* for 반복문 / 역 for 문 */
            //for(int i = '가'; i <= '힣'; i++)
            //{
            //    Console.Write((char)i);
            //}
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for (int i = intArray3.Length-1; i >= 0; i--)
            {
                Console.WriteLine(intArray3[i]);
            }
            Console.WriteLine("\n\n");


            /* foreach 반복문 / 중첩 반복문 / break / continue */
            string[] strArray = { "사과", "배", "포도", "딸기", "수박" };
            foreach(string item in strArray)
            {
                Console.WriteLine(item);
            }
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < i+1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            while (true)
            {
                Console.Write("숫자를 입력하세요(짝수를 입력하면 종료: ");
                int intInput = int.Parse(Console.ReadLine());
                if (intInput % 2 == 0)
                    break;
            }

            for(int i = 1; i < 10; i++)
            {
                if ( i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }


            /* 반복문 응용 */
            string PoTo = "Potato Tomato";
            Console.WriteLine(PoTo.ToUpper());
            Console.WriteLine(PoTo.ToLower());

            input = "감자 고구마 토마토";
            string[] inputs = input.Split(new char[] { ' ' });
            foreach(var item in inputs)
            {
                Console.WriteLine(item);
            }

            input = "  test               \n";
            Console.WriteLine("::" + input.Trim() + "::");
            Console.Read();

            string[] array = { "감자", "고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(",", array));

            Console.WriteLine("첫 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("두 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("세 번째 출력");
            Thread.Sleep(2000);

            int x = 1;
            while(x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);
                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");
                Thread.Sleep(100);
                x++;
            }
            bool state = true;
            while (state)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위로 이동");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래로 이동");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("위로 이동");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("위로 이동");
                        break;
                    case ConsoleKey.X:
                        state = false;
                        break;
                }
            }
        }
    }
}
