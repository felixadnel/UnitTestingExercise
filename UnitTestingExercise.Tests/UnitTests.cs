using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(0, 1, 1, 2)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-1, -1, -1, -3)]
        [InlineData(-2, 1, 1, 0)]
        public void Add(int num1, int num2, int numb3, int expected)
        {
            var test = new UnitTestMethods();

            var actual = test.Add(num1, num2, numb3);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(0, 1, -1)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -1, 0)]
        [InlineData(-2, 1, -3)]
        public void SubtractTest(int minuend, int subtrend, int expected)
        {
            var tester = new UnitTestMethods();

            var actual = tester.Subtract(minuend, subtrend);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(0, 1, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -1, 1)]
        [InlineData(-2, 1, -2)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            var test = new UnitTestMethods();

            var actual = test.Multiply(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20,5,4)]
        public void DivideTest(int num1, int num2, int expected)
        {
            var tester = new UnitTestMethods();

            var actual = tester.Divide(num1, num2);

            Assert.Equal(expected, actual);

        }

    }

}

