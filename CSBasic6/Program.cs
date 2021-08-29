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
    class Parent
    {
        public virtual void Test() { }
    }

    class Child : Parent
    {
        sealed public override void Test() { }
    }
    class GrandChild : Child
    {
        public override void Test() { }  //이번에는 여기서 오류 발생
    }
}