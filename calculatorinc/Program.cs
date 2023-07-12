using System;

namespace EntryPoint
{
    public class MainProgram
    {
        public static void Main()
        {

            //Calculate();

            bool login = false;

            Console.WriteLine("Welecome to the Calculator App !!, Press 'S' and hit Enter to Start the Applicatioin");
            string input = Console.ReadLine();

            if (input == "s" || input == "S")
            {
                Calculate();
            }

            else
            {
                Console.WriteLine("!! Calculator Starts only after Pressing 'S' and hitting enter !!");
            }




        }

        public static void Calculate() {
            //bool login = false;


            //if (input == "s" || input == "S" || login == true)
            //{
                Console.WriteLine("Enter First Number ");
                string firstNum = Console.ReadLine();

                int num1 = int.Parse(firstNum);


                Console.WriteLine("Enter Operator ");
                string op = Console.ReadLine();

                Console.WriteLine("Enter Second Number ");
                string secondNum = Console.ReadLine();
                int num2 = int.Parse(secondNum);

                if (op == "+")
                {
                    int result = num1 + num2;
                    Console.WriteLine("Result of Calculation is: " + result);
                }
                else if (op == "-")
                {
                    Console.WriteLine("Result of Calculation is: " + (num1 - num2));
                }
                else if (op == "/")
                {
                    Console.WriteLine("Result of Calclulation is:  " + (num1 / num2));
                }
                else if (op == "*")
                {
                    Console.WriteLine("Result of Calculation is: " + (num1 * num2));
                }
                else
                {
                    Console.WriteLine("Enter correct numbers and operators !!");
                }

            Console.WriteLine("Do you want to use calculator again? If yes press 'S' and hit enter");
            string secondInput = Console.ReadLine();
            if (secondInput == "S" || secondInput == "s")
            {
                Main();
            }

        }

    }
    
}