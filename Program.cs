using System;
using Init;
using QuickTools.QCore; 
using Gtk;

namespace Auto606
{
    class MainClass
    {
        public bool HasValidArguments(string[] args)
        {
            bool valid = false;
            Auto606Settings settings = new Auto606Settings();
            if (settings.GetSetting("ByPassInit") == "true") return true; 

            return valid; 
        }


        private void Start(string[] args)
        {
            switch (this.HasValidArguments(args))
            {
                case true:
                    Application.Init();
                    VentanaPrincipal win = new VentanaPrincipal();
                    win.Show();
                    Application.Run();
                    break;
                case false:
                    Get.Red("ByPassInit is Set to false and no arguments were provided to start");
                    Get.Wait();
                    break;
            }
        }
        public static void Main(string[] args)
        {
            MainClass main = new MainClass();
            main.Start(args);
        }
    }
}
