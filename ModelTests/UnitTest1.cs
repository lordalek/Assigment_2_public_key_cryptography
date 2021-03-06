﻿using System;
using System.Security.Cryptography;
using System.Threading;
using Assigment2.Models;
using NUnit.Core;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using RSA = Assigment2.Logic.RSA;

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
            Assert.IsTrue(numberA.Equals(new ReallyBigNumber("12")));
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
            Assert.IsTrue(number8.IsBiggerOrEqualThan(new ReallyBigNumber("1").Numbers));
        }

        [Test]
        public void CheckIsBuggerThaN_8_1()
        {
            var number8 = new ReallyBigNumber("1");
            Assert.IsFalse(number8.IsBiggerOrEqualThan(new ReallyBigNumber("8").Numbers));
        }

        [Test]
        public void TestIfEqualNumbersAreBigger_9_9()
        {
            var number9 = new ReallyBigNumber("9");
            Assert.IsTrue(number9.IsBiggerOrEqualThan(new ReallyBigNumber("9").Numbers));
        }

        [Test]
        public void TestIfDivide8by2equals0()
        {
            var number8 = new ReallyBigNumber("8");
            number8.Remainder(2);
            Assert.IsTrue(number8.Equals(new ReallyBigNumber("0")));
        }

        [Test]
        public void TestRemainerof8_3_should_2()
        {
            var number8 = new ReallyBigNumber("8");
            number8.Remainder(3);
            Assert.IsTrue(number8.Equals(new ReallyBigNumber("2")));
        }

        [Test]
        public void TestRemainerOfDoubleDigits()
        {
            var number88 = new ReallyBigNumber("88");
            number88.Remainder(10);
            Assert.IsTrue(number88.Equals(new ReallyBigNumber("8")));
        }


        [Test]
        public void TestRemainerof100_3_should_1()
        {
            var number8 = new ReallyBigNumber("100");
            number8.Remainder(3);
            Assert.IsTrue(number8.Equals(new ReallyBigNumber("1")));
        }

        [Test]
        public void TestRemainderOfTripleDigits()
        {
            var number888 = new ReallyBigNumber("888");
            number888.Remainder(10);
            Assert.IsTrue(number888.Equals(new ReallyBigNumber("8")));
        }

        [Test]
        public void TestRemainderOfTripleDigitsAndTrippleDenominator()
        {
            var number888 = new ReallyBigNumber("888");
            number888.Remainder(100);
            Assert.IsTrue(number888.Equals(new ReallyBigNumber("88")));
        }

        [Test]
        public void Add1To1Expect2()
        {
            var number1 = new ReallyBigNumber("1");
            number1.Addition(1);
            Assert.IsTrue(number1.Equals(new ReallyBigNumber("2")));
        }

        [Test]
        public void Add1To9Expect10()
        {
            var number1 = new ReallyBigNumber("9");
            number1.Addition(1);
            Assert.IsTrue(number1.Equals(new ReallyBigNumber("10")));
        }

        [Test]
        public void Add1To99Expect100()
        {
            var number1 = new ReallyBigNumber("99");
            number1.Addition(1);
            Assert.IsTrue(number1.Equals(new ReallyBigNumber("100")));
        }

        [Test]
        public void Add91To99Expect190()
        {
            var number1 = new ReallyBigNumber("99");
            number1.Addition(91);
            Assert.IsTrue(number1.Equals(new ReallyBigNumber("190")));
        }

        [Test]
        public void OneIsSmallerThan2()
        {
            Assert.IsTrue(new ReallyBigNumber("2").IsSmallerOrEqualThanHalf(new ReallyBigNumber("1")));
        }

        [Test]
        public void FourIsSmallerThan10()
        {
            Assert.IsTrue(new ReallyBigNumber("10").IsSmallerOrEqualThanHalf(new ReallyBigNumber("4")));
        }

        [Test]
        public void TestThat49IsSmallerThanHalfOf100()
        {
            Assert.IsTrue(new ReallyBigNumber("100").IsSmallerOrEqualThanHalf(new ReallyBigNumber("49")));
        }

        [Test]
        public void TestThat51IsNotSmallerThanHalfOf100()
        {
            Assert.IsFalse(new ReallyBigNumber("100").IsSmallerOrEqualThanHalf(new ReallyBigNumber("51")));
        }

        [Test]
        public void Test400IsSmallerThan1000()
        {
            Assert.IsTrue(new ReallyBigNumber("1000").IsSmallerOrEqualThanHalf(new ReallyBigNumber("400")));
        }

        [Test]
        public void Test4000000435267463257667835646757736467578IsSmallerThan5123000435267463257667835646757736467578()
        {
            Assert.IsTrue(
                new ReallyBigNumber("88888888888888435267463257667835646757736467578").IsSmallerOrEqualThanHalf(
                    new ReallyBigNumber("4000000435267463257667835646757736467578")));
        }

        [Test]
        public void TestThat11IsaPrime()
        {
            Assert.IsTrue(new ReallyBigNumber("1").IsPrime(new ReallyBigNumber("11")));
        }

        [Test]
        public void TestThat12IsNotaPrime()
        {
            Assert.IsFalse(new ReallyBigNumber("1").IsPrime(new ReallyBigNumber("12")));
        }

        [Test]
        public void TEstThat2699isAPrime()
        {
            Assert.IsTrue(new ReallyBigNumber("1").IsPrime(new ReallyBigNumber("2699")));
        }

        [Test]
        public void TEstThat2698isNotAPrime()
        {
            Assert.IsFalse(new ReallyBigNumber("1").IsPrime(new ReallyBigNumber("2698")));
        }

        [Test]
        public void Test10M10AsBigNumberExpect100()
        {
            Assert.IsTrue(new ReallyBigNumber("10").Multiply(new ReallyBigNumber("10")).Equals(new ReallyBigNumber("100")));
        }

        [Test]
        public void Test10M15AsBigNumberExpect150()
        {
            Assert.IsTrue(new ReallyBigNumber("10").Multiply(new ReallyBigNumber("15")).Equals(new ReallyBigNumber("150")));
        }

        [Test]
        public void TEst100T200expect20000()
        {
            Assert.IsTrue(new ReallyBigNumber("100").Multiply(new ReallyBigNumber("200")).Equals(new ReallyBigNumber("20000")));
        }

        [Test]
        public void TEst1000T2000expect2000000()
        {
            Assert.IsTrue(new ReallyBigNumber("1000").Multiply(new ReallyBigNumber("2000")).Equals(new ReallyBigNumber("2000000")));
        }

        [Test]
        public void TEst1234T2234expect2756756()
        {
            Assert.IsTrue(new ReallyBigNumber("1234").Multiply(new ReallyBigNumber("2234")).Equals(new ReallyBigNumber("2756756")));
        }
