using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;

            Console.WriteLine("Console calculator in C#");

            Console.WriteLine("Type the value for the first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type the value for the second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose one of the following oppinions from the list");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\tb - Subtract");
            Console.WriteLine("\tc - Divide");
            Console.WriteLine("\td - Multiply");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "b":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "c":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
            }
           Console.Write("Press any key to close the Calculator console app...");
           Console.ReadKey();
        }
    }
}
