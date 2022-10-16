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
                botans[i] = new Student("Student");
            }
            for (int i = 0; i < 10; i++)
            {
                prettyGirls[i] = new PrettyGirl("Girl");
                
            }
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"{ botans[i].Name } {prettyGirls[j].Name} ");
                    Human.Couple(botans[i], prettyGirls[j]);
                    
                    Type type = Assembly.GetExecutingAssembly().GetType("Лаба_6_вариант_1."+"Student");                   
                    
                    MethodInfo method = prettyGirls[i].GetType().GetMethod("GetName");
                    
                    string Name = (string)method.Invoke(prettyGirls[i],null);
                    
                    if (type.GetProperty("MiddleName")!=null)
                    {
                        Name += "ovna";
                    }
                    IHasName createdinst = (IHasName)Activator.CreateInstance(type, $"{Name}");

                    Console.WriteLine($"obj name -{createdinst.Name}");
                    Console.WriteLine($"--{Name}");
                }
            }
            
            PropertyInfo[] members = typeof(Student).GetProperties();
            foreach (PropertyInfo m in members) Console.WriteLine(m);
        }

    }
}
