using System;

namespace CalculatorProjectMaiseichyk
{
    internal class CalculatorLogic
    {
        private const string Sum = "+";
        private const string Minus = "-";
        private const string Multiply = "*";
        private const string Divide = "/";
        private const string Remainder = "%";

        public void CalculatorStart()
        {
            Console.WriteLine("Вас встречает приложение калькулятор.");
            bool stopWord = false;
            while (!stopWord)
            {
                Console.WriteLine("Желаете продолжить? +/-");
                string continueProgram = Console.ReadLine();
                if (continueProgram.Equals("-"))
                {
                    Console.WriteLine("Досвидания");
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("Выберите тип операции (+,-,/,*,%): ");
                string choosen = Console.ReadLine();
                double firstNumber;
                double secondNumber;
                try
                {
                    Console.WriteLine("Введите первое число: ");
                    firstNumber = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    secondNumber = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Введите число" + " " + ex.Message);
                    continue;
                }
                double resultCalculated = default;
                switch (choosen)
                {
                    case Sum:
                        resultCalculated = CalculatorSum(firstNumber, secondNumber);
                        break;
                    case Minus:
                        resultCalculated = CalculatorMinus(firstNumber, secondNumber);
                        break;
                    case Divide:
                        resultCalculated = CalculatorDivide(firstNumber, secondNumber);
                        break;
                    case Multiply:
                        resultCalculated = CalculatorMultiply(firstNumber, secondNumber);
                        break;
                    case Remainder:
                        resultCalculated = CalculatorRemainder(firstNumber, secondNumber);
                        break;
                    default:
                        Console.WriteLine("Операция не опознана, повторите попытку.");
                        break;
                }
                Console.WriteLine($"Результат вашей операции: {resultCalculated}");
                Console.ReadKey();
            }
        }

        private double CalculatorSum(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }
        private double CalculatorMinus(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            return result;
        }
        private double CalculatorMultiply(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            return result;
        }
        private double CalculatorDivide(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            return result;
        }
        private double CalculatorRemainder(double firstNumber, double secondNumber)
        {
            double result = firstNumber % secondNumber;
            return result;
        }
    }
}
