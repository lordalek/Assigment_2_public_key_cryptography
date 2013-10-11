using System;
using Assigment2.Models;
using NUnit.Core;
using NUnit.Framework;

namespace ModelTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var numberA = new ReallyBigNumber("12");
            numberA.Multiply(2);
            var number24 = new ReallyBigNumber("24");
            Assert.IsTrue(number24.Equals(numberA));
        }

        [Test]
        public void TestMultiplyForOverload()
        {
            var numberA = new ReallyBigNumber("16");
            numberA.Multiply(2);
            var number32 = new ReallyBigNumber("32");
            Assert.IsTrue(number32.Equals(numberA));
        }

        [Test]
        public void TestMultiplyByThree()
        {
            var numberA = new ReallyBigNumber("16");
            numberA.Multiply(3);
            var number48 = new ReallyBigNumber("48");
            Assert.IsTrue(number48.Equals(numberA));
        }

        [Test]
        public void TestMultiplyForThreeOverFLows()
        {
            var numberA = new ReallyBigNumber("999");
            numberA.Multiply(2);
            var number1998 = new ReallyBigNumber("1998");
            Assert.IsTrue(number1998.Equals(numberA));
        }

        [Test]
        public void TestFor0inMultiply()
        {
            var numberA = new ReallyBigNumber("12");
            numberA.Multiply(0);
            var number0 = new ReallyBigNumber("0");
            Assert.IsTrue(numberA.Equals(number0));
        }

        [Test]
        public void TestMultiplyWithLaaaargeNumbero()
        {
            var largenumbero = new ReallyBigNumber("12345678901239043252435823475812341342528452342354");
            largenumbero.Multiply(2);
            var doublethatlargeroNUmber = new ReallyBigNumber("24691357802478086504871646951624682685056904684708");
            Assert.IsTrue(doublethatlargeroNUmber.Equals(largenumbero));
        }

        [Test]
        public void TestSubtraction_2_minus_1()
        {
            var number2 = new ReallyBigNumber("2");
            number2.Subtraction(1);
            Assert.IsTrue(new ReallyBigNumber("1").Equals(number2));
        }

        [Test]
        public void TestSubtraction_11_minus_8()
        {
            var number11 = new ReallyBigNumber("11");
            number11.Subtraction(8);
            Assert.IsTrue(new ReallyBigNumber("3").Equals(number11));
        }

        [Test]
        public void TestSubtraction_100_minus_99()
        {
            var number100 = new ReallyBigNumber("100");
            number100.Subtraction(99);
            Assert.IsTrue(new ReallyBigNumber("1").Equals(number100));
        }

        [Test]
        public void CheckIsBuggerThaN_1_8()
        {
            var number8 = new ReallyBigNumber("8");
            Assert.IsTrue(number8.Remainder(1));
        }

        [Test]
        public void CheckIsBuggerThaN_8_1()
        {
            var number8 = new ReallyBigNumber("1");
            Assert.IsFalse(number8.Remainder(8));
        }

        [Test]
        public void TestIfEqualNumbersAreBigger_9_9()
        {
            var number9 = new ReallyBigNumber("9");
            Assert.IsTrue(number9.Remainder(9));
        }

        [Test]
        public void TestIfDivide8by2equals4()
        {
            var number8 = new ReallyBigNumber("8");
            number8.Division(2);
            Assert.IsTrue(number8.Equals(new ReallyBigNumber("0")));
        }
    }
}