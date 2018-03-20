using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    public class enums
    {
        enum colours { Red, Green, Blue, Purple };
    }
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
        static void Main(string[] args)
        {
            {
                Animal jack = new Animal();
                jack.name = "Jack";
                jack.age = 4;
                Console.WriteLine(jack.name);

                Person a;
                a.name = "George";
                a.age = 21;
                a.height = 5.8;
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