//
//        [Test]
//        public void TestCalculationOfNForOverFlow()
//        {
//            string errorM = string.Empty;
//            try
//            {
//            var rsa = new RSA();
//            rsa.CalculateN(new ReallyBigNumber("1234523424523455134"), new ReallyBigNumber("3006666666"));
//            }
//            catch (Exception ex)
//            {
//                errorM = ex.Message;
//            }
//
//            Assert.IsNotNullOrEmpty(errorM);
//        }

        [Test]
        public void testGCDfor21And14()
        {
            var gcd = new ReallyBigNumber("6").GetGlobalCommonDenominator(new ReallyBigNumber("14"),
                new ReallyBigNumber("21"));
            Assert.IsFalse(new ReallyBigNumber("1").Equals(gcd));
        }

        [Test]
        public void testGCDfor14And15()
        {
            var gcd = new ReallyBigNumber("15").GetGlobalCommonDenominator(new ReallyBigNumber("15"),
                new ReallyBigNumber("14"));
            Assert.IsTrue(new ReallyBigNumber("1").Equals(gcd));
        }

        [Test]
        public void TestEncrpyForByteValues()
        {
            var rsa = new RSA();
            var bytes = rsa.EncrpyptDoubleBlock(new ReallyBigNumber("1000"), "Ha", new ReallyBigNumber("3"));

        }

        [Test]
        public void TestPowOf3pow3()
        {
            Assert.IsTrue(new ReallyBigNumber("3").Pow(3).Equals(new ReallyBigNumber("27")));
        }

        [Test]
        public void TestPow2of3()
        {
            Assert.IsTrue(new ReallyBigNumber("3").Pow(2).Equals(new ReallyBigNumber("9")));
        }

        [Test]
        public void TestPow6of4()
        {
            Assert.IsTrue(new ReallyBigNumber("4").Pow(6).Equals(new ReallyBigNumber("4096")));
        }
        [Test]
        public void TestMod3Pow2of4()
        {
            Assert.IsTrue(new ReallyBigNumber("4").ModPow(new ReallyBigNumber("3"), new ReallyBigNumber("2")).Equals(new ReallyBigNumber("1")));
        }

        [Test]
        public void TestMod23Pow2of5()
        {
            Assert.IsTrue(new ReallyBigNumber("5").ModPow(new ReallyBigNumber("23"), new ReallyBigNumber("2")).Equals(new ReallyBigNumber("2")));
        }

        [Test]
        public void TestDwithEAs7andPhiAs160Expect23()
        {
            var d = new RSA().DetermineDAs1AndSMallerThanPhi(new ReallyBigNumber("160"), new ReallyBigNumber("7"));
            Assert.IsTrue(d.Equals(new ReallyBigNumber("23")));
        }

        [Test]
        public void GetD()
        {
            var N = new ReallyBigNumber("11023");
            var E = new ReallyBigNumber("11");
            var phi = new ReallyBigNumber("10800");
            var d = new RSA().DetermineDAs1AndSMallerThanPhi(phi, E);
            Assert.IsTrue(!d.Equals(new ReallyBigNumber("0")));
        }
    }
}