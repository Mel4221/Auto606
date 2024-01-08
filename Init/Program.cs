using System;
using System.Diagnostics; 

namespace Init
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string program, runner;
            program = null;
            runner = null; 
            if (args.Length == 2)
            {
                program = args[0];
                runner = args[1]; 
            }
            if(args.Length  < 2)
            {
                runner = "mono"; 
                program = "Auto606.exe";
            }
            if(!System.IO.File.Exists(program))
            {
                //red "There was an error with the fall
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The Program {program} was not Found or not exist");
                return;
            }
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = runner;
            info.Arguments = program;
            Process process = Process.Start(info);
            process.WaitForExit(); 
        }
    }
}
