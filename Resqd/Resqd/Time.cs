namespace Resqd
{
    public class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;


        public Time(int seconds, int minutes, int hours)
        {
            CorrectFormat(seconds, minutes, hours);
        }

        public Time(int minutes, int hours) : this(0, minutes, hours) { }

        public Time(int seconds) : this(seconds, 0, 0) { }


        public Time() { }
        public int Hours
        {
            get => _hours;
            set
            {
                if (value >= 0)
                {
                    CorrectFormat(_seconds, _minutes, value);
                }
                else
                    throw new ArgumentException(nameof(value), "UnCorrect value");
            }
        }


        public int Minutes
        {
            get => _minutes;
            set
            {
                if (value >= 0)
                    CorrectFormat(_seconds, value, _hours);
                else
                    throw new ArgumentException(nameof(value), "UnCorrect value");
            }
        }

        public int Seconds
        {
            get => Seconds;
            set
            {
                if (value >= 0)
                    CorrectFormat(value, _minutes, _hours);
                else
                    throw new ArgumentException(nameof(value), "UnCorrect value");
            }
        }


        public int TimeInSeconds()
        {
            if (_seconds == 0)
                return _hours * 3600 + _minutes * 60;
            else if (_minutes == 0)
                return _hours * 3600 + _seconds;
            return _seconds + _minutes * 60;
        }

        private void CorrectFormat(int seconds = 0, int minutes = 0, int hours = 0)
        {
            minutes += seconds / 60;
            seconds = seconds % 60;
            hours += minutes / 60;
            minutes = minutes % 60;
            _seconds = seconds;
            _minutes = minutes;
            _hours = hours;
        }


        public static Time operator +(Time t1, Time t2)
        {
            return new Time(t1._seconds + t2._seconds, t1._minutes + t2._minutes, t1._hours + t2._hours);
        }
        public static Time operator -(Time t1, Time t2)
        {
            return new Time(t1._seconds - t2._seconds, t1._minutes - t2._minutes, t1._hours - t2._hours);
        }
        public static Time operator *(Time t1, int num)
        {
            return new Time(t1._seconds * num, t1._minutes * num, t1._hours * num);
        }
        public static Time operator /(Time t1, int num)
        {
            return new Time(t1._seconds / num, t1._minutes / num, t1._hours / num);
        }
        public static bool operator >(Time t1, Time t2)
        {
            return t1._seconds > t2._seconds && t1._minutes > t2._minutes && t1._hours > t2._hours;
        }
        public static bool operator <(Time t1, Time t2)
        {
            return t1._seconds < t2._seconds && t1._minutes < t2._minutes && t1._hours < t2._hours;
        }
        public override string ToString()
        {
            return String.Format("{0:00} : {1:00} : {2:00}", _seconds, _minutes, _hours);
        }
    }
}