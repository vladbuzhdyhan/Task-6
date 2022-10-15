using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_6_вариант_1
{
    [Couple("Student", 0.7, "Girl")]
    [Couple("Botan", 0.3, "SmartGirl")]
    
    class Girl : Human
    {
        public Girl(string name) : base(name) { }
    }
}
