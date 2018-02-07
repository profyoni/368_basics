using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fraction
    {
        private int n, d;

        public Fraction(int n, int d)
        {
            this.n = n;
            this.d = d;
        }
        public static implicit operator Fraction(int n) 
        {
            return new Fraction(n, 1);
        }

        public override String ToString()
        {
            return $"{n} / {d}";
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.n * f2.n, f1.d * f2.d);
        }


    }
    class Program
    {
        public static void Swap(ref int a, ref int b)
        {
            Console.WriteLine($"Swap: {a},{b}");
            int t = a;
            a = b;
            b = t;
            Console.WriteLine($"Swap: {a},{b}");
        }

        public static bool ParseInt(String s, out int i)
        {
            try
            {
                i = Int32.Parse(s);
                return true;
            }
            catch (Exception)
            {
                i = 0;
                return false;
            }  
        }

        static Tuple<string, int> tupleCreator()
        {
            return new Tuple<string, int>("Bob", 613);
        }

        //static (int, int) GetDivisionResults(int number, int divisor)
        //{

        //    int quotient = number / divisor;
        //    int remainder = number % divisor;
        //    return (quotient, remainder);
        //}
        //public static (string,string) RandomPoint()
        //{
        //    return ("","");
        //}
        static void Main(string[] args)
        {
            while (true)
                ;
            var sList = new List<string>();

            sList.Add("10");
            sList.AddRange(new []{ "2", "4", "77" });
            sList.AddRange(sList.GetRange(1,3));

            Console.WriteLine(sList.Count);

            foreach (var e in sList.OrderBy(elt => Int32.Parse(elt)))
                Console.WriteLine(e);

            var dic = new Dictionary<string, int>();

            dic["C"] = 3;
            dic.Add("B", 2);
            dic.Add("A", 1);

            foreach ( var val in dic.Keys)
            {
                Console.WriteLine(val);
            }

            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(2, 3);

            Console.WriteLine((f1 * f2) * 1);
            Console.WriteLine(3 * f1 * f2);

            if ("A" == new string(new[] { 'A' }) )
            {
                Console.WriteLine("WPW");
            }

            Console.ReadKey();

        }

        static void Main2(string[] args)
        {
            int? x1;
            x1 = null;
            x1 = 7;

            int y = x1??0 + 4;
            string s = null;
            if (DateTime.UtcNow.Day == 15)
            {
                s = "Tu Bishvat";
            }
            Console.WriteLine(s + "X"); // null conditional operator


            //int x = 1, y = 2;
            //Console.WriteLine($"Main: {x},{y}");
            //Swap(ref x, ref y);
            //Console.WriteLine($"Main: {x},{y}");

            String num = "99";
            ParseInt(num, out int x);
            Console.WriteLine(x);

            var t = tupleCreator();
            Console.WriteLine(t.Item1);

            Console.ReadKey();
        }
    }
}
