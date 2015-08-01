using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastIM.Log;
using R4PE.Log;

namespace R4PE.Log.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.EnableConsoleLogging();
            Logger.EnableFileLogging(Environment.CurrentDirectory + "\\testlogfile.txt");


            Logger.WriteLine("Hallo Welt", LogLevel.Info);
            Logger.WriteLine("Hallo Welt", LogLevel.Warn);
            Logger.WriteLine("Hallo Welt", LogLevel.Fatal);
            Logger.WriteLine("Hallo Welt", LogLevel.Debug);

            Logger.WriteLine("Hallo Welt", LogLevel.Info, "test");

            Logger.consoleFormat = "%message%";

            Logger.WriteLine("Hallo Welt", LogLevel.Info, "test");

            Logger.AddLogLevel("mc", "Minecraft", ConsoleColor.Blue);

            Logger.CWriteLine("hallo welt", "mc");


            Logger.WriteLine(Logger.ReadLine("> "),LogLevel.Warn);

            Logger.ReadLine();


        }
    }
}
