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
            //오버라이딩을 하면 클래스형을 어떻게 변환해도 자식에서 다시 정의한 메서드가 호출된다.
        }
    }
    class Parent
    {
        public virtual void Method()
        {
            Console.WriteLine("부모의 메서드");
        }
    }

    class Child : Parent
    {
        public override void Method()
        {
            Console.WriteLine("자식의 메서드");
        }
    }
}