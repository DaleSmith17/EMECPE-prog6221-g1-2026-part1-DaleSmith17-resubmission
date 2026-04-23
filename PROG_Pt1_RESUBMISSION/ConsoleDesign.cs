using System;
using System.Collections.Generic;
using System.Text;

namespace PROG_Pt1_RESUBMISSION
{
    public class ConsoleDesign
    {
        public void ShowTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("==============================================================");
            Console.WriteLine("              CYBERSECURITY AWARENESS CHATBOT                 ");
            Console.WriteLine("==============================================================");
            Console.ResetColor();
        }

        public void ShowMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void ShowBotResponses(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Bot: " + message);
            Console.ResetColor();
        }

    }
}
