using System;
using System.Collections.Generic;
using System.Text;

namespace PROG_Pt1_RESUBMISSION
{
    // Handles user input and input validation.
    public class UserInput
    {
        public string GetName()
        {
            while (true)
            {
                Console.Write("Please enter your name: ");
                string? input = Console.ReadLine();

                //string.IsNullOrWhiteSpace is used to check whether the input is null,
                //empty, or only whitespace (Microsoft, 2025).
                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input.Trim();
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Name cannot be empty. Please try again.");
                Console.ResetColor();
            }
        }

        public string GetQuestion()
        {
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                return "";
            }

            return input.Trim().ToLower();
        }
    }
}
