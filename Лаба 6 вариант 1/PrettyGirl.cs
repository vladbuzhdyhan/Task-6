using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_6_вариант_1
{
    [Couple("Student", 0.4, "PrettyGirl")]
    [Couple("Botan", 0.1, "PrettyGirl")]
    
    sealed class PrettyGirl : Girl
    {
        public PrettyGirl(string name) : base(name) { }
    }
}
