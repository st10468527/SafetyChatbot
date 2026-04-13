using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafetyChatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            VoiceGreeting voice = new VoiceGreeting();
            voice.Greet();
            ASCIIart Greet = new ASCIIart();
            Greet.Logo();
            User_Engagement user = new User_Engagement();
            user.promptUser();

        }
    }
}
