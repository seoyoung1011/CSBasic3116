using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic4
{
    class MyMath
    {
        public int a;
        public static double PI = 3.141592;
        public static void Hello()
        {
            Console.WriteLine("Greeting~");
        }
    }
    class Product
    {
        public string name = "default";
        public int price = 1000;

        public override string ToString()
        {
            return name + ": " + price;
        }
    }

class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;
        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
    class Program
    {
        //class Math
        //{

        //}
        static void Main(string[] args)
        {
            Car[] cars = new Car[10];

            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble()*100);

            List<int> list = new List<int>();
            list.Add(94);
            list.Add(95);
            list.Add(96);
            list.Add(03);
            foreach (var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\t item: " + item);
            }
            foreach (var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\t item: " + item);
            }

            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));

            Product product = new Product();
            Product productA = new Product() { name = "감자", price = 2000 };
            Console.WriteLine(productA);
            Product productB = new Product() { name = "고구마", price = 1500 };
            Console.WriteLine(productB);

            Console.WriteLine(MyMath.PI);
            MyMath.Hello();

            /*
            List<Student> students = new List<Student>();
            students.Add(new Student() { name = "조서영", grade = 1 });
            students.Add(new Student() { name = "황인탁", grade = 1 });
            students.Add(new Student() { name = "최태양", grade = 3 });
            students.Add(new Student() { name = "윤기호", grade = 3 });
            */

            List<Student> students = new List<Student>() {
                new Student() { name = "조서영", grade = 1 },
                new Student() { name = "황인탁", grade = 1 },
                new Student() { name = "최태양", grade = 3 },
                new Student() { name = "윤기호", grade = 3 }
            };
            
            foreach (var item in students)
                Console.WriteLine(item);

            for(int i = 0; i< students.Count(); i++)
                if (students[i].grade > 0)
                    students.RemoveAt(i);

        }
    }

    class FirstClass
    {

    }

    class SecondClss
    {
        class ChildClass
        {

        }
    }

}
