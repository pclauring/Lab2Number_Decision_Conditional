using System;

namespace Lab2_Decision_Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            do
            {
                Console.Write("Please enter an integer from (1-100): ");

                string oddOrEven = Console.ReadLine();
                int.TryParse(oddOrEven, out int TestInt);

                Console.Write("Output: ");

                if ((TestInt % 2) == 0)
                {
                    if (TestInt >= 2 && TestInt <= 25)
                    {
                        Console.WriteLine("The integer is even and less than 25.");
                    }
                    else if (TestInt >= 26 && TestInt <= 60)
                    {
                        Console.WriteLine("Even.");
                    }
                    else if (TestInt > 60)
                    {
                        Console.WriteLine("{0}: Even.", TestInt);
                    }
                }
                else if (TestInt > 60)
                {
                    Console.WriteLine("{0}: Odd.", TestInt);
                }
                else
                {
                    Console.WriteLine("Odd.");
                }

                Console.WriteLine("Would you like to repeat (y/n)? :");

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
    }
}
