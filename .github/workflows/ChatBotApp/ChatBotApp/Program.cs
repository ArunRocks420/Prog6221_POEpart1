namespace CybersecurityBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set console title
            Console.Title = "Cybersecurity Awareness Bot v1.0";

            Chatbot myBot = new Chatbot();
            myBot.Start();
        }
    }
}