using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resqd
{
    public class Complexing
    {
        public double RealNumber { get; set; }

        public double ImaginaryUnit { get; set; }

        public double AbsoluteValue { get { return Math.Sqrt(RealNumber * RealNumber + ImaginaryUnit * ImaginaryUnit); } }
        
        public double Angle { get { return Math.Acos(RealNumber / AbsoluteValue); } }
        
        public Complexing(double realNumber, double imaginatyUnit)
        {
            RealNumber = realNumber;
            ImaginaryUnit = imaginatyUnit;
        }

        public Complexing(double realNumber) : this(realNumber, 0) { }

        public Complexing() : this(0, 0) { }

        public override string ToString()
        {
            if (RealNumber == 0)
                return $"{ImaginaryUnit}i";
            else if (ImaginaryUnit == 0)
                return $"{RealNumber}";
            else if (ImaginaryUnit == 1)
                return $"{RealNumber} + i";
            else if (ImaginaryUnit == -1)
                return $"{RealNumber} - i";

            return (ImaginaryUnit >= 0) ? $"{RealNumber} + {ImaginaryUnit}i" :
                                            $"{RealNumber} - {Math.Abs(ImaginaryUnit)}i";
        }

        public Complexing Add(Complexing other)
        {
            return new Complexing(RealNumber + other.RealNumber, ImaginaryUnit + other.ImaginaryUnit);
        }

        public static Complexing operator +(Complexing z1, Complexing z2)
        {
            return new Complexing(z1.RealNumber + z2.RealNumber, z1.ImaginaryUnit + z2.ImaginaryUnit);
        }

        public Complexing Minus(Complexing other)
        {
            return new Complexing(RealNumber - other.RealNumber, ImaginaryUnit - other.ImaginaryUnit);
        }

        public static Complexing operator -(Complexing z1, Complexing z2)
        {
            return new Complexing(z1.RealNumber - z2.RealNumber, z1.ImaginaryUnit - z2.ImaginaryUnit);
        }

        public Complexing Multiplication(Complexing other)
        {
            double newRealNumber = RealNumber * other.RealNumber - ImaginaryUnit * other.ImaginaryUnit;
            double newImaginaryUnit = RealNumber * other.ImaginaryUnit + ImaginaryUnit * other.RealNumber;
            return new Complexing(newRealNumber, newImaginaryUnit);
        }

        public static Complexing operator *(Complexing z1, Complexing z2)
        {
            double newRealNumber = z1.RealNumber * z2.RealNumber - z1.ImaginaryUnit * z2.ImaginaryUnit;
            double newImaginaryUnit = z1.RealNumber * z2.ImaginaryUnit + z1.ImaginaryUnit * z2.RealNumber;
            return new Complexing(newRealNumber, newImaginaryUnit);
        }

        public Complexing Divide(Complexing other)
        {
            double newRealNumber = (RealNumber * other.RealNumber + ImaginaryUnit * other.ImaginaryUnit) /
                                                (other.RealNumber * other.RealNumber + other.ImaginaryUnit * other.ImaginaryUnit);
            double newImaginaryUnit = (other.RealNumber * ImaginaryUnit - RealNumber * other.ImaginaryUnit) /
                                                (other.RealNumber * other.RealNumber + other.ImaginaryUnit * other.ImaginaryUnit);
            return new Complexing(newRealNumber, newImaginaryUnit);
        }

        public static Complexing operator /(Complexing z1, Complexing z2)
        {
            double newRealNumber = (z1.RealNumber * z2.RealNumber + z1.ImaginaryUnit * z2.ImaginaryUnit) /
                                    (z2.RealNumber * z2.RealNumber + z2.ImaginaryUnit * z2.ImaginaryUnit);
            double newImaginaryUnit = (z2.RealNumber * z1.ImaginaryUnit - z1.RealNumber * z2.ImaginaryUnit) /
                                                (z2.RealNumber * z2.RealNumber + z2.ImaginaryUnit * z2.ImaginaryUnit);
            return new Complexing(newRealNumber, newImaginaryUnit);
        }
    }
}
