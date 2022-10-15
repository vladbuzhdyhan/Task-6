using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_6_вариант_1
{
    [Couple("Girl", 0.7, "Girl")]
    [Couple("SmartGirl", 0.8, "Book")]
    [Couple("PrettyGirl", 1, "PrettyGirl")]
    class Botan : Student
    {
        Botan(string name) : base(name) { }
    }
}
