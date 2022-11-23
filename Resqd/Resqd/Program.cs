using System;
using System.Net.Http.Headers;

namespace Resqd
{
    public class Program
    {
        public static void Main()
        {
            //Complexing comp = new Complexing(1, Math.Sqrt(3));
            //Complexing comp1 = new Complexing(2, 3);
            //Complexing comp2 = new Complexing();

            //Console.WriteLine(comp.Arg);
            //comp2.Add(comp, comp1);
            //Console.WriteLine(comp2.Rez);
            //Console.WriteLine(comp1);

            Time Nikita = new Time(48, 72, 63);
            Time Marat = new Time(1);
            Time Alfred = new Time(48, 72, 69);

            Console.WriteLine(Nikita);
            Console.WriteLine(Marat);
            Console.WriteLine(Alfred);
            Console.WriteLine(Nikita.InSecond());
            Console.WriteLine(Alfred.InSecond());
            Console.WriteLine(Nikita + Marat);
            Console.WriteLine(Nikita - Alfred);
        }
    }
}