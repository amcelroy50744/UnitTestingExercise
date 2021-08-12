using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(5,5,5,15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(18,14,4)]
        public void Subtract(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Subtract(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,4)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8,4,2)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(94,1.82,25.82)]
        public void Bmi(double num1, double num2, double expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Bmi(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7,49)]
        public void Sqr(int num1, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Sqr(num1);
            //Assert
            Assert.Equal(expected, actual);

            
        }
        [Fact]
        public void Add10() 
        {
            var test = new UnitTestMethods();

            var actual = test.Add10();

            Assert.Equal(10, actual);
        }

        [Fact]
        public void Message()
        {
            var test = new UnitTestMethods();

            var actual = test.Message();

            Assert.Equal("Good Morning", actual);
        }
    }
}
