using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using nanoFramework.M5Core2;
using nanoFramework.M5Stack;
using nanoFramework.Runtime;
using nanoFramework.Presentation;
using nanoFramework.System;
using nanoFramework.UI;
using nanoFramework.Hardware;
using nanoFramework.Hardware.Esp32;
using nanoFramework.Hardware.Esp32.Touch;
using nanoFramework.Presentation.Media;
using nanoFramework.Presentation.Controls;
using nanoFramework.Presentation.Shapes;
using Console = nanoFramework.M5Stack.Console;

namespace Playground1
{
    public class Program
    {
        public static void Main()
        {
            // Debug.WriteLine("Hello from nanoFramework!");

            M5Core2.InitializeScreen(2 * 1024 * 1024);
            M5Core2.InitializeScreen();
            Thread.Sleep(1000);
            // Screen.Enabled = true;

            while (true) {

                M5Core2.Vibrate = true;
                M5Core2.PowerLed = true;

                Thread.Sleep(1000);

                M5Core2.Vibrate = false;
                M5Core2.PowerLed = false;

                Thread.Sleep(1000);

            }

            // Console.Clear();

            // Test the console display
            // Console.Write("This is a short text. ");
            // Console.ForegroundColor = Color.Red;
            // Console.WriteLine("This one displays in red after the previous one and is already at the next line.");
            // Console.BackgroundColor = Color.Yellow;
            // Console.ForegroundColor = Color.RoyalBlue;
            // Console.WriteLine("And this is blue on yellow background");
            // Console.ResetColor();
            // Console.CursorLeft = 0;
            // Console.CursorTop = 8;
            // Console.Write("This is white on black again and on 9th line");

            // for (var i = 0; i < 100; i++)
            // {
            //     Console.WriteLine($"Line {i}");
            // }

            // Thread.Sleep(Timeout.Infinite);

            // Browse our samples repository: https://github.com/nanoframework/samples
            // Check our documentation online: https://docs.nanoframework.net/
            // Join our lively Discord community: https://discord.gg/gCyBu8T
        }
    }
}
