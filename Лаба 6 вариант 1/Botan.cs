using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_6_вариант_1
{
    [Couple("Girl", 0.7, "Girl")]
    [Couple("SmartGirl", 0.8, "Book")]
    [Couple("PrettyGirl", 1, "PrettyGirl")]
    public class Botan : Student
    {
        public Botan(string name) : base(name) { }
    }
}
