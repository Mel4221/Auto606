using System;
using System.Diagnostics; 

namespace Init
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "mono";
            info.Arguments = "Auto606.exe";
            Process process = Process.Start(info);
            process.WaitForExit(); 
        }
    }
}
