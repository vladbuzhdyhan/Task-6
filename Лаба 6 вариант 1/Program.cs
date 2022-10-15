using System;
using System.Reflection;

namespace Лаба_6_вариант_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human[] botans = new Student[10];
            Human[] prettyGirls = new PrettyGirl[10];
            for(int i = 0; i < 10; i++)
            {
                botans[i] = new Student("Student "+i);
                
            }
            for (int i = 0; i < 10; i++)
            {
                prettyGirls[i] = new PrettyGirl("Girl "+i);

            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"{ botans[i].Name } {prettyGirls[j].Name} ");
                    Human.Couple(botans[i], prettyGirls[j]);
                }
            }
            MemberInfo[] members = typeof(Student).GetMembers();
            foreach (MemberInfo m in members) Console.WriteLine(m);
        }


    }
}
