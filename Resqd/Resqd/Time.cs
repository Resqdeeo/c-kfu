using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resqd
{
    public class Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        public int Hours
        {
            get { return hours; }
            set { hours = value; }      
        }


        public int Minutes  
        {
            get { return minutes; }
            set { minutes = value; }
        }


        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }


        public Time(int h, int m, int s)
        {
            Hours = (h + (m / 60) + (s / 3600)) % 24;
            Minutes = ((m % 60) + ((s % 3600) / 60)) % 60;
            Seconds = (s % 3600) % 60;
        }


        public Time(int h, int m)
        {
            Hours = (h + (m / 60)) % 24;
            Minutes = m % 60;
            Seconds = 0;
        }


        public Time(int s)
        {
            Hours = s / 3600;
            Minutes = (s % 3600) / 60;
            Seconds = (s % 3600) % 60;
        }


        public Time()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }


        public int InSecond()
        {
            int seconds = (Hours * 3600) + (Minutes * 60) + Seconds; 
            return seconds;
        }


        public static Time operator +(Time t1, Time t2)
        {
            int seconds = t1.InSecond() + t2.InSecond();
            return new Time(seconds);
        }


        public static Time operator -(Time t1, Time t2)
        {
            int seconds;
            if ((t1.InSecond() - t2.InSecond()) < 0)
                seconds = 86400 - Math.Abs(t1.InSecond() - t2.InSecond());
            else seconds = t1.InSecond() - t2.InSecond();
            return new Time(seconds);       
        }


        public static Time operator *(Time t1, int a)
        {
            int seconds;
            if ((t1.InSecond() != 0) && a != 0)
            {
                seconds = t1.InSecond() * a;
            }
            else seconds = 0;
            return new Time(seconds);
        }


        public static Time operator *(int a, Time t1)
        {
            int seconds;
            if (a != 0 && (t1.InSecond() != 0))
            {
                seconds = a * t1.InSecond();
            }
            else seconds = 0;
            return new Time(seconds);
        }


        public static Time operator /(Time t1, int a)
        {
            int seconds;
            if (a == 0)
            {
                throw new ArgumentException("На ноль делить нельзя!");
            }
            else if ((t1.InSecond() == 0) && a != 0)
            {
                seconds = 0;
            }
            else
            {
                seconds = t1.InSecond() / a;
            }
            return new Time(seconds);
        }


        public override string ToString()
        {
            if (Hours < 10 && Minutes < 10 && Seconds < 10)
            {
                return $"0{Hours}:0{Minutes}:0{Seconds}";
            }
            if (Hours < 10 && Minutes < 10 && Seconds > 10)
            {
                return $"0{Hours}:0{Minutes}:{Seconds}";
            }
            if (Hours < 10 && Minutes > 10 && Seconds < 10)
            {
                return $"0{Hours}:{Minutes}:0{Seconds}";
            }
            if (Hours > 10 && Minutes < 10 && Seconds < 10)
            {
                return $"{Hours}:0{Minutes}:0{Seconds}";
            }
            if (Hours > 10 && Minutes > 10 && Seconds < 10)
            {
                return $"{Hours}:{Minutes}:0{Seconds}";
            }
            if (Hours < 10 && Minutes > 10 && Seconds > 10)
            {
                return $"0{Hours}:{Minutes}:{Seconds}";
            }
            if (Hours > 10 && Minutes < 10 && Seconds > 10)
            {
                return $"{Hours}:0{Minutes}:{Seconds}";
            }
            return $"{Hours}:{Minutes}:{Seconds}";
        }
    }
}
