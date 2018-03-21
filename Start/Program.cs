using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    //Why have a new class that contains an enum and nothing else, whats the point?
    public class Animal
    {
        public string name;
        public int age;
    }
    class Program
    {
        struct Person
        {
            public string name;
            public int age;
            public double height;
        }
        enum Lights { Red, Green, Yellow };
        static void Main(string[] args)
        {
            {
                Lights x = Lights.Red;
                switch (x)
                {
                    case Lights.Green:
                        Console.WriteLine("Go");
                        break;
                    case Lights.Red:
                        Console.WriteLine("Stop");
                        break;
                    case Lights.Yellow:
                        Console.WriteLine("Caution");
                        break;
                }
            }
             {
                Animal jack = new Animal
                {
                    name = "Jack",
                    age = 5
                };
                Console.WriteLine(jack.name);
 //Why a? could it be a better name?
                 Person a;
                 a.name = "George";
                 a.age = 23;
                 a.height = 5.11;
                Console.WriteLine(a.name);
                Console.WriteLine(a.age);
                Console.WriteLine(a.height);
                Console.ReadLine();
                
             }
             /*
             int a = 1;
             double b = 10;
             Console.WriteLine("a = {0}; b = {1}", a, b);
             Console.ReadLine();
             Console.WriteLine(a);
             Console.WriteLine("Hello"); 

            string yourName;
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();
            Console.WriteLine("Hello {0}", yourName);
            Console.WriteLine("How old are you, {0}?", yourName);
            int yourAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0}", yourAge);
            Console.ReadLine();

              const double PI = 3.14;
              Console.WriteLine(PI * PI);
              int a = 50 * 16;
              Console.WriteLine(a);
              int b = 25 % 7;
              Console.WriteLine(b);
              //int c = 4 + 3 * 2;
              int c = (4 + 3) * 2;
              Console.WriteLine(c);
              int d = 50;
              d /= 2;
              d *= 5;
              Console.WriteLine(d);
              Console.ReadLine();
              */
        }
    }
}