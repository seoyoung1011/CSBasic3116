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
            Parent parent = new Parent();
            Child child = new Child();

            parent.Test();
            child.Test();
        }
    }
    sealed class Parent
    {
        public void Test() { }
    }

    class Child : Parent //sealed클래스로 선언시 오류 발생
    {
        public void Test() { }
    }
}