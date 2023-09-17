using System;

namespace CalculatorProjectMaiseichyk
{
    internal class CalculatorLogic
    {
        private const string Sum = "+";
        private const string Minus = "-";
        private const string Multiply = "*";
        private const string Divide = "/";
        private const string Ostator = "%";

        public void CalculatorStart()
        {
            bool stopWord = false;

            while (!stopWord)
            {
                Console.WriteLine("Вас встречает приложение калькулятор." +
                "Желаете продолжить? +/-");
                string continueProgram = Console.ReadLine();
                if (continueProgram.Equals("-"))
                {
                    stopWord = true;
                    Console.WriteLine("Досвидания");
                    break;
                }
                Console.WriteLine("Выберите тип операции (+,-,/,*,%): ");
                string choosen = Console.ReadLine();
                Console.WriteLine("Введите первое число: ");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                string resultCalculated = default;
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
                    case Ostator:
                        resultCalculated = CalculatorOstatok(firstNumber, secondNumber);
                        break;
                    default:
                        Console.WriteLine("Операция не опознана, повторите попытку.");
                        break;
                }
                Console.WriteLine($"Результат вашей операции: {resultCalculated}");
                Console.ReadKey();
            }
        }

        private string CalculatorSum(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result.ToString();
        }
        private string CalculatorMinus(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            return result.ToString();
        }
        private string CalculatorMultiply(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            return result.ToString();
        }
        private string CalculatorDivide(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            return result.ToString();
        }
        private string CalculatorOstatok(double firstNumber, double secondNumber)
        {
            double result = firstNumber % secondNumber;
            return result.ToString();
        }
    }
}
