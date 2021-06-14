using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic5
{
	class Program
	{
		static void Main(string[] args)
		{
			MultiClass ml = new MultiClass();
			Console.WriteLine(ml.Multi(52, 273));
			Console.WriteLine(ml.Multi(103, 32));
			ml.Print();
			Console.WriteLine(ml.Sum(1, 100));
			MyMath.Abs(-82);
			MyMath.Abs(273);
			MyMath.Abs(-32.273);
			MyMath.Abs(3000000000);

			ml.somePublic();
			//ml.someDefault();
			//ml.somePrivate()

			Product productA = new Product("감자", 2000);
			Product productB = new Product("고구마", 2000);
			Console.WriteLine(productA.id + ": " + productA.name);
			Console.WriteLine(productB.ToString());
		}


		class Product
		{
			public static int couter = 0;
			public int id;
			public string name;
			public int price;

			public Product(string name, int price)
			{
				Product.couter = Product.couter + 1;
				this.id = Product.couter;
				this.name = name;
				this.price = price;
			}
            public override string ToString()
            {
				return id + ": " + name;
            }
        }

		class MyMath
		{
			public static void Abs(int input)
			{
				Console.WriteLine("정수: " + ((input < 0) ? -input : input));
			}
			public static void Abs(double input)
			{
				Console.WriteLine("더블: " + ((input < 0) ? -input : input));
			}
			public static void Abs(long input)
			{
				Console.WriteLine("롱: " + ((input < 0) ? -input : input));
			}

		}

		class MultiClass
		{
			public void somePublic()
			{
				Console.WriteLine("Public");
			}
			void someDefault()
			{
				Console.WriteLine("Default");
			}
			private void somePrivate()
			{
				Console.WriteLine("private");
			}
			public int Multi(int x, int y)
			{
				return x * y;
			}
			public void Print()
			{
				Console.WriteLine("Print() 메서드 호출!");
			}
			public int Sum(int min, int max)
			{
				int output = 0;
				for (int i = min; i <= max; i++)
				{
					output += 1;
				}
				return output;
			}
		}
	}
}
