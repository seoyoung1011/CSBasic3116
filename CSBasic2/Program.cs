using System;

namespace CSBasic2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* if / if else / if 중첩 */
            if(DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간");
            }else if(DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심 먹을 시간");
            }else
            {
                Console.WriteLine("저녁 먹을 시간");
            }

            double score = 3.6;
            if (score == 4.5)
                Console.WriteLine("신");
            else if (4.2 <= score && score < 4.5)
                Console.WriteLine("교수님의 사랑");
            else if (3.5 <= score && score < 4.2)
                Console.WriteLine("현 체제의 수호자");
            else if (2.8 <= score && score < 3.5)
                Console.WriteLine("일반인");
            else if (2.3 <= score && score < 2.8)
                Console.WriteLine("일탈을 꿈꾸는 소시민");
            else if (1.75 <= score && score < 2.3)
                Console.WriteLine("오락문화의 선구자");
            else if (1.0 <= score && score < 1.75)
                Console.WriteLine("불가촉천민");
            else if (0.5 <= score && score < 1.0)
                Console.WriteLine("자벌레");
            else if (0 < score && score < 0.5)
                Console.WriteLine("플랑크톤");
            else
                Console.WriteLine("시대를 앞서가는 혁명의 씨앗");



            /* switch */
            Console.Write("숫자를 입력하세요 : ");
            int input = int.Parse(Console.ReadLine());

            switch(input % 2)
            {
                case 0:
                    Console.WriteLine("짝수입니다.");
                    break;
                case 1:
                    Console.WriteLine("홀수입니다.");
                    break;
            }

            Console.Write("이번 달은 몇 월인가요 : ");
            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 12: case 1: case 2:
                    Console.WriteLine("겨울입니다.");
                    break;
                case 3: case 4: case 5:
                    Console.WriteLine("봄입니다.");
                    break;
                case 6: case 7: case 8:
                    Console.WriteLine("여름입니다.");
                    break;
                case 9: case 10: case 11:
                    Console.WriteLine("가을입니다.");
                    break;
                case 13:
                    Console.WriteLine("니가 세븐틴이냐");
                    break;
                default:
                    Console.WriteLine("대체 어디서 살고 계신 건가요?");
                    break;
            }


            /* 삼항 연산자 */
            int number = 2;
            Console.WriteLine(number % 2 == 0 ? true : false);
            Console.WriteLine(number % 2 == 0 ? "짝수입니다" : "홀수입니다.");

            Console.Write("숫자를 입력하세요 : ");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine(number > 0 ? "자연수입니다." : "자연수가 아닙니다.");


            /* 제어문 응용 */
            Console.Write("입력: ");
            String line = Console.ReadLine();

            if (line.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요!");
            }
            else
            {
                Console.WriteLine("^^");
            }

            ConsoleKeyInfo info = Console.ReadKey();
            switch (info.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("위로 이동");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("오른쪽으로 이동");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("아래로 이동");
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("왼쪽으로 이동");
                    break;
                default:
                    Console.WriteLine("다른 키를 눌렀습니다.");
                    break;
            }

            Console.WriteLine("반복해서 누르기!! (Q선택시 종료)");
            int num = 0;
            while(num == 0)
            {
                info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위로 이동");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽으로 이동");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래로 이동");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽으로 이동");
                        break;
                    case ConsoleKey.Q:
                        Console.WriteLine("나가기!!!!!!!!");
                        num = 1;
                        break;
                    default:
                        Console.WriteLine("다른 키를 눌렀습니다.");
                        break;
                }
            }

        }
    }
}
