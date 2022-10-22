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
            DateTime date = DateTime.Now;
            int day = (int)date.DayOfWeek;
            if (day != 0)
            {
                ConsoleKeyInfo key;
                do
                {
                    key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Human[] b = new Student[2];
                        Human[] g = new Girl[2];

                        for (int i = 0; i < 2; i++)
                        {
                            Random r = new Random();
                            int rand = r.Next(0, 1);
                            if (rand == 0) b[i] = new Student("Nikita");
                            else b[i] = new Botan("Nikita");
                        }

                        for (int i = 0; i < 2; i++)
                        {
                            Random r = new Random();
                            int rand = r.Next(0, 2);
                            if (rand == 0) g[i] = new Girl("Nikita");
                            else if (rand == 1) g[i] = new PrettyGirl("Nikita");
                            else g[i] = new SmartGirl("Nikita");
                        }

                        Human.Couple(b[0], g[0]);
                        Human.Couple(b[1], g[1]);
                    }
                } while (key.Key != ConsoleKey.Q && key.Key != ConsoleKey.F10);
            }
            else { Console.WriteLine("у консоли выходной:)"); }
        }

      
    }
}
