using System;
using System.Media;
using System.IO;

namespace SafetyChatbot
{
    public class VoiceGreeting
    {
        public void Greet()
        {
            try
            {
                // This finds the file in your project's output folder automatically
                string fullpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "botAudio.wav");

                if (File.Exists(fullpath))
                {
                    using (SoundPlayer voice_play = new SoundPlayer(fullpath))
                    {
                        voice_play.Load();
                        voice_play.Play();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audio could not play: " + ex.Message);
            }
        }
    }
}