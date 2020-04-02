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
        }

        bool ValidateUserInput()
        {
            return false;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
