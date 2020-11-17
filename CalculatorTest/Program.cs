using System;

namespace CalculatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int operation

            Console.WriteLine("Enter 1 to add");
            Console.WriteLine("Enter 2 to sub");
            Console.WriteLine("Enter 3 to mult");
            Console.WriteLine("Enter 4 to divide");
            Console.WriteLine("Enter 5 to modulus");

            Console.Write("Please enter first number: ");

            calculator.FirstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter second number: ");
            calculator.SecondNumber = Convert.ToDouble(Console.ReadLine());




            Console.WriteLine($"Calling Add method gives - {calculator.add()}");
            Console.WriteLine($"Calling Add method gives - {calculator.sub()}");
            Console.WriteLine($"Calling Add method gives - {calculator.Multiply()}");
            Console.WriteLine($"Calling Add method gives - {calculator.Divide()}");
            Console.WriteLine($"Calling Add method gives - {calculator.Modulus()}");

            Console

        }
    }
}
