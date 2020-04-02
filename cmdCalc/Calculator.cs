using System;
using cmdCalc.Enums;

namespace cmdCalc
{
    class Calculator
    {
        int Multiply(int a, int b)
        {
            return a * b;
        }
        
        int Add(int a, int b)
        {
            return a + b;
        }

        void Prompt()
        {
            Console.WriteLine("# ");
            string operation = Console.ReadLine();
            Operation userOperation = GetOperationFromUserInput(operation.ToLower());
        }

        Operation GetOperationFromUserInput(string userInput)
        {
            switch (userInput)
            {
                case "multiply":
                    return Operation.Multiply;
                default:
                    return Operation.Add;
            }
        }

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Prompt();
        }
    }
}
