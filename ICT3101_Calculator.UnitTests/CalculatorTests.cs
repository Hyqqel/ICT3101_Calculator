using ICT3101_Calculator;
using NUnit.Framework;
using System;

namespace ICT3101_Caculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToSubtract()
        {
            // Act
            double result = _calculator.Subtract(32, 7);
            // Assert
            Assert.That(result, Is.EqualTo(25));
        }
        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToMultiply()
        {
            // Act
            double result = _calculator.Multiply(5, 2);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToDivide()
        {
            // Act
            double result = _calculator.Divide(12, 2);
            // Assert
            Assert.That(result, Is.EqualTo(6));
        }


        [Test]
        public void Add_WhenAddingTwoNumbersWithZeroInput_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 0);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void Subtract_WhenSubtractingTwoNumbersWithZeroInput_ResultEqualToSubtract()
        {
            // Act
            double result = _calculator.Subtract(10, 0);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void Multiply_WhenMultiplyingTwoNumbersWithZeroInput_ResultEqualToMultiply()
        {
            // Act
            double result = _calculator.Multiply(10, 0);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
        /*
         * 15a
         */
        [Test]
        public void Divide_WithNegativeInputs_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.Divide(0, 0), Throws.ArgumentException);
        }
        /*
         * 
         * 
         * 
         * 
         * 
         */
        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        }

        [Test]
        public void Factorial_WithCalculatingFactorial_ResultReturnCorrectValue()
        {
            double result = _calculator.Factorial(5);
            Assert.That(result, Is.EqualTo(5*4*3*2*1));
        }
        /*
         * 16
         */
        [Test]
        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(-100)]
        public void Factorial_WithNegativeInputs_ResultThrowArgumentException(int a)
        {
            Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void Factorial_WithZeroOrOneInput_ResultReturnOne(int a)
        {
            double result = _calculator.Factorial(a);
            Assert.That(result, Is.EqualTo(1));
        }
        /*
         * 17a
         */

        [Test]
        public void TriangleArea_WhenCalculatingArea_ResultReturnCorrect()
        {
            double result = _calculator.TriangleArea(3, 4);
            Assert.That(result, Is.EqualTo((3 * 4) / 2));
        }
        [Test]
        [TestCase(-3, 4)]
        [TestCase(3, -4)]
        [TestCase(0, 4)]
        [TestCase(3, 0)]
        public void TriangleArea_WhenCalculatingAreaWithNegativeOrZero_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.TriangleArea(a, b), Throws.ArgumentException);
        }
        /*
         * 17b
         */
        [Test]
        public void CircleArea_WhenCalculatingArea_ResultReturnCorrect()
        {
            double result = _calculator.CircleArea(4);
            Assert.That(result, Is.EqualTo(Math.PI * Math.Pow(4, 2)));
        }
        [Test]
        [TestCase(-3)]
        [TestCase(0)]
        public void CircleArea_WhenCalculatingAreaWithNegativeOrZero_ResultThrowArgumentException(int a)
        {
            Assert.That(() => _calculator.CircleArea(a), Throws.ArgumentException);
        }
        /*
         * 18a
         */
        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumentException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumentException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }
        /*
         * 18b
         */
        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }
    }
}