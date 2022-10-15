using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_6_вариант_1
{
    [Couple("Girl",0.7,"Girl")]
    [Couple("PrettyGirl", 1, "PrettyGirl")]
    [Couple("SmartGirl",0.5,"Girl")]

    public class Student : Human
    {
        public Student(string name) : base(name)
        {

        }
    }
}
