using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.UnitTests
{
    [TestClass]
    public class CalculatorFunctionalityTests
    {
        [TestMethod]
        public void Plus_Addition_ReturnsCorrectNumber()
        {
            //Arrange
            var calculatorFunctionality = new CalculatorFunctionality();

            //Act
            var result = calculatorFunctionality.Plus((-15.6M), 15.2M);

            //Assert
            Assert.AreEqual((-0.4M),result);
        }

        [TestMethod]
        public void Minus_Subtraction_ReturnsCorrectNumber()
        {
            //Arrange
            var calculatorFunctionality = new CalculatorFunctionality();

            //Act
            var result = calculatorFunctionality.Minus(15.6M, (-15.2M));

            //Assert
            Assert.AreEqual((30.8M), result);
        }

        [TestMethod]
        public void Multiply_Multiplication_ReturnsCorrectNumber()
        {
            //Arrange
            var calculatorFunctionality = new CalculatorFunctionality();

            //Act
            var result = calculatorFunctionality.Multiply(15.6M, (-15.2M));

            //Assert
            Assert.AreEqual((-237.12M), result);
        }

        [TestMethod]
        public void Devide_Division_ReturnsCorrectNumber()
        {
            //Arrange
            var calculatorFunctionality = new CalculatorFunctionality();

            //Act
            var result = calculatorFunctionality.Devide(-15.6M, 2M);

            //Assert
            Assert.AreEqual((-7.8M), result);
        }

        [TestMethod]
        public void Devide_DivideBy0_ReturnsException()
        {
            //Arrange
            var calculatorFunctionality = new CalculatorFunctionality();

            //Act
            var result = calculatorFunctionality.Devide(2M, 0M);

            //Assert
            Assert.AreEqual((0M), result);
        }
    }
}
