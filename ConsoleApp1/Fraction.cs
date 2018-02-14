using System;
using System.Linq;

namespace ConsoleApp1
{
    // extension methods - extend the begavior of existing classes
    public static class Bob
    {
        public static string MyReverse(this string s)
        {
            return new String(s.Reverse().ToArray());
        }

        public static int NToTheNth(this int i)
        {
            return (int) Math.Pow(i, i);
        }
    }

    public class Fraction
    {
        public int this[int i]
        {
            get { return i == 0 ? Numerator : Denominator; }
            set
            {
                if (i == 0)
                    Numerator = value;
                else Denominator = value;
            }
        }
        public int this[string s]
        {
            get { return s == "N" ? Numerator : Denominator; }
            set
            {
                if (s == "N" || ReferenceEquals(s, "N"))
                    Numerator = value;
                else Denominator = value;
            }
        }

        public double Double
        {
            get
            {  
                return (double) Numerator / Denominator;
            }
        }

        public Fraction(Fraction that)
        {
            this.Denominator = that.Denominator;
            this.Numerator = that.Numerator;
        }

        private int _d;

        public int Numerator { get; set; } // auto property

        public int Denominator
        {
            get { return _d; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Gornisht not welcome");
                _d = value;
            }
        }

        public Fraction(int n = 0, int d = 1)
        {
            this.Numerator = n;
            this._d = d;
        }

        public static implicit operator Fraction(int n)
        {
            return new Fraction(n, 1);
        }

        public static explicit operator Fraction(double d)
        {
            const int accuracy = 10000;
            return new Fraction((int)(d * accuracy), accuracy);
        }

        public static explicit operator double(Fraction f)
        {
            return (double) f.Numerator / f._d;
        }

        public override String ToString()
        {
            return $"{Numerator} / {_d}";
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numerator * f2.Numerator, f1._d * f2._d);
        }


    }
}