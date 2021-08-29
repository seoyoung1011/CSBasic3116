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
            Child child = new Child();
            child.Method();
            ((Parent)child).Method();
        }
    }
    class Parent
    {
        public void Method()
        {
            Console.WriteLine("부모의 메서드");
        }
    }

    class Child : Parent
    {
        public void Method()
        {
            Console.WriteLine("자식의 메서드");
        }
        /*
        public new void Method()
        {
            Console.WriteLine("자식의 메서드");
        }
        */
    }
}