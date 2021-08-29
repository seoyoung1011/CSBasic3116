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
            Child childA = new Child();
            Child childB = new Child("string");
        }
    }
    class Parent
    {
        public Parent() { Console.WriteLine("Parent()"); }
        public Parent(int param) { Console.WriteLine("Parent(int param"); }
        public Parent(string param) { Console.WriteLine("Parent(string param"); }
    }

    class Child : Parent
    {
        public Child() : base(10) //Parent(int param) 호출
        {
            Console.WriteLine("Child(): base(10)");
        }
        public Child(string input) : base(input) //Parent(string param) 호출
        {
            Console.WriteLine("Chile(string input): base(input)");
        }
    }
}