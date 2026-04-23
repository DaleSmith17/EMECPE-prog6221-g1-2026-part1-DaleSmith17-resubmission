using System;
using System.Collections.Generic;
using System.Text;

namespace PROG_Pt1_RESUBMISSION
{
    // Stores and returns chatbot responses based on user questions.
    public class BotResponses
    {
        public string GetResponse(string input, string userName)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "I didn’t quite understand that. Please type a question.";
            }

            if (input.Contains("how are you"))
            {
                return $"I am doing well, {userName}. I am ready to help you stay safe online.";
            }
            else if (input.Contains("help"))
            {
                return $"What can I help you with {userName}? You can ask me anything to help you with your cyber security needs :)";
            }
            else if (input.Contains("purpose") || input.Contains("what do you do"))
            {
                return "My purpose is to teach users about cybersecurity awareness and safe online behaviour.";
            }
            else if (input.Contains("what can i ask"))
            {
                return "You can ask me about passwords, phishing, malware, suspicious links, and safe browsing.";
            }
            else if (input.Contains("password"))
            {
                // Password advice is included because weak or reused passwords increase
                // exposure to cyber risk (Pieterse, 2021).
                return "Use strong passwords with upper-case letters, lower-case letters, numbers, and symbols. Do not reuse the same password on multiple accounts.";
            }
            else if (input.Contains("phishing"))
            {
                // Phishing is a cyber threat that tricks users into revealing sensitive
                // information through deceptive messages or websites (Pieterse, 2021).
                return "Phishing is when criminals try to trick you into giving away personal information through fake emails, SMSs, or websites. Always check the sender and the website link carefully.";
            }
            else if (input.Contains("safe") || input.Contains("browsing"))
            {
                return "Safe browsing means avoiding suspicious websites, not downloading unknown files, and checking links before clicking on them.";
            }
            else if (input.Contains("malware") || input.Contains("hamful"))
            {
                return "Malware is harmful software that can damage your device or steal your information. Avoid downloading files from unknown sources.";
            }
            else if (input.Contains("link") || input.Contains("suspicious"))
            {
                return "A suspicious link may contain strange spelling, random numbers, or a fake website address. If you are unsure, do not click it.";
            }
            else if (input.Contains("hello") || input.Contains("hi") || input.Contains("hey"))
            {
                return $"Hello, {userName}! What cybersecurity question would you like help with?";
            }
            else
            {
                return "I didn’t quite understand that. Ask me about passwords, phishing, malware, suspicious links, or safe browsing.";
            }
        }
    }
}
