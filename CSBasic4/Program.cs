using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic4
{
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
