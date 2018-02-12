using System;

namespace ConsoleApp1
{
    public class Fraction
    {
        private int _n;
        private int _d;

        public int Numerator
        {
            get { return _n; }
            set { _n = value; }
        }
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
            this._n = n;
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
            return (double) f._n / f._d;
        }

        public override String ToString()
        {
            return $"{_n} / {_d}";
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1._n * f2._n, f1._d * f2._d);
        }


    }
}