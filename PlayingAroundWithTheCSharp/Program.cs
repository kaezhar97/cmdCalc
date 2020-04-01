using System;

namespace PlayingAroundWithTheCSharp
{
    class Program
    {

        public int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, there Octavio. Welcome back!");

            Program program = new Program();

            int sum = program.Add(1, 2);

            Console.WriteLine("The sum of 1 and 2 is " + sum);
        }
    }
}
