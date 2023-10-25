using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using System;
using System.Drawing;
using Sys = Cosmos.System;
using Applications = NEVER_OS.Processes;
using Cosmos.System;
using Console = System.Console;
using HandleInput = NEVER_OS.HandleInputLA;

namespace NEVER_OS
{
    public class Kernel : Sys.Kernel
    {

        public static Canvas canvas;

        uint x = 640;
        uint y = 480;
        protected override void BeforeRun()
        {
            Console.WriteLine("Console Ran Successfully, Loading GUI...");
            Console.Clear();
            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(x, y, ColorDepth.ColorDepth32));
            Sys.MouseManager.ScreenWidth = x;
            Sys.MouseManager.ScreenHeight = y;
            Sys.MouseManager.MouseSensitivity = 0.8f;
        }

        protected override void Run()
        {
            canvas.Clear(Color.Teal);
            canvas.DrawString("NEVER-OS Test Build 0005", PCScreenFont.Default, Color.White, 1, 1);
            canvas.DrawString("e - exit to console mode", PCScreenFont.Default, Color.White, 1, 30);
            Applications.Taskbar(x, y, 30, canvas);
            bool key = KeyboardManager.TryReadKey(out KeyEvent e);
            if (key)
            {
                string input = "";
                key = false;
                canvas.Disable();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Entered Console Mode, Type 'help' For Available Commands");
                while (true)
                {
                    input = Console.ReadLine();
                    HandleInput.HandleThisCommand(input);
                }
            }

            // Add(ed) Mouse Here
            canvas.DrawFilledCircle(Color.White, (int)Sys.MouseManager.X, (int)Sys.MouseManager.Y, 5);

            canvas.Display();
        }
    }
}