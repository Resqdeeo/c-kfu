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

            Time Time1 = new Time(48, 72, 63);
            Time Time2 = new Time(1);
            Time Time3 = new Time(48, 72, 69);

            Console.WriteLine(Time1);
            Console.WriteLine(Time2);
            Console.WriteLine(Time3);
            Console.WriteLine(Time1.InSecond());
            Console.WriteLine(Time2.InSecond());
            Console.WriteLine(Time2.InSecond());
            Console.WriteLine(Time1 + Time2);
            Console.WriteLine(Time1 - Time3);
            Console.WriteLine(Time2 * 100);
            Console.WriteLine(3 * Time3);
            //try
            //{
            //    Console.WriteLine(Time1 / 0);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            Console.WriteLine(Time1 / 0);
        }
    }
}