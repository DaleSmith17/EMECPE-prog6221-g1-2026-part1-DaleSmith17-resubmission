using System;
using System.Collections.Generic;
using System.Text;

namespace PROG_Pt1_RESUBMISSION
{
    // Controls the full chatbot program flow.
    public class ChatbotApp
    {
        private AudioPlayer audioPlayer;
        private AsciiArtDisplay asciiArtDisplay;
        private UserInput userInput;
        private BotResponses botResponses;
        private ConsoleDesign consoleDesign;

        public ChatbotApp()
        {
            audioPlayer = new AudioPlayer();
            asciiArtDisplay = new AsciiArtDisplay();
            userInput = new UserInput();
            botResponses = new BotResponses();
            consoleDesign = new ConsoleDesign();
        }

        public void Run()
        {
            asciiArtDisplay.ShowLogo();
            audioPlayer.PlayGreeting();
            consoleDesign.ShowTitle();

            string userName = userInput.GetName();

            consoleDesign.ShowMessage($"\nWelcome, {userName}!", ConsoleColor.DarkBlue);
            consoleDesign.ShowMessage("You can ask me about passwords, phishing, safe browsing, malware, or type 'exit' to quit.", ConsoleColor.DarkCyan);

            StartConversation(userName);
        }

        private void StartConversation(string userName)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write($"\n{userName}: ");
                Console.ResetColor();

                string input = userInput.GetQuestion();

                if (input == "exit")
                {
                    consoleDesign.ShowMessage($"Goodbye, {userName}. Stay safe online!", ConsoleColor.Red);
                    break;
                }

                string response = botResponses.GetResponse(input, userName);
                consoleDesign.ShowBotResponses(response);
            }
        }
    }
}
