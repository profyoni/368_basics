using System;
using System.Threading;
using ConsoleApp1;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{

    [TestClass]
    public class FractionTest
    {

        [TestMethod]
        public void operatorTimes()
        {
          
            //AAA
            var half = new Fraction(1, 2);
            var _3_14 = new Fraction();
            _3_14.Numerator = 3;
            _3_14.Denominator = 14;

            var actual = half * _3_14;

            actual.Numerator.Should().Be(3);
            actual[0].Should().Be(3);
            actual["n".ToUpper()].Should().Be(3);

            actual.Denominator.Should().Be(28);
            actual[1].Should().Be(28);
        }

        [TestMethod]
        public void toString()
        {
            //AAA
            var half = new Fraction(1, 2);

            half.ToString().Should().Be("1 / 2");
        }

        [TestMethod]
        public void MyReverse()
        {
            "ABC".MyReverse().Should().Be("CBA");
        }

        [Ignore]
        [TestMethod]
        public void N2N()
        {
            2.NToTheNth().Should().Be(4);
            3.NToTheNth().Should().Be(27);
        }

    }
}
