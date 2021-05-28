using System;

namespace CSBasic4
{
    class Student
    {
        public string id;
        public string name;
        public int grade;
        public string major;
        public DateTime birthday;
        public string favoriteyFood;

        public override string ToString()
        {
            return name + ", " + grade;
        }
    }
}
