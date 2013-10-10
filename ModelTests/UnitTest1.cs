﻿using System;
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
    }
}
