using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Korpozim.Math.Tests
{
    public class BasicMathTests
    {
        [Fact]
        public void Should_True_Empty_Sum()
        {
            //Arrange
            double zero = 0;
            double sum;

            //Act
            sum = BasicMath.Sum();

            //Assert
            Assert.Equal(zero, sum);
        }

        [Fact]
        public void Should_True_One_Number_Sum()
        {
            //Arrange
            double oneNumber = 3;
            double sum;

            //Act
            sum = BasicMath.Sum(oneNumber);

            //Assert
            Assert.Equal(oneNumber, sum);
        }

        [Fact]
        public void Should_True_Two_Number_Sum()
        {
            //Arrange
            double oneNumber = 5;
            double twoNumber = 7;
            double sumNumber;
            double sum;

            //Act
            sumNumber = oneNumber + twoNumber;
            sum = BasicMath.Sum(oneNumber, twoNumber);

            //Assert
            Assert.Equal(sumNumber, sum);
        }

        [Fact]
        public void Should_True_Three_Number_Sum()
        {
            //Arrange
            double oneNumber = 3;
            double twoNumber = 5;
            double threeNumber = 44;
            double sumNumber;
            double sum;

            //Act
            sumNumber = oneNumber + twoNumber + threeNumber;
            sum = BasicMath.Sum(oneNumber, twoNumber, threeNumber);

            //Assert
            Assert.Equal(sumNumber, sum);
        }

        [Fact]
        public void Should_True_Two_Number_Difference()
        {
            //Arrange
            double oneNumber = 5;
            double twoNumber = 66;
            double differenceNumber;
            double difference;

            //Act
            differenceNumber = oneNumber - twoNumber;
            difference = BasicMath.Difference(oneNumber, twoNumber);

            //Assert
            Assert.Equal(differenceNumber, difference);
        }

        [Fact]
        public void Should_True_Emtpy_Multiplication()
        {
            //Arrange
            double multiplication;
            double multiplicationNumber;

            //Act
            multiplicationNumber = 1;
            multiplication = BasicMath.Multiplication();

            //Assert
            Assert.Equal(multiplicationNumber, multiplication);
        }

        [Fact]
        public void Should_True_One_Number_Multiplication()
        {
            //Arrange
            double oneNumber = 76;
            double multiplication;

            //Act
            multiplication = BasicMath.Multiplication(oneNumber);

            //Assert
            Assert.Equal(oneNumber, multiplication);
        }

        [Fact]
        public void Should_True_Two_Number_Multiplication()
        {
            //Arrange
            double oneNumber = 3;
            double twoNumber = 9;
            double multiplicationNumber;
            double multiplication;

            //Act
            multiplicationNumber = oneNumber * twoNumber;
            multiplication = BasicMath.Multiplication(oneNumber, twoNumber);

            //Assert
            Assert.Equal(multiplicationNumber, multiplication);
        }

        [Fact]
        public void Should_True_Three_Number_Multiplication()
        {
            //Arrange
            double oneNumber = 4;
            double twoNumber = 6;
            double threeNumber = 333;
            double multiplicationNumber;
            double multiplication;

            //Act
            multiplicationNumber = oneNumber * twoNumber * threeNumber;
            multiplication = BasicMath.Multiplication(oneNumber, twoNumber, threeNumber);

            //Assert
            Assert.Equal(multiplicationNumber, multiplication);
        }

        [Fact]
        public void Should_True_Two_Number_Division()
        {
            //Arrange
            double oneNumber = 65;
            double twoNumber = 77;
            double divisionNumber;
            double division;

            //Act
            divisionNumber = oneNumber / twoNumber;
            division = BasicMath.Division(oneNumber, twoNumber);

            //Assert
            Assert.Equal(divisionNumber, division);
        }

        [Fact]
        public void Should_True_Zero_First_Number_Division()
        {
            //Arrange
            double oneNumber = 0;
            double twoNumber = 5;
            double divisionNumber = 0;
            double division;

            //Act
            division = BasicMath.Division(oneNumber, twoNumber);

            //Assert
            Assert.Equal(divisionNumber, division);
        }

        [Fact]
        public void Should_True_Zero_Second_Number_Division()
        {
            //Arrange
            double oneNumber = 5;
            double twoNumber = 0;
            double divisionNumber = 1;
            double division;

            //Act
            division = BasicMath.Division(oneNumber, twoNumber);

            //Assert
            Assert.Equal(divisionNumber, division);
        }

        [Fact]
        public void Should_True_Zero_One_And_Second_NUmber_Division()
        {
            //Arrange
            double oneNumber = 0;
            double twoNumber = 0;
            double divisionNumber = 1;
            double division;

            //Act
            division = BasicMath.Division(oneNumber, twoNumber);

            //Assert
            Assert.Equal(divisionNumber, division);
        }
    }
}
