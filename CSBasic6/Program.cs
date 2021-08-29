using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSBasic6
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            foreach(var item in Dogs)
            {
                item.Eat();

                item.Sleep();
                item.Bark();
            }
            foreach (var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }
        }
    }
    class Animal
    {
        public int Age { get; set; }

        public Animal() { this.Age = 0; }

        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
    }
    class Dog : Animal
    {
        public string Color { get; set; }

        public void Bark() { Console.WriteLine("왈왈 짖습니다."); }
    }
    class Cat : Animal
    {
        public void Meow() { Console.WriteLine("냥냥 웁니다."); }
    }
}
