﻿using System;
using Init; 
using Gtk;

namespace Auto606
{
    class MainClass
    {
        public bool HasValidArguments(string[] args)
        {
            bool valid = false;
            




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
