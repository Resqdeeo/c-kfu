using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Resqd
{
    public class Complexing
    {
        private double rez;
        private double inz;

        public Complexing(double rez, double inz)
        {
            this.rez = rez;
            this.inz = inz;
        }


        public Complexing(double rez)
        {
            this.rez = rez;
            this.inz = 0;
        }


        public Complexing()
        {
            this.rez = 0;
            this.inz = 0;
        }


        public double Rez
        {
            get { return rez; }
            set { rez = value; }
        }


        public double Inz
        {
            get { return inz; } 
            set { inz = value; }
        }


        public double Mod
        {
            get { return Math.Sqrt(rez * rez + inz * inz); }
        }


        public double Arg
        {
            get { return Math.Acos(rez / Mod); }
        }


        public void Add(Complexing comp1, Complexing comp2)
        {
            this.rez = comp1.rez + comp2.rez;
            this.inz = comp1.inz + comp2.inz;
        }


        public void Multy(Complexing comp1, Complexing comp2)
        {
            this.rez = comp1.rez * comp2.rez - comp1.inz * comp2.inz;
            this.inz = comp1.inz * comp2.rez + comp2.inz * comp1.rez;
        }


        public void Div(Complexing comp1, Complexing comp2)
        {

        }


        public override string ToString()
        {
            if (this.Rez == 0) { return $"{Rez}"; }
            if (this.Inz == 0) { return $"{Inz}i"; }
            if (this.Inz < 0) { return $"{Rez} - {-Inz}i"; }
            return $"{Rez} + {Inz}i";
        }
    }
}
