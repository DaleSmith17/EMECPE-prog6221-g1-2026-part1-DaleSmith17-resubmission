using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace PROG_Pt1_RESUBMISSION
{
    // Plays the chatbot greeting audio when the application starts.
    public class AudioPlayer
    {
        // Loads and plays the greeting WAV file.
        public void PlayGreeting()
        {
            try
            {
                string filepath = "C:/Users/dales/OneDrive/Documents/Sound Recordings/PROG6221 Greeting.wav";

                if (File.Exists(filepath))
                {
                    //SoundPlayer is used becuase Micorsoft documents it as a class
                    //for loading and playing WAV files in .NET applications (Microsoft, 2025).
                    SoundPlayer player = new SoundPlayer(filepath);
                    player.Load();
                    player.PlaySync();
                }
                else
                {
                    Console.WriteLine("The voice greeting WAV file was not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing audio: " + ex.Message);
            }
        }
    }
}
