using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace SafetyChatbot
{
    public class ASCIIart
    {
        
        public void Logo()
        {

            //path of the logo [ where the logo is ]
            string path = string.Empty;

            //auto get the full path
            string fullpath = AppDomain.CurrentDomain.BaseDirectory;
            //now combine the paths
            path = fullpath.Replace(@"bin\Debug\", "IMG-20260412-WA0000.jpg");
            Bitmap image = new Bitmap(path);

            
            int width = 170;
            int height = 70; //(image.Height * width) / image.Width;
            Bitmap resized = new Bitmap(image, new Size(width, height));

            
            Console.ForegroundColor = ConsoleColor.Yellow;// COLOUR OF THE LOGO
            string asciiChars = "@#S%?*+;:,. ";//IT IS GOING TO USE THESE SYMBOLS TO DRAW THE IMAGE

            //start by the height
            for (int y = 0; y < resized.Height; y++)
            {
                //then width
                for (int x = 0; x < resized.Width; x++)
                {
                    //color the pixel on x and y
                    Color pixel = resized.GetPixel(x, y);

                    // Convert to grayscale
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    // Map grayscale to ASCII
                    int index = (gray * (asciiChars.Length - 1)) / 255;

                    Console.Write(asciiChars[index]);
                }
                Console.WriteLine();
            }
        

    }//end of class

        //added the geeting method in this call because i wanted both these methods to go hand in hand 
   

    }
}
            
        
    
