using System;
using System.Media;
using System.Threading;

namespace CybersecurityBot
{
    public class MultimediaManager
    {
        // Automatic properties for customization
        public string AudioFilePath { get; set; } = "greeting.wav";

        public void PlayGreeting()
        {
            try
            {
                // Plays the WAV file 
                using (SoundPlayer player = new SoundPlayer(AudioFilePath))
                {
                    player.Play();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("[System Note: Audio file not found, skipping voice greeting.]");
            }
        }

        public void DisplayAsciiLogo()
        {
            // ASCII Art Logo 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
   _________________________________________________
  /                                                 \
 |    _________    ___.                               |
 |    \_   ___ \___\_ |__   __________________        |
 |    /    \  \/\__ \| __ \_/ __ \_  __ \_  __ \      |
 |    \     \____/ __ \ \_\ \  ___/|  | \/|  | \/      |
 |     \______  (____  /___  /\___  >__|   |__|         |
 |            \/     \/    \/     \/                   |
 |           S E C U R I T Y   A W A R E N E S S        |
  \_________________________________________________/
            ");
            Console.ResetColor();
        }

        public void TypingEffect(string message, int speed = 30)
        {
            // Simulates a conversational feel
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
            Console.WriteLine();
        }
    }
}