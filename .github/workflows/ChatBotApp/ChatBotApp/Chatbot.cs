using System;

namespace CybersecurityBot
{
    public class Chatbot
    {
        private MultimediaManager _media = new MultimediaManager();
        public string UserName { get; set; }

        public void Start()
        {
            _media.PlayGreeting();
            _media.DisplayAsciiLogo();

            _media.TypingEffect("Hello! Welcome to the Cybersecurity Awareness Bot.");
            _media.TypingEffect("I’m here to help you stay safe online.");
            Console.WriteLine("-------------------------------------------------");

            // User Interaction 
            Console.Write("Before we begin, what is your name? ");
            UserName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(UserName))
            {
                UserName = "User";
            }

            _media.TypingEffect($"\nNice to meet you, {UserName}!");
            ShowMenu();
            RunConversation();
        }

        private void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine("You can ask me about:");
            Console.WriteLine("1. Password Safety");
            Console.WriteLine("2. Phishing");
            Console.WriteLine("3. Safe Browsing");
            Console.WriteLine("4. 'How are you?' / 'What is your purpose?'");
            Console.WriteLine("5. Exit");
            Console.ResetColor();
        }

        private void RunConversation()
        {
            bool active = true;
            while (active)
            {
                Console.Write($"\n[{UserName}]: ");
                string input = Console.ReadLine()?.ToLower().Trim();

                // Input Validation 
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Bot: I didn't quite catch that. Could you please type something?");
                    continue;
                }

                // Basic Response System
                if (input.Contains("how are you"))
                {
                    _media.TypingEffect("Bot: I'm functioning perfectly and ready to help you secure your data!");
                }
                else if (input.Contains("purpose"))
                {
                    _media.TypingEffect("Bot: My purpose is to educate users on essential cybersecurity practices.");
                }
                else if (input.Contains("password"))
                {
                    _media.TypingEffect("Bot: Always use at least 12 characters, including symbols and numbers. Never reuse passwords!");
                }
                else if (input.Contains("phishing"))
                {
                    _media.TypingEffect("Bot: Watch out for suspicious links and 'urgent' emails asking for login details.");
                }
                else if (input.Contains("browsing"))
                {
                    _media.TypingEffect("Bot: Ensure sites use HTTPS and avoid clicking on pop-up advertisements.");
                }
                else if (input.Contains("exit") || input.Contains("quit"))
                {
                    _media.TypingEffect($"Bot: Stay safe out there, {UserName}! Goodbye.");
                    active = false;
                }
                else
                {
                    // Default response 
                    Console.WriteLine("Bot: I didn't quite understand that. Could you rephrase? (Try asking about 'passwords' or 'phishing')");
                }
            }
        }
    }
}