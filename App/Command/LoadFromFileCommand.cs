using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace App.Command
{
    class LoadFromFileCommand : ICommand
    {
        public string GetMenuRow()
        {
            return "Loaded from file";
        }
        public bool Run()
        {
            WriteLine("Loaded");
            return false;
        }
    }
}
