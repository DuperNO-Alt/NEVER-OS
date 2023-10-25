using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sys = Cosmos.System;
using System.Timers;

namespace NEVER_OS
{
    internal class HandleInputLA
    {
        public static void HandleThisCommand(string input)
        {
            string inputTheme = "";
            if (input == "help" || input == "h")
            {
                Console.WriteLine("help / h -- List Of Commands");
                Console.WriteLine("ver / v -- Version Of The OS");
                Console.WriteLine("echo / p -- echoes the command");
                Console.WriteLine("NeverOS / NOS -- Go Back To NEVER-OS");
                Console.WriteLine("time / t -- Shows The Current Time");
                Console.WriteLine("theme / th -- Change Theme");
                Console.WriteLine("beep / b -- Play The 'Beep' Sound");
                Console.WriteLine("shutdown / s -- Shut Down The Computer/VM");
                Console.WriteLine("reboot / r -- Restart The Computer/VM");
                Console.WriteLine("clearscreen / cls -- Clears All Existing Text");
            }
            else if (input == "ver" || input == "v")
            {
                Console.WriteLine("Never-OS Console Version 1.0.1 (Basically NEVER-Space)");
                Console.WriteLine("Made Using COSMOS Developer Kit Latest Version");
                Console.WriteLine();
                Console.WriteLine("Started Development On 24.10.2023");
                Console.WriteLine("Not Affilated With Microsoft");
            }
            else if (input == "echo" || input == "p")
            {
                Console.WriteLine("Text To Echo");
                string echoinput = Console.ReadLine();
                Console.WriteLine(echoinput);
            }
            else if (input == "time" || input == "t")
            {
                Console.WriteLine("Current Time Is " + DateTime.Now.ToString("dd.MM.yyyy"));
            }
            else if (input == "NeverOS" || input == "NOS")
            {
                Console.WriteLine("Entering OS...");
                Console.WriteLine("Reboot Required, Rebooting In 0 Seconds...");
                Console.WriteLine("Rebooting...");
                Sys.Power.Reboot();
            }
            else if (input == "theme" || input == "th")
            {
                Console.WriteLine("Choose Theme: Dark, Light, Blue, Dark Blue");
                inputTheme = Console.ReadLine();
                if (inputTheme == "Dark")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                }
                else if (inputTheme == "Light")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Clear();
                }
                else if (inputTheme == "Dark Blue")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                }
                else if (inputTheme == "Blue")
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Theme Does Not Exist/Its Case Sensitive");
                }
            }
            else if (input == "beep" || input == "b")
            {
                Console.WriteLine("Playing The 'Beep' Sound");
                Console.Beep();
            }
            else if (input == "shutdown" || input == "s")
            {
                Cosmos.System.Power.Shutdown();
            }
            else if (input == "reboot" || input == "r")
            {
                Cosmos.System.Power.Reboot();
            
            }
            else if (input == "clearscreen" || input == "cls")
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Command Not Found, type 'help' for a list of commands.");
            }
        }
    }
}