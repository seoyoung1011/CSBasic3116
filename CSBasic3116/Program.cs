using System;

namespace CSBasic3116
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 기본 자료형 */
            //정수
            Console.WriteLine(52);
            Console.WriteLine(52 + 273);
            Console.WriteLine(5 + 3 * 2); // 곱셈 먼저, 그다음 덧셈

            Console.WriteLine(10 / 5);
            Console.WriteLine(10 % 5);
            Console.WriteLine(7 % 3);

            //실수
            Console.WriteLine(52.273);
            Console.WriteLine(0); //int32
            Console.WriteLine(0.0); //double

            Console.WriteLine(1.0 + 2.0); //3.0
            Console.WriteLine(1.0 - 2.0); //-1.0
            Console.WriteLine(1.0 * 2.0); //2.0

            Console.WriteLine(1 / 2); //0
            Console.WriteLine(1.0 / 2.0); //0.5
            Console.WriteLine(1 / 2.0); //0.5 - double이 더 크기 때문에 암묵적으로 double로 바뀐다.

            //문자
            Console.WriteLine('A');
            Console.WriteLine('가');

            Console.WriteLine("미림\t정보\t과학고");
            Console.WriteLine("\\역슬래시 \n 엔터문자 \"큰따옴표 ");

            //문자열 연걸 연산자
            Console.WriteLine("A" + "B");
            Console.WriteLine("A" + 1);
            Console.WriteLine(1 + "A");
            Console.WriteLine("1" + "A");
            Console.WriteLine("1" + "1");
            Console.WriteLine('A' + 'B');
            Console.WriteLine('A' - 'B');

            Console.WriteLine("안녕하세요!"[0]);
            //Console.WriteLine("안녕하세요!"[1]);
            Console.WriteLine("안녕하세요!"[2]);
            //Console.WriteLine("안녕하세요!"[3]);
            Console.WriteLine("안녕하세요!"[4]);
            Console.WriteLine("안녕하세요!"[5]);

            //boolean
            Console.WriteLine(true);
            Console.WriteLine(false);

            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);

            /* 변수 */
            int a = 2147483647;
            int b = 1;
            Console.WriteLine(a + b);

            bool TrueorFalse = true;
        }
    }
}
