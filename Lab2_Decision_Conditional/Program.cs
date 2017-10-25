using System;

namespace Lab2_Decision_Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            string name;
            do
            {
                Console.Write("What is your name? ");

                name = Console.ReadLine();
                Console.Write("{0} please enter an integer from (1-100): ", name);

                //Validation of integer entry
                int testInt = Validation(name);

                Console.Write("Output: ");

                //modulus to determine if even
                if ((testInt % 2) == 0)
                {
                    if (testInt >= 2 && testInt <= 25)
                    {
                        Console.WriteLine("Even and less than 25.");
                    }
                    else if (testInt >= 26 && testInt <= 60)
                    {
                        Console.WriteLine("Even.");
                    }
                    else if (testInt > 60)
                    {
                        Console.WriteLine("{0}: Even.", testInt);
                    }
                } //odd numbers past this else if
                else if (testInt > 60)
                {
                    Console.WriteLine("{0}: Odd.", testInt);
                }
                else
                {
                    Console.WriteLine("{0} and Odd.", testInt);
                }

                Console.WriteLine("{0} would you like to repeat (y/n)? :", name);

                bool validAnswer = true;
                while (validAnswer)
                {
                    string repeatPrompt = Console.ReadLine();
                    if (repeatPrompt == "y" || repeatPrompt == "Y" || repeatPrompt == "yes")
                    {
                        repeat = true;
                        validAnswer = false;
                    }
                    else if (repeatPrompt == "n" || repeatPrompt == "N" || repeatPrompt == "no")
                    {
                        Console.WriteLine("Okay exiting the program now.");
                        repeat = false;
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Didn't enter a valid answer. Would you like to test another number (y/n)?: ");
                        validAnswer = true;
                    }
                }

            } while (repeat);
        }
        private static int Validation(string x)
        {
            while (true)
            {
                string oddOrEven = Console.ReadLine();
                bool success = int.TryParse(oddOrEven, out int TestInt);
                if (success && TestInt >= 1 && TestInt <= 100)
                {

                    return TestInt;
                }
                else
                    Console.Write("{0}... you did not enter a valid integer from 1 to 100, Please try again: ", x);

            }
        }
    }
}
