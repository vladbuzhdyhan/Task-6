using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_6_вариант_1
{

    public class Human : IHasName
    {
        public Human(string name)
        {
            Name = name;
        }
        public Human(string name,string midName)
        {
            Name = name;
            MiddleName = midName;
        }
        public string Name { get; }
        public string MiddleName { get; }
        public string GetName()
        {
            return Name;
        }
        
        static public IHasName Couple(Human hum1,Human hum2)
        {
            bool _isSucsesfull=false;
            Type type1 = hum1.GetType();
            Type type2 = hum2.GetType();
            int CountOfTrue=0;
            int CountOfTrue2 = 0;
            object[] att1 = Attribute.GetCustomAttributes(type1);
            object[] att2 = Attribute.GetCustomAttributes(type2);
          
            foreach (object obj in att1)
            {
                CoupleAttribute att = (CoupleAttribute)obj;
                //Console.WriteLine(att.Pair);
                if (att.Pair == hum2.GetType().Name)
                {
                    _isSucsesfull=IsSucsesfull(att.Probability);
                    if (_isSucsesfull)
                    {
                        CountOfTrue++;
                    }
                }
            }
            foreach (object obj in att2)
            {
                //Console.WriteLine(obj.ToString());
                CoupleAttribute att = (CoupleAttribute)obj;
                if (att.Pair == hum1.GetType().Name)
                {
                   bool _isSucsesfull2 = IsSucsesfull(att.Probability);
                    if (_isSucsesfull2)
                    {
                        CountOfTrue2++;
                    }
                    _isSucsesfull &= _isSucsesfull2;
                }
            }
            Console.WriteLine($"{_isSucsesfull} {CountOfTrue} {CountOfTrue2} {((CoupleAttribute)att1[0]).Probability} {((CoupleAttribute)att2[0]).Probability}");
            return hum1;

        }
        static Random random = new Random();
        static bool IsSucsesfull(double probability)
        {
            if (random.NextDouble() <= probability)
            {
                return true;
            }
            else { return false; }
        }
    }
}
