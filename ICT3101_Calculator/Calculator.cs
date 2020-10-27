using System;
using System.Collections.Generic;
using System.Text;

namespace ICT3101_Calculator
{
    public class Calculator
    {
        public Calculator() { }
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    result = Factorial(num1);
                    break;
                case "t":
                    result = TriangleArea(num1, num2);
                    break;
                case "c":
                    result = CircleArea(num1);
                    break;
                case "ua":
                    result = UnknownFunctionA(num1, num2);
                    break;
                case "ub":
                    result = UnknownFunctionB(num1, num2);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            return (num1 + num2);
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            //to check if any of the number is 0
            if (num1 == 0 || num2 == 0)
            {
                throw new ArgumentException();
            }
            return (num1 / num2);
        }
        public double Factorial(double num1)
        {
            if (num1 < 0)
            {
                throw new ArgumentException();
            }
            if (num1 <= 1)
            {
                return 1;
            }
            double curResult = 1;
            for (int i = 2; i <= num1; i++)
            {
                curResult = curResult * i;
            }
            return curResult;
        }
        public double TriangleArea(double num1, double num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                throw new ArgumentException();
            }
            return (num1 * num2) / 2;
        }
        public double CircleArea(double num1)
        {
            if (num1 <= 0)
            {
                throw new ArgumentException();
            }
            return Math.PI * Math.Pow(num1, 2);
        }

        // 2 Factorials, 1 Divide, 1 Subtract
        public double UnknownFunctionA(double num1, double num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                throw new ArgumentException();
            }
            return Divide(Factorial(num1), Factorial(Subtract(num1, num2)));
        }

        // 3 Factorials, 1 Divide, 1 Multiply, 1 Subtract
        public double UnknownFunctionB(double num1, double num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                throw new ArgumentException();
            }
            return Divide(Factorial(num1), Multiply(Factorial(num2), Factorial(Subtract(num1, num2))));
        }
        public double MTBF(double MTTF, double MTTR)
        {
            if (MTTF > 0 && MTTR > 0)
            {
                return MTTF + MTTR;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public double Availability(double MTTF, double MTBF)
        {
            if (MTTF > 0 && MTBF > 0)
            {
                return MTTF / MTBF;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public double CurrentFailure(double initialFailure, double currentFailure, double totalFailure)
        {
            double result = initialFailure * (1 - currentFailure / totalFailure);
            return Math.Round(result);
        }

        public double AverageFailure(double initialFailure, double totalFailure, double time)
        {
            double result = totalFailure * (1 - Math.Exp(-(initialFailure / totalFailure * time)));
            return Math.Round(result);
        }

        public double GenMagicNum(double input, IFileReader fileReader)
        {
            double result = 0;
            int choice = Convert.ToInt16(input);
            //Dependency------------------------------
            //FileReader getTheMagic = new FileReader();

            //----------------------------------------
            //string[] magicStrings = getTheMagic.Read("MagicNumbers.txt");
            string[] magicStrings = fileReader.Read("C:/Users/hyqqel/Desktop/ICT3101/Lab/ICT3101_Calculator_Lab4/ICT3101_Calculator_Lab4/ICT3101_Calculator/MagicNumbers.txt");
            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            return result;
        }

    }
}
