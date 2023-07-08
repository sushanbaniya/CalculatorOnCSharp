using System;

namespace EntryPoint
{
    public class MainProgram
    {
        public static void Main()
        {
            Console.WriteLine("Enter First Number ");
            string firstNum = Console.ReadLine();
            int num1 = int.Parse(firstNum);

            Console.WriteLine("Enter Operator ");
            string op = Console.ReadLine();

            Console.WriteLine("Enter Second Number ");
            string secondNum = Console.ReadLine();
            int num2 = int.Parse(secondNum);

            if(op == "+")
            {
                int result = num1 + num2;
                Console.WriteLine("Result of Calculation is: " + result);
            } else if(op == "-")
            {
                Console.WriteLine("Result of Calculation is: " + (num1 - num2));
            } else if(op == "/")
            {
                Console.WriteLine("Result of Calclulation is:  "+ (num1 / num2));
            } else if(op == "*")
            {
                Console.WriteLine("Result of Calculation is: " + (num1 * num2));
            } else
            {
                Console.WriteLine("Enter correct numbers and operators");
            }

        }
    }
}