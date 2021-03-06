﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpKatas
{
    public class Calculator
    {
        public int SumNumbers(int start, int count)
        {
            try
            {
                IEnumerable<int> rangeNumbers = Enumerable.Range(start, count);
                return rangeNumbers.Aggregate((a, b) => a + b); //Sum performance is better http://stackoverflow.com/questions/11030109/aggregate-vs-sum-performance-in-linq
            }
            catch (System.Exception)
            {
                return 0;
            }
        }
    }

    [TestFixture]
    [Ignore]
    public class Test
    {
        [Test]
        public void SumNumbers_StartAt100SumNext1_TotalIs100()
        {
            var kata = new Calculator();
            Assert.AreEqual(100, kata.SumNumbers(100, 1));
        }

        [Test]
        public void SumNumbers_StartAt100SumNext2_TotalIs201()
        {
            var kata = new Calculator();
            Assert.AreEqual(201, kata.SumNumbers(100, 2));
        }
        [Test]
        public void SumNumbers_StartAt100SumNext0_TotalIs0()
        {
            var kata = new Calculator();
            Assert.AreEqual(0, kata.SumNumbers(100, 0));
        }

        [Test]
        public void SumNumbers_StartAt0SumNext0_TotalIs0()
        {
            var kata = new Calculator();
            Assert.AreEqual(0, kata.SumNumbers(0, 0));
        }

        [Test]
        public void SumNumbers_StartAt0SumNext3_TotalIs3()
        {
            var kata = new Calculator();
            Assert.AreEqual(3, kata.SumNumbers(0, 3));
        }

        [Test]
        public void SumNumbers_StartAt0SumNext100_TotalIs5050()
        {
            var kata = new Calculator();
            Assert.AreEqual(5050, kata.SumNumbers(1, 100));
        }

        [Test]
        public void SumNumbers_NextIsNegative_TotalIs0()
        {
            var kata = new Calculator();
            Assert.AreEqual(0,kata.SumNumbers(1, -100));
        }

        [Test]
        public void SumNumbers_StartAtInt32MaxValueSumNext2_TotalIs0()
        {
            var kata = new Calculator();
            Assert.AreEqual(0,kata.SumNumbers(Int32.MaxValue, 2));
        }
    }
}
