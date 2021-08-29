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
            Console.WriteLine(child.variable);
        }
    }
    class Parent
    {
        public int variable = 273;
    }

    class Child : Parent
    {
        public string variable = "shadowing";
    }
}