using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_6_вариант_1
{
    class CoupleExeption : Exception
    {
        public CoupleExeption(string message)
            : base(message) { }
    }
}
