using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_6_вариант_1
{
    [Couple("Student", 0.2, "Girl")]
    [Couple("Botan", 0.5, "SmartGirl")]
    sealed class SmartGirl : Girl
    {
        public SmartGirl(string name) : base(name) { }
    }
}
