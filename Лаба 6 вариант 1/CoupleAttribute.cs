using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_6_вариант_1
{
    [AttributeUsage(AttributeTargets.Class,Inherited = false,AllowMultiple =true)]
    public class CoupleAttribute : Attribute
    {
        public CoupleAttribute(string pair,double probability,string childtype)
        {
            Pair = pair;
            Probability = probability;
            ChildType = childtype;
        }
        public CoupleAttribute() : this("Human",0.5,"Human") { }
        public string Pair { get; set; }
        public double Probability { get; set; }
        public string ChildType { get; set; }
        public override string ToString()
        {
            return $"Pair - {Pair}, Probability - {Probability}, ChildType - {ChildType}";
        }
    }
